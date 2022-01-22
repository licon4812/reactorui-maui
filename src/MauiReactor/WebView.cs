using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
//using MauiReactor.Shapes;
using MauiReactor.Internals;

namespace MauiReactor
{
    public partial interface IWebView : IView
    {
        PropertyValue<Microsoft.Maui.Controls.WebViewSource>? Source { get; set; }
        PropertyValue<System.Net.CookieContainer>? Cookies { get; set; }

        Action? NavigatedAction { get; set; }
        Action<object?, WebNavigatedEventArgs>? NavigatedActionWithArgs { get; set; }
        Action? NavigatingAction { get; set; }
        Action<object?, WebNavigatingEventArgs>? NavigatingActionWithArgs { get; set; }

    }
    public partial class WebView<T> : View<T>, IWebView where T : Microsoft.Maui.Controls.WebView, new()
    {
        public WebView()
        {

        }

        public WebView(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Controls.WebViewSource>? IWebView.Source { get; set; }
        PropertyValue<System.Net.CookieContainer>? IWebView.Cookies { get; set; }

        Action? IWebView.NavigatedAction { get; set; }
        Action<object?, WebNavigatedEventArgs>? IWebView.NavigatedActionWithArgs { get; set; }
        Action? IWebView.NavigatingAction { get; set; }
        Action<object?, WebNavigatingEventArgs>? IWebView.NavigatingActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIWebView = (IWebView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.WebView.SourceProperty, thisAsIWebView.Source);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.WebView.CookiesProperty, thisAsIWebView.Cookies);


            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIWebView = (IWebView)this;
            if (thisAsIWebView.NavigatedAction != null || thisAsIWebView.NavigatedActionWithArgs != null)
            {
                NativeControl.Navigated += NativeControl_Navigated;
            }
            if (thisAsIWebView.NavigatingAction != null || thisAsIWebView.NavigatingActionWithArgs != null)
            {
                NativeControl.Navigating += NativeControl_Navigating;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_Navigated(object? sender, WebNavigatedEventArgs e)
        {
            var thisAsIWebView = (IWebView)this;
            thisAsIWebView.NavigatedAction?.Invoke();
            thisAsIWebView.NavigatedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_Navigating(object? sender, WebNavigatingEventArgs e)
        {
            var thisAsIWebView = (IWebView)this;
            thisAsIWebView.NavigatingAction?.Invoke();
            thisAsIWebView.NavigatingActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.Navigated -= NativeControl_Navigated;
                NativeControl.Navigating -= NativeControl_Navigating;
            }

            base.OnDetachNativeEvents();
        }

    }

    public partial class WebView : WebView<Microsoft.Maui.Controls.WebView>
    {
        public WebView()
        {

        }

        public WebView(Action<Microsoft.Maui.Controls.WebView?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class WebViewExtensions
    {
        public static T Source<T>(this T webView, Microsoft.Maui.Controls.WebViewSource source) where T : IWebView
        {
            webView.Source = new PropertyValue<Microsoft.Maui.Controls.WebViewSource>(source);
            return webView;
        }

        public static T Source<T>(this T webView, Func<Microsoft.Maui.Controls.WebViewSource> sourceFunc) where T : IWebView
        {
            webView.Source = new PropertyValue<Microsoft.Maui.Controls.WebViewSource>(sourceFunc);
            return webView;
        }



        public static T Cookies<T>(this T webView, System.Net.CookieContainer cookies) where T : IWebView
        {
            webView.Cookies = new PropertyValue<System.Net.CookieContainer>(cookies);
            return webView;
        }

        public static T Cookies<T>(this T webView, Func<System.Net.CookieContainer> cookiesFunc) where T : IWebView
        {
            webView.Cookies = new PropertyValue<System.Net.CookieContainer>(cookiesFunc);
            return webView;
        }




        public static T OnNavigated<T>(this T webView, Action navigatedAction) where T : IWebView
        {
            webView.NavigatedAction = navigatedAction;
            return webView;
        }

        public static T OnNavigated<T>(this T webView, Action<object?, WebNavigatedEventArgs> navigatedActionWithArgs) where T : IWebView
        {
            webView.NavigatedActionWithArgs = navigatedActionWithArgs;
            return webView;
        }
        public static T OnNavigating<T>(this T webView, Action navigatingAction) where T : IWebView
        {
            webView.NavigatingAction = navigatingAction;
            return webView;
        }

        public static T OnNavigating<T>(this T webView, Action<object?, WebNavigatingEventArgs> navigatingActionWithArgs) where T : IWebView
        {
            webView.NavigatingActionWithArgs = navigatingActionWithArgs;
            return webView;
        }
    }
}
