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
    public partial interface ICarouselView : IItemsView
    {
        PropertyValue<bool>? Loop { get; set; }

        PropertyValue<Microsoft.Maui.Thickness>? PeekAreaInsets { get; set; }

        PropertyValue<bool>? IsBounceEnabled { get; set; }

        PropertyValue<bool>? IsSwipeEnabled { get; set; }

        PropertyValue<bool>? IsScrollAnimated { get; set; }

        PropertyValue<object>? CurrentItem { get; set; }

        PropertyValue<int>? Position { get; set; }

        PropertyValue<Microsoft.Maui.Controls.LinearItemsLayout>? ItemsLayout { get; set; }

        Action? CurrentItemChangedAction { get; set; }

        Action<object?, CurrentItemChangedEventArgs>? CurrentItemChangedActionWithArgs { get; set; }

        Action? PositionChangedAction { get; set; }

        Action<object?, PositionChangedEventArgs>? PositionChangedActionWithArgs { get; set; }
    }

    public partial class CarouselView<T> : ItemsView<T>, ICarouselView where T : Microsoft.Maui.Controls.CarouselView, new()
    {
        public CarouselView()
        {
        }

        public CarouselView(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<bool>? ICarouselView.Loop { get; set; }

        PropertyValue<Microsoft.Maui.Thickness>? ICarouselView.PeekAreaInsets { get; set; }

        PropertyValue<bool>? ICarouselView.IsBounceEnabled { get; set; }

        PropertyValue<bool>? ICarouselView.IsSwipeEnabled { get; set; }

        PropertyValue<bool>? ICarouselView.IsScrollAnimated { get; set; }

        PropertyValue<object>? ICarouselView.CurrentItem { get; set; }

        PropertyValue<int>? ICarouselView.Position { get; set; }

        PropertyValue<Microsoft.Maui.Controls.LinearItemsLayout>? ICarouselView.ItemsLayout { get; set; }

        Action? ICarouselView.CurrentItemChangedAction { get; set; }

        Action<object?, CurrentItemChangedEventArgs>? ICarouselView.CurrentItemChangedActionWithArgs { get; set; }

        Action? ICarouselView.PositionChangedAction { get; set; }

        Action<object?, PositionChangedEventArgs>? ICarouselView.PositionChangedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsICarouselView = (ICarouselView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CarouselView.LoopProperty, thisAsICarouselView.Loop);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty, thisAsICarouselView.PeekAreaInsets);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CarouselView.IsBounceEnabledProperty, thisAsICarouselView.IsBounceEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CarouselView.IsSwipeEnabledProperty, thisAsICarouselView.IsSwipeEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CarouselView.IsScrollAnimatedProperty, thisAsICarouselView.IsScrollAnimated);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CarouselView.CurrentItemProperty, thisAsICarouselView.CurrentItem);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CarouselView.PositionProperty, thisAsICarouselView.Position);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CarouselView.ItemsLayoutProperty, thisAsICarouselView.ItemsLayout);
            base.OnUpdate();
            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsICarouselView = (ICarouselView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty, thisAsICarouselView.PeekAreaInsets);
            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
        partial void OnAttachingNativeEvents();
        partial void OnDetachingNativeEvents();
        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsICarouselView = (ICarouselView)this;
            if (thisAsICarouselView.CurrentItemChangedAction != null || thisAsICarouselView.CurrentItemChangedActionWithArgs != null)
            {
                NativeControl.CurrentItemChanged += NativeControl_CurrentItemChanged;
            }

            if (thisAsICarouselView.PositionChangedAction != null || thisAsICarouselView.PositionChangedActionWithArgs != null)
            {
                NativeControl.PositionChanged += NativeControl_PositionChanged;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_CurrentItemChanged(object? sender, CurrentItemChangedEventArgs e)
        {
            var thisAsICarouselView = (ICarouselView)this;
            thisAsICarouselView.CurrentItemChangedAction?.Invoke();
            thisAsICarouselView.CurrentItemChangedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_PositionChanged(object? sender, PositionChangedEventArgs e)
        {
            var thisAsICarouselView = (ICarouselView)this;
            thisAsICarouselView.PositionChangedAction?.Invoke();
            thisAsICarouselView.PositionChangedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.CurrentItemChanged -= NativeControl_CurrentItemChanged;
                NativeControl.PositionChanged -= NativeControl_PositionChanged;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class CarouselView : CarouselView<Microsoft.Maui.Controls.CarouselView>
    {
        public CarouselView()
        {
        }

        public CarouselView(Action<Microsoft.Maui.Controls.CarouselView?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class CarouselViewExtensions
    {
        public static T Loop<T>(this T carouselView, bool loop)
            where T : ICarouselView
        {
            carouselView.Loop = new PropertyValue<bool>(loop);
            return carouselView;
        }

        public static T Loop<T>(this T carouselView, Func<bool> loopFunc)
            where T : ICarouselView
        {
            carouselView.Loop = new PropertyValue<bool>(loopFunc);
            return carouselView;
        }

        public static T PeekAreaInsets<T>(this T carouselView, Microsoft.Maui.Thickness peekAreaInsets, RxThicknessAnimation? customAnimation = null)
            where T : ICarouselView
        {
            carouselView.PeekAreaInsets = new PropertyValue<Microsoft.Maui.Thickness>(peekAreaInsets);
            carouselView.AppendAnimatable(Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty, customAnimation ?? new RxSimpleThicknessAnimation(peekAreaInsets), v => carouselView.PeekAreaInsets = new PropertyValue<Microsoft.Maui.Thickness>(v.CurrentValue()));
            return carouselView;
        }

        public static T PeekAreaInsets<T>(this T carouselView, Func<Microsoft.Maui.Thickness> peekAreaInsetsFunc)
            where T : ICarouselView
        {
            carouselView.PeekAreaInsets = new PropertyValue<Microsoft.Maui.Thickness>(peekAreaInsetsFunc);
            return carouselView;
        }

        public static T PeekAreaInsets<T>(this T carouselView, double leftRight, double topBottom, RxThicknessAnimation? customAnimation = null)
            where T : ICarouselView
        {
            carouselView.PeekAreaInsets = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(leftRight, topBottom));
            carouselView.AppendAnimatable(Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(leftRight, topBottom)), v => carouselView.PeekAreaInsets = new PropertyValue<Microsoft.Maui.Thickness>(v.CurrentValue()));
            return carouselView;
        }

        public static T PeekAreaInsets<T>(this T carouselView, double uniformSize, RxThicknessAnimation? customAnimation = null)
            where T : ICarouselView
        {
            carouselView.PeekAreaInsets = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(uniformSize));
            carouselView.AppendAnimatable(Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(uniformSize)), v => carouselView.PeekAreaInsets = new PropertyValue<Microsoft.Maui.Thickness>(v.CurrentValue()));
            return carouselView;
        }

        public static T PeekAreaInsets<T>(this T carouselView, double left, double top, double right, double bottom, RxThicknessAnimation? customAnimation = null)
            where T : ICarouselView
        {
            carouselView.PeekAreaInsets = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(left, top, right, bottom));
            carouselView.AppendAnimatable(Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(left, top, right, bottom)), v => carouselView.PeekAreaInsets = new PropertyValue<Microsoft.Maui.Thickness>(v.CurrentValue()));
            return carouselView;
        }

        public static T IsBounceEnabled<T>(this T carouselView, bool isBounceEnabled)
            where T : ICarouselView
        {
            carouselView.IsBounceEnabled = new PropertyValue<bool>(isBounceEnabled);
            return carouselView;
        }

        public static T IsBounceEnabled<T>(this T carouselView, Func<bool> isBounceEnabledFunc)
            where T : ICarouselView
        {
            carouselView.IsBounceEnabled = new PropertyValue<bool>(isBounceEnabledFunc);
            return carouselView;
        }

        public static T IsSwipeEnabled<T>(this T carouselView, bool isSwipeEnabled)
            where T : ICarouselView
        {
            carouselView.IsSwipeEnabled = new PropertyValue<bool>(isSwipeEnabled);
            return carouselView;
        }

        public static T IsSwipeEnabled<T>(this T carouselView, Func<bool> isSwipeEnabledFunc)
            where T : ICarouselView
        {
            carouselView.IsSwipeEnabled = new PropertyValue<bool>(isSwipeEnabledFunc);
            return carouselView;
        }

        public static T IsScrollAnimated<T>(this T carouselView, bool isScrollAnimated)
            where T : ICarouselView
        {
            carouselView.IsScrollAnimated = new PropertyValue<bool>(isScrollAnimated);
            return carouselView;
        }

        public static T IsScrollAnimated<T>(this T carouselView, Func<bool> isScrollAnimatedFunc)
            where T : ICarouselView
        {
            carouselView.IsScrollAnimated = new PropertyValue<bool>(isScrollAnimatedFunc);
            return carouselView;
        }

        public static T CurrentItem<T>(this T carouselView, object currentItem)
            where T : ICarouselView
        {
            carouselView.CurrentItem = new PropertyValue<object>(currentItem);
            return carouselView;
        }

        public static T CurrentItem<T>(this T carouselView, Func<object> currentItemFunc)
            where T : ICarouselView
        {
            carouselView.CurrentItem = new PropertyValue<object>(currentItemFunc);
            return carouselView;
        }

        public static T Position<T>(this T carouselView, int position)
            where T : ICarouselView
        {
            carouselView.Position = new PropertyValue<int>(position);
            return carouselView;
        }

        public static T Position<T>(this T carouselView, Func<int> positionFunc)
            where T : ICarouselView
        {
            carouselView.Position = new PropertyValue<int>(positionFunc);
            return carouselView;
        }

        public static T ItemsLayout<T>(this T carouselView, Microsoft.Maui.Controls.LinearItemsLayout itemsLayout)
            where T : ICarouselView
        {
            carouselView.ItemsLayout = new PropertyValue<Microsoft.Maui.Controls.LinearItemsLayout>(itemsLayout);
            return carouselView;
        }

        public static T ItemsLayout<T>(this T carouselView, Func<Microsoft.Maui.Controls.LinearItemsLayout> itemsLayoutFunc)
            where T : ICarouselView
        {
            carouselView.ItemsLayout = new PropertyValue<Microsoft.Maui.Controls.LinearItemsLayout>(itemsLayoutFunc);
            return carouselView;
        }

        public static T OnCurrentItemChanged<T>(this T carouselView, Action? currentItemChangedAction)
            where T : ICarouselView
        {
            carouselView.CurrentItemChangedAction = currentItemChangedAction;
            return carouselView;
        }

        public static T OnCurrentItemChanged<T>(this T carouselView, Action<object?, CurrentItemChangedEventArgs>? currentItemChangedActionWithArgs)
            where T : ICarouselView
        {
            carouselView.CurrentItemChangedActionWithArgs = currentItemChangedActionWithArgs;
            return carouselView;
        }

        public static T OnPositionChanged<T>(this T carouselView, Action? positionChangedAction)
            where T : ICarouselView
        {
            carouselView.PositionChangedAction = positionChangedAction;
            return carouselView;
        }

        public static T OnPositionChanged<T>(this T carouselView, Action<object?, PositionChangedEventArgs>? positionChangedActionWithArgs)
            where T : ICarouselView
        {
            carouselView.PositionChangedActionWithArgs = positionChangedActionWithArgs;
            return carouselView;
        }
    }
}