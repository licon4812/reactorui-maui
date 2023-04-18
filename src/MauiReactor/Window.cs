// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable
namespace MauiReactor
{
    public partial interface IWindow : INavigableElement
    {
        PropertyValue<string>? Title { get; set; }

        PropertyValue<Microsoft.Maui.FlowDirection>? FlowDirection { get; set; }

        PropertyValue<double>? X { get; set; }

        PropertyValue<double>? Y { get; set; }

        PropertyValue<double>? Width { get; set; }

        PropertyValue<double>? Height { get; set; }

        PropertyValue<double>? MaximumWidth { get; set; }

        PropertyValue<double>? MaximumHeight { get; set; }

        PropertyValue<double>? MinimumWidth { get; set; }

        PropertyValue<double>? MinimumHeight { get; set; }

        Action? SizeChangedAction { get; set; }

        Action<object?, EventArgs>? SizeChangedActionWithArgs { get; set; }

        Action? ModalPoppedAction { get; set; }

        Action<object?, ModalPoppedEventArgs>? ModalPoppedActionWithArgs { get; set; }

        Action? ModalPoppingAction { get; set; }

        Action<object?, ModalPoppingEventArgs>? ModalPoppingActionWithArgs { get; set; }

        Action? ModalPushedAction { get; set; }

        Action<object?, ModalPushedEventArgs>? ModalPushedActionWithArgs { get; set; }

        Action? ModalPushingAction { get; set; }

        Action<object?, ModalPushingEventArgs>? ModalPushingActionWithArgs { get; set; }

        Action? PopCanceledAction { get; set; }

        Action<object?, EventArgs>? PopCanceledActionWithArgs { get; set; }

        Action? CreatedAction { get; set; }

        Action<object?, EventArgs>? CreatedActionWithArgs { get; set; }

        Action? ResumedAction { get; set; }

        Action<object?, EventArgs>? ResumedActionWithArgs { get; set; }

        Action? ActivatedAction { get; set; }

        Action<object?, EventArgs>? ActivatedActionWithArgs { get; set; }

        Action? DeactivatedAction { get; set; }

        Action<object?, EventArgs>? DeactivatedActionWithArgs { get; set; }

        Action? StoppedAction { get; set; }

        Action<object?, EventArgs>? StoppedActionWithArgs { get; set; }

        Action? DestroyingAction { get; set; }

        Action<object?, EventArgs>? DestroyingActionWithArgs { get; set; }

        Action? BackgroundingAction { get; set; }

        Action<object?, BackgroundingEventArgs>? BackgroundingActionWithArgs { get; set; }

        Action? DisplayDensityChangedAction { get; set; }

        Action<object?, DisplayDensityChangedEventArgs>? DisplayDensityChangedActionWithArgs { get; set; }
    }

    public partial class Window<T> : NavigableElement<T>, IWindow where T : Microsoft.Maui.Controls.Window, new()
    {
        public Window()
        {
        }

        public Window(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<string>? IWindow.Title { get; set; }

        PropertyValue<Microsoft.Maui.FlowDirection>? IWindow.FlowDirection { get; set; }

        PropertyValue<double>? IWindow.X { get; set; }

        PropertyValue<double>? IWindow.Y { get; set; }

        PropertyValue<double>? IWindow.Width { get; set; }

        PropertyValue<double>? IWindow.Height { get; set; }

        PropertyValue<double>? IWindow.MaximumWidth { get; set; }

        PropertyValue<double>? IWindow.MaximumHeight { get; set; }

        PropertyValue<double>? IWindow.MinimumWidth { get; set; }

        PropertyValue<double>? IWindow.MinimumHeight { get; set; }

        Action? IWindow.SizeChangedAction { get; set; }

        Action<object?, EventArgs>? IWindow.SizeChangedActionWithArgs { get; set; }

        Action? IWindow.ModalPoppedAction { get; set; }

        Action<object?, ModalPoppedEventArgs>? IWindow.ModalPoppedActionWithArgs { get; set; }

        Action? IWindow.ModalPoppingAction { get; set; }

        Action<object?, ModalPoppingEventArgs>? IWindow.ModalPoppingActionWithArgs { get; set; }

        Action? IWindow.ModalPushedAction { get; set; }

        Action<object?, ModalPushedEventArgs>? IWindow.ModalPushedActionWithArgs { get; set; }

        Action? IWindow.ModalPushingAction { get; set; }

        Action<object?, ModalPushingEventArgs>? IWindow.ModalPushingActionWithArgs { get; set; }

        Action? IWindow.PopCanceledAction { get; set; }

        Action<object?, EventArgs>? IWindow.PopCanceledActionWithArgs { get; set; }

        Action? IWindow.CreatedAction { get; set; }

        Action<object?, EventArgs>? IWindow.CreatedActionWithArgs { get; set; }

        Action? IWindow.ResumedAction { get; set; }

        Action<object?, EventArgs>? IWindow.ResumedActionWithArgs { get; set; }

        Action? IWindow.ActivatedAction { get; set; }

        Action<object?, EventArgs>? IWindow.ActivatedActionWithArgs { get; set; }

        Action? IWindow.DeactivatedAction { get; set; }

        Action<object?, EventArgs>? IWindow.DeactivatedActionWithArgs { get; set; }

        Action? IWindow.StoppedAction { get; set; }

        Action<object?, EventArgs>? IWindow.StoppedActionWithArgs { get; set; }

        Action? IWindow.DestroyingAction { get; set; }

        Action<object?, EventArgs>? IWindow.DestroyingActionWithArgs { get; set; }

        Action? IWindow.BackgroundingAction { get; set; }

        Action<object?, BackgroundingEventArgs>? IWindow.BackgroundingActionWithArgs { get; set; }

        Action? IWindow.DisplayDensityChangedAction { get; set; }

        Action<object?, DisplayDensityChangedEventArgs>? IWindow.DisplayDensityChangedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIWindow = (IWindow)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Window.TitleProperty, thisAsIWindow.Title);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Window.FlowDirectionProperty, thisAsIWindow.FlowDirection);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Window.XProperty, thisAsIWindow.X);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Window.YProperty, thisAsIWindow.Y);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Window.WidthProperty, thisAsIWindow.Width);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Window.HeightProperty, thisAsIWindow.Height);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Window.MaximumWidthProperty, thisAsIWindow.MaximumWidth);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Window.MaximumHeightProperty, thisAsIWindow.MaximumHeight);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Window.MinimumWidthProperty, thisAsIWindow.MinimumWidth);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Window.MinimumHeightProperty, thisAsIWindow.MinimumHeight);
            base.OnUpdate();
            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            OnBeginAnimate();
            var thisAsIWindow = (IWindow)this;
            AnimateProperty(Microsoft.Maui.Controls.Window.XProperty, thisAsIWindow.X);
            AnimateProperty(Microsoft.Maui.Controls.Window.YProperty, thisAsIWindow.Y);
            AnimateProperty(Microsoft.Maui.Controls.Window.WidthProperty, thisAsIWindow.Width);
            AnimateProperty(Microsoft.Maui.Controls.Window.HeightProperty, thisAsIWindow.Height);
            AnimateProperty(Microsoft.Maui.Controls.Window.MaximumWidthProperty, thisAsIWindow.MaximumWidth);
            AnimateProperty(Microsoft.Maui.Controls.Window.MaximumHeightProperty, thisAsIWindow.MaximumHeight);
            AnimateProperty(Microsoft.Maui.Controls.Window.MinimumWidthProperty, thisAsIWindow.MinimumWidth);
            AnimateProperty(Microsoft.Maui.Controls.Window.MinimumHeightProperty, thisAsIWindow.MinimumHeight);
            base.OnAnimate();
            OnEndAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
        partial void OnBeginAnimate();
        partial void OnEndAnimate();
        partial void OnAttachingNativeEvents();
        partial void OnDetachingNativeEvents();
        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIWindow = (IWindow)this;
            if (thisAsIWindow.SizeChangedAction != null || thisAsIWindow.SizeChangedActionWithArgs != null)
            {
                NativeControl.SizeChanged += NativeControl_SizeChanged;
            }

            if (thisAsIWindow.ModalPoppedAction != null || thisAsIWindow.ModalPoppedActionWithArgs != null)
            {
                NativeControl.ModalPopped += NativeControl_ModalPopped;
            }

            if (thisAsIWindow.ModalPoppingAction != null || thisAsIWindow.ModalPoppingActionWithArgs != null)
            {
                NativeControl.ModalPopping += NativeControl_ModalPopping;
            }

            if (thisAsIWindow.ModalPushedAction != null || thisAsIWindow.ModalPushedActionWithArgs != null)
            {
                NativeControl.ModalPushed += NativeControl_ModalPushed;
            }

            if (thisAsIWindow.ModalPushingAction != null || thisAsIWindow.ModalPushingActionWithArgs != null)
            {
                NativeControl.ModalPushing += NativeControl_ModalPushing;
            }

            if (thisAsIWindow.PopCanceledAction != null || thisAsIWindow.PopCanceledActionWithArgs != null)
            {
                NativeControl.PopCanceled += NativeControl_PopCanceled;
            }

            if (thisAsIWindow.CreatedAction != null || thisAsIWindow.CreatedActionWithArgs != null)
            {
                NativeControl.Created += NativeControl_Created;
            }

            if (thisAsIWindow.ResumedAction != null || thisAsIWindow.ResumedActionWithArgs != null)
            {
                NativeControl.Resumed += NativeControl_Resumed;
            }

            if (thisAsIWindow.ActivatedAction != null || thisAsIWindow.ActivatedActionWithArgs != null)
            {
                NativeControl.Activated += NativeControl_Activated;
            }

            if (thisAsIWindow.DeactivatedAction != null || thisAsIWindow.DeactivatedActionWithArgs != null)
            {
                NativeControl.Deactivated += NativeControl_Deactivated;
            }

            if (thisAsIWindow.StoppedAction != null || thisAsIWindow.StoppedActionWithArgs != null)
            {
                NativeControl.Stopped += NativeControl_Stopped;
            }

            if (thisAsIWindow.DestroyingAction != null || thisAsIWindow.DestroyingActionWithArgs != null)
            {
                NativeControl.Destroying += NativeControl_Destroying;
            }

            if (thisAsIWindow.BackgroundingAction != null || thisAsIWindow.BackgroundingActionWithArgs != null)
            {
                NativeControl.Backgrounding += NativeControl_Backgrounding;
            }

            if (thisAsIWindow.DisplayDensityChangedAction != null || thisAsIWindow.DisplayDensityChangedActionWithArgs != null)
            {
                NativeControl.DisplayDensityChanged += NativeControl_DisplayDensityChanged;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_SizeChanged(object? sender, EventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.SizeChangedAction?.Invoke();
            thisAsIWindow.SizeChangedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_ModalPopped(object? sender, ModalPoppedEventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.ModalPoppedAction?.Invoke();
            thisAsIWindow.ModalPoppedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_ModalPopping(object? sender, ModalPoppingEventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.ModalPoppingAction?.Invoke();
            thisAsIWindow.ModalPoppingActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_ModalPushed(object? sender, ModalPushedEventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.ModalPushedAction?.Invoke();
            thisAsIWindow.ModalPushedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_ModalPushing(object? sender, ModalPushingEventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.ModalPushingAction?.Invoke();
            thisAsIWindow.ModalPushingActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_PopCanceled(object? sender, EventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.PopCanceledAction?.Invoke();
            thisAsIWindow.PopCanceledActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_Created(object? sender, EventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.CreatedAction?.Invoke();
            thisAsIWindow.CreatedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_Resumed(object? sender, EventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.ResumedAction?.Invoke();
            thisAsIWindow.ResumedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_Activated(object? sender, EventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.ActivatedAction?.Invoke();
            thisAsIWindow.ActivatedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_Deactivated(object? sender, EventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.DeactivatedAction?.Invoke();
            thisAsIWindow.DeactivatedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_Stopped(object? sender, EventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.StoppedAction?.Invoke();
            thisAsIWindow.StoppedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_Destroying(object? sender, EventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.DestroyingAction?.Invoke();
            thisAsIWindow.DestroyingActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_Backgrounding(object? sender, BackgroundingEventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.BackgroundingAction?.Invoke();
            thisAsIWindow.BackgroundingActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_DisplayDensityChanged(object? sender, DisplayDensityChangedEventArgs e)
        {
            var thisAsIWindow = (IWindow)this;
            thisAsIWindow.DisplayDensityChangedAction?.Invoke();
            thisAsIWindow.DisplayDensityChangedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.SizeChanged -= NativeControl_SizeChanged;
                NativeControl.ModalPopped -= NativeControl_ModalPopped;
                NativeControl.ModalPopping -= NativeControl_ModalPopping;
                NativeControl.ModalPushed -= NativeControl_ModalPushed;
                NativeControl.ModalPushing -= NativeControl_ModalPushing;
                NativeControl.PopCanceled -= NativeControl_PopCanceled;
                NativeControl.Created -= NativeControl_Created;
                NativeControl.Resumed -= NativeControl_Resumed;
                NativeControl.Activated -= NativeControl_Activated;
                NativeControl.Deactivated -= NativeControl_Deactivated;
                NativeControl.Stopped -= NativeControl_Stopped;
                NativeControl.Destroying -= NativeControl_Destroying;
                NativeControl.Backgrounding -= NativeControl_Backgrounding;
                NativeControl.DisplayDensityChanged -= NativeControl_DisplayDensityChanged;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class Window : Window<Microsoft.Maui.Controls.Window>
    {
        public Window()
        {
        }

        public Window(Action<Microsoft.Maui.Controls.Window?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class WindowExtensions
    {
        public static T Title<T>(this T window, string title)
            where T : IWindow
        {
            window.Title = new PropertyValue<string>(title);
            return window;
        }

        public static T Title<T>(this T window, Func<string> titleFunc)
            where T : IWindow
        {
            window.Title = new PropertyValue<string>(titleFunc);
            return window;
        }

        public static T FlowDirection<T>(this T window, Microsoft.Maui.FlowDirection flowDirection)
            where T : IWindow
        {
            window.FlowDirection = new PropertyValue<Microsoft.Maui.FlowDirection>(flowDirection);
            return window;
        }

        public static T FlowDirection<T>(this T window, Func<Microsoft.Maui.FlowDirection> flowDirectionFunc)
            where T : IWindow
        {
            window.FlowDirection = new PropertyValue<Microsoft.Maui.FlowDirection>(flowDirectionFunc);
            return window;
        }

        public static T X<T>(this T window, double x, RxDoubleAnimation? customAnimation = null)
            where T : IWindow
        {
            window.X = new PropertyValue<double>(x);
            window.AppendAnimatable(Microsoft.Maui.Controls.Window.XProperty, customAnimation ?? new RxDoubleAnimation(x), v => window.X = new PropertyValue<double>(v.CurrentValue()));
            return window;
        }

        public static T X<T>(this T window, Func<double> xFunc)
            where T : IWindow
        {
            window.X = new PropertyValue<double>(xFunc);
            return window;
        }

        public static T Y<T>(this T window, double y, RxDoubleAnimation? customAnimation = null)
            where T : IWindow
        {
            window.Y = new PropertyValue<double>(y);
            window.AppendAnimatable(Microsoft.Maui.Controls.Window.YProperty, customAnimation ?? new RxDoubleAnimation(y), v => window.Y = new PropertyValue<double>(v.CurrentValue()));
            return window;
        }

        public static T Y<T>(this T window, Func<double> yFunc)
            where T : IWindow
        {
            window.Y = new PropertyValue<double>(yFunc);
            return window;
        }

        public static T Width<T>(this T window, double width, RxDoubleAnimation? customAnimation = null)
            where T : IWindow
        {
            window.Width = new PropertyValue<double>(width);
            window.AppendAnimatable(Microsoft.Maui.Controls.Window.WidthProperty, customAnimation ?? new RxDoubleAnimation(width), v => window.Width = new PropertyValue<double>(v.CurrentValue()));
            return window;
        }

        public static T Width<T>(this T window, Func<double> widthFunc)
            where T : IWindow
        {
            window.Width = new PropertyValue<double>(widthFunc);
            return window;
        }

        public static T Height<T>(this T window, double height, RxDoubleAnimation? customAnimation = null)
            where T : IWindow
        {
            window.Height = new PropertyValue<double>(height);
            window.AppendAnimatable(Microsoft.Maui.Controls.Window.HeightProperty, customAnimation ?? new RxDoubleAnimation(height), v => window.Height = new PropertyValue<double>(v.CurrentValue()));
            return window;
        }

        public static T Height<T>(this T window, Func<double> heightFunc)
            where T : IWindow
        {
            window.Height = new PropertyValue<double>(heightFunc);
            return window;
        }

        public static T MaximumWidth<T>(this T window, double maximumWidth, RxDoubleAnimation? customAnimation = null)
            where T : IWindow
        {
            window.MaximumWidth = new PropertyValue<double>(maximumWidth);
            window.AppendAnimatable(Microsoft.Maui.Controls.Window.MaximumWidthProperty, customAnimation ?? new RxDoubleAnimation(maximumWidth), v => window.MaximumWidth = new PropertyValue<double>(v.CurrentValue()));
            return window;
        }

        public static T MaximumWidth<T>(this T window, Func<double> maximumWidthFunc)
            where T : IWindow
        {
            window.MaximumWidth = new PropertyValue<double>(maximumWidthFunc);
            return window;
        }

        public static T MaximumHeight<T>(this T window, double maximumHeight, RxDoubleAnimation? customAnimation = null)
            where T : IWindow
        {
            window.MaximumHeight = new PropertyValue<double>(maximumHeight);
            window.AppendAnimatable(Microsoft.Maui.Controls.Window.MaximumHeightProperty, customAnimation ?? new RxDoubleAnimation(maximumHeight), v => window.MaximumHeight = new PropertyValue<double>(v.CurrentValue()));
            return window;
        }

        public static T MaximumHeight<T>(this T window, Func<double> maximumHeightFunc)
            where T : IWindow
        {
            window.MaximumHeight = new PropertyValue<double>(maximumHeightFunc);
            return window;
        }

        public static T MinimumWidth<T>(this T window, double minimumWidth, RxDoubleAnimation? customAnimation = null)
            where T : IWindow
        {
            window.MinimumWidth = new PropertyValue<double>(minimumWidth);
            window.AppendAnimatable(Microsoft.Maui.Controls.Window.MinimumWidthProperty, customAnimation ?? new RxDoubleAnimation(minimumWidth), v => window.MinimumWidth = new PropertyValue<double>(v.CurrentValue()));
            return window;
        }

        public static T MinimumWidth<T>(this T window, Func<double> minimumWidthFunc)
            where T : IWindow
        {
            window.MinimumWidth = new PropertyValue<double>(minimumWidthFunc);
            return window;
        }

        public static T MinimumHeight<T>(this T window, double minimumHeight, RxDoubleAnimation? customAnimation = null)
            where T : IWindow
        {
            window.MinimumHeight = new PropertyValue<double>(minimumHeight);
            window.AppendAnimatable(Microsoft.Maui.Controls.Window.MinimumHeightProperty, customAnimation ?? new RxDoubleAnimation(minimumHeight), v => window.MinimumHeight = new PropertyValue<double>(v.CurrentValue()));
            return window;
        }

        public static T MinimumHeight<T>(this T window, Func<double> minimumHeightFunc)
            where T : IWindow
        {
            window.MinimumHeight = new PropertyValue<double>(minimumHeightFunc);
            return window;
        }

        public static T OnSizeChanged<T>(this T window, Action? sizeChangedAction)
            where T : IWindow
        {
            window.SizeChangedAction = sizeChangedAction;
            return window;
        }

        public static T OnSizeChanged<T>(this T window, Action<object?, EventArgs>? sizeChangedActionWithArgs)
            where T : IWindow
        {
            window.SizeChangedActionWithArgs = sizeChangedActionWithArgs;
            return window;
        }

        public static T OnModalPopped<T>(this T window, Action? modalPoppedAction)
            where T : IWindow
        {
            window.ModalPoppedAction = modalPoppedAction;
            return window;
        }

        public static T OnModalPopped<T>(this T window, Action<object?, ModalPoppedEventArgs>? modalPoppedActionWithArgs)
            where T : IWindow
        {
            window.ModalPoppedActionWithArgs = modalPoppedActionWithArgs;
            return window;
        }

        public static T OnModalPopping<T>(this T window, Action? modalPoppingAction)
            where T : IWindow
        {
            window.ModalPoppingAction = modalPoppingAction;
            return window;
        }

        public static T OnModalPopping<T>(this T window, Action<object?, ModalPoppingEventArgs>? modalPoppingActionWithArgs)
            where T : IWindow
        {
            window.ModalPoppingActionWithArgs = modalPoppingActionWithArgs;
            return window;
        }

        public static T OnModalPushed<T>(this T window, Action? modalPushedAction)
            where T : IWindow
        {
            window.ModalPushedAction = modalPushedAction;
            return window;
        }

        public static T OnModalPushed<T>(this T window, Action<object?, ModalPushedEventArgs>? modalPushedActionWithArgs)
            where T : IWindow
        {
            window.ModalPushedActionWithArgs = modalPushedActionWithArgs;
            return window;
        }

        public static T OnModalPushing<T>(this T window, Action? modalPushingAction)
            where T : IWindow
        {
            window.ModalPushingAction = modalPushingAction;
            return window;
        }

        public static T OnModalPushing<T>(this T window, Action<object?, ModalPushingEventArgs>? modalPushingActionWithArgs)
            where T : IWindow
        {
            window.ModalPushingActionWithArgs = modalPushingActionWithArgs;
            return window;
        }

        public static T OnPopCanceled<T>(this T window, Action? popCanceledAction)
            where T : IWindow
        {
            window.PopCanceledAction = popCanceledAction;
            return window;
        }

        public static T OnPopCanceled<T>(this T window, Action<object?, EventArgs>? popCanceledActionWithArgs)
            where T : IWindow
        {
            window.PopCanceledActionWithArgs = popCanceledActionWithArgs;
            return window;
        }

        public static T OnCreated<T>(this T window, Action? createdAction)
            where T : IWindow
        {
            window.CreatedAction = createdAction;
            return window;
        }

        public static T OnCreated<T>(this T window, Action<object?, EventArgs>? createdActionWithArgs)
            where T : IWindow
        {
            window.CreatedActionWithArgs = createdActionWithArgs;
            return window;
        }

        public static T OnResumed<T>(this T window, Action? resumedAction)
            where T : IWindow
        {
            window.ResumedAction = resumedAction;
            return window;
        }

        public static T OnResumed<T>(this T window, Action<object?, EventArgs>? resumedActionWithArgs)
            where T : IWindow
        {
            window.ResumedActionWithArgs = resumedActionWithArgs;
            return window;
        }

        public static T OnActivated<T>(this T window, Action? activatedAction)
            where T : IWindow
        {
            window.ActivatedAction = activatedAction;
            return window;
        }

        public static T OnActivated<T>(this T window, Action<object?, EventArgs>? activatedActionWithArgs)
            where T : IWindow
        {
            window.ActivatedActionWithArgs = activatedActionWithArgs;
            return window;
        }

        public static T OnDeactivated<T>(this T window, Action? deactivatedAction)
            where T : IWindow
        {
            window.DeactivatedAction = deactivatedAction;
            return window;
        }

        public static T OnDeactivated<T>(this T window, Action<object?, EventArgs>? deactivatedActionWithArgs)
            where T : IWindow
        {
            window.DeactivatedActionWithArgs = deactivatedActionWithArgs;
            return window;
        }

        public static T OnStopped<T>(this T window, Action? stoppedAction)
            where T : IWindow
        {
            window.StoppedAction = stoppedAction;
            return window;
        }

        public static T OnStopped<T>(this T window, Action<object?, EventArgs>? stoppedActionWithArgs)
            where T : IWindow
        {
            window.StoppedActionWithArgs = stoppedActionWithArgs;
            return window;
        }

        public static T OnDestroying<T>(this T window, Action? destroyingAction)
            where T : IWindow
        {
            window.DestroyingAction = destroyingAction;
            return window;
        }

        public static T OnDestroying<T>(this T window, Action<object?, EventArgs>? destroyingActionWithArgs)
            where T : IWindow
        {
            window.DestroyingActionWithArgs = destroyingActionWithArgs;
            return window;
        }

        public static T OnBackgrounding<T>(this T window, Action? backgroundingAction)
            where T : IWindow
        {
            window.BackgroundingAction = backgroundingAction;
            return window;
        }

        public static T OnBackgrounding<T>(this T window, Action<object?, BackgroundingEventArgs>? backgroundingActionWithArgs)
            where T : IWindow
        {
            window.BackgroundingActionWithArgs = backgroundingActionWithArgs;
            return window;
        }

        public static T OnDisplayDensityChanged<T>(this T window, Action? displayDensityChangedAction)
            where T : IWindow
        {
            window.DisplayDensityChangedAction = displayDensityChangedAction;
            return window;
        }

        public static T OnDisplayDensityChanged<T>(this T window, Action<object?, DisplayDensityChangedEventArgs>? displayDensityChangedActionWithArgs)
            where T : IWindow
        {
            window.DisplayDensityChangedActionWithArgs = displayDensityChangedActionWithArgs;
            return window;
        }
    }
}