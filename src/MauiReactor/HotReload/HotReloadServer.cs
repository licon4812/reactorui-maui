﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactor.HotReload
{
    internal class HotReloadServer
    {
        private CancellationTokenSource? _cancellationTokenSource;
        private const int _listenPort = 45820;
        private readonly Action<Assembly> _newAssemblyReceived;

        public HotReloadServer(Action<Assembly> newAssemblyReceived)
        {
            _newAssemblyReceived = newAssemblyReceived;
        }

        public async void Run()
        {
            Stop();

            _cancellationTokenSource = new CancellationTokenSource();
            
            await ConnectionLoop(_cancellationTokenSource.Token);
        }

        public void Stop()
        {
            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource?.Dispose();
            _cancellationTokenSource = null;
        }

        private async Task ConnectionLoop(CancellationToken cancellationToken)
        {
            TcpListener? tcpListener = null;

            while (tcpListener == null && !cancellationToken.IsCancellationRequested)
            {
                try
                {
                    tcpListener = new TcpListener(IPAddress.Any, _listenPort);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[MauiReactor] Unable to bind hot-reload server to local address {_listenPort}, waiting 60000ms before try again:{Environment.NewLine}{ex}");

                    await Task.Delay(60000, cancellationToken);
                }
            }

            if (tcpListener == null)
            {
                return;
            }

            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    System.Diagnostics.Debug.WriteLine($"[MauiReactor] Hot-Reload server started listening on {_listenPort}");
                    tcpListener.Start();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[MauiReactor] Hot-Reload server is unable to list on port {_listenPort}:{Environment.NewLine}{ex}");
                    await Task.Delay(60000, cancellationToken);
                    continue;
                }

                while (!cancellationToken.IsCancellationRequested)
                {
                    Socket socketConnectedToClient;
                    try
                    {
                        socketConnectedToClient = await tcpListener.AcceptSocketAsync(cancellationToken);
                    }
                    catch (OperationCanceledException)
                    {
                        break;
                    }

                    //System.Diagnostics.Debug.WriteLine($"[MauiReactor] Hot-Reload connection accepted from {socketConnectedToClient.RemoteEndPoint}, begin connection loop");

                    socketConnectedToClient.ReceiveTimeout = 10000;
                    socketConnectedToClient.SendTimeout = 10000;

                    await StartConnectionLoop(socketConnectedToClient, cancellationToken);

                    System.Diagnostics.Debug.WriteLine($"[MauiReactor] Hot-Reload completed");
                }
            }

            tcpListener.Stop();
        }

        private async Task StartConnectionLoop(Socket socketConnectedToClient, CancellationToken cancellationToken)
        {
            using var socketStream = new NetworkStream(socketConnectedToClient);

            var bufferedStream = new BufferedStream(socketStream);

            int length = await bufferedStream.ReadInt32Async(cancellationToken);
            if (length == -1)
                return;

            var assemblyRaw = await bufferedStream.ReadAsync(length, cancellationToken);

            length = await bufferedStream.ReadInt32Async(cancellationToken);
            if (length > 0)
            {
                var assemblySymbolStoreRaw = await bufferedStream.ReadAsync(length, cancellationToken);

                _newAssemblyReceived?.Invoke(Assembly.Load(assemblyRaw, assemblySymbolStoreRaw));
            }
            else
            {
                _newAssemblyReceived?.Invoke(Assembly.Load(assemblyRaw));
            }

            await socketStream.WriteAsync(new byte[] { 0x1 }, cancellationToken);

            await socketStream.FlushAsync(cancellationToken);

            //System.Runtime.Loader.AssemblyLoadContext.Default.
        }

    }
}