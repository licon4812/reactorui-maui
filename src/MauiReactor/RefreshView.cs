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
    public partial interface IRefreshView : IContentView
    {
        PropertyValue<bool>? IsRefreshing { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? RefreshColor { get; set; }

        Action? RefreshingAction { get; set; }
        Action<object?, EventArgs>? RefreshingActionWithArgs { get; set; }

    }

    public partial class RefreshView<T> : ContentView<T>, IRefreshView where T : Microsoft.Maui.Controls.RefreshView, new()
    {
        public RefreshView()
        {

        }

        public RefreshView(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<bool>? IRefreshView.IsRefreshing { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? IRefreshView.RefreshColor { get; set; }

        Action? IRefreshView.RefreshingAction { get; set; }
        Action<object?, EventArgs>? IRefreshView.RefreshingActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIRefreshView = (IRefreshView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty, thisAsIRefreshView.IsRefreshing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RefreshView.RefreshColorProperty, thisAsIRefreshView.RefreshColor);


            base.OnUpdate();

            OnEndUpdate();
        }


        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIRefreshView = (IRefreshView)this;
            if (thisAsIRefreshView.RefreshingAction != null || thisAsIRefreshView.RefreshingActionWithArgs != null)
            {
                NativeControl.Refreshing += NativeControl_Refreshing;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_Refreshing(object? sender, EventArgs e)
        {
            var thisAsIRefreshView = (IRefreshView)this;
            thisAsIRefreshView.RefreshingAction?.Invoke();
            thisAsIRefreshView.RefreshingActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.Refreshing -= NativeControl_Refreshing;
            }

            base.OnDetachNativeEvents();
        }

    }

    public partial class RefreshView : RefreshView<Microsoft.Maui.Controls.RefreshView>
    {
        public RefreshView()
        {

        }

        public RefreshView(Action<Microsoft.Maui.Controls.RefreshView?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class RefreshViewExtensions
    {
        public static T IsRefreshing<T>(this T refreshView, bool isRefreshing) where T : IRefreshView
        {
            refreshView.IsRefreshing = new PropertyValue<bool>(isRefreshing);
            return refreshView;
        }

        public static T IsRefreshing<T>(this T refreshView, Func<bool> isRefreshingFunc) where T : IRefreshView
        {
            refreshView.IsRefreshing = new PropertyValue<bool>(isRefreshingFunc);
            return refreshView;
        }



        public static T RefreshColor<T>(this T refreshView, Microsoft.Maui.Graphics.Color refreshColor) where T : IRefreshView
        {
            refreshView.RefreshColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(refreshColor);
            return refreshView;
        }

        public static T RefreshColor<T>(this T refreshView, Func<Microsoft.Maui.Graphics.Color> refreshColorFunc) where T : IRefreshView
        {
            refreshView.RefreshColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(refreshColorFunc);
            return refreshView;
        }




        public static T OnRefreshing<T>(this T refreshView, Action refreshingAction) where T : IRefreshView
        {
            refreshView.RefreshingAction = refreshingAction;
            return refreshView;
        }

        public static T OnRefreshing<T>(this T refreshView, Action<object?, EventArgs> refreshingActionWithArgs) where T : IRefreshView
        {
            refreshView.RefreshingActionWithArgs = refreshingActionWithArgs;
            return refreshView;
        }
    }
}
