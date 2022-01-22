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
    public partial interface IVisualElement : INavigableElement
    {
        PropertyValue<Microsoft.Maui.Controls.Shadow>? Shadow { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Style>? Style { get; set; }
        PropertyValue<bool>? InputTransparent { get; set; }
        PropertyValue<bool>? IsEnabled { get; set; }
        PropertyValue<double>? AnchorX { get; set; }
        PropertyValue<double>? AnchorY { get; set; }
        PropertyValue<double>? TranslationX { get; set; }
        PropertyValue<double>? TranslationY { get; set; }
        PropertyValue<double>? Rotation { get; set; }
        PropertyValue<double>? RotationX { get; set; }
        PropertyValue<double>? RotationY { get; set; }
        PropertyValue<double>? Scale { get; set; }
        PropertyValue<double>? ScaleX { get; set; }
        PropertyValue<double>? ScaleY { get; set; }
        PropertyValue<Microsoft.Maui.Controls.IVisual>? Visual { get; set; }
        PropertyValue<bool>? IsVisible { get; set; }
        PropertyValue<double>? Opacity { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? BackgroundColor { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? Background { get; set; }
        PropertyValue<double>? WidthRequest { get; set; }
        PropertyValue<double>? HeightRequest { get; set; }
        PropertyValue<double>? MinimumWidthRequest { get; set; }
        PropertyValue<double>? MinimumHeightRequest { get; set; }
        PropertyValue<double>? MaximumWidthRequest { get; set; }
        PropertyValue<double>? MaximumHeightRequest { get; set; }
        PropertyValue<Microsoft.Maui.FlowDirection>? FlowDirection { get; set; }

        Action? ChildrenReorderedAction { get; set; }
        Action<object?, EventArgs>? ChildrenReorderedActionWithArgs { get; set; }
        Action? FocusedAction { get; set; }
        Action<object?, FocusEventArgs>? FocusedActionWithArgs { get; set; }
        Action? MeasureInvalidatedAction { get; set; }
        Action<object?, EventArgs>? MeasureInvalidatedActionWithArgs { get; set; }
        Action? SizeChangedAction { get; set; }
        Action<object?, EventArgs>? SizeChangedActionWithArgs { get; set; }
        Action? UnfocusedAction { get; set; }
        Action<object?, FocusEventArgs>? UnfocusedActionWithArgs { get; set; }

    }
    public abstract partial class VisualElement<T> : NavigableElement<T>, IVisualElement where T : Microsoft.Maui.Controls.VisualElement, new()
    {
        protected VisualElement()
        {

        }

        protected VisualElement(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Controls.Shadow>? IVisualElement.Shadow { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Style>? IVisualElement.Style { get; set; }
        PropertyValue<bool>? IVisualElement.InputTransparent { get; set; }
        PropertyValue<bool>? IVisualElement.IsEnabled { get; set; }
        PropertyValue<double>? IVisualElement.AnchorX { get; set; }
        PropertyValue<double>? IVisualElement.AnchorY { get; set; }
        PropertyValue<double>? IVisualElement.TranslationX { get; set; }
        PropertyValue<double>? IVisualElement.TranslationY { get; set; }
        PropertyValue<double>? IVisualElement.Rotation { get; set; }
        PropertyValue<double>? IVisualElement.RotationX { get; set; }
        PropertyValue<double>? IVisualElement.RotationY { get; set; }
        PropertyValue<double>? IVisualElement.Scale { get; set; }
        PropertyValue<double>? IVisualElement.ScaleX { get; set; }
        PropertyValue<double>? IVisualElement.ScaleY { get; set; }
        PropertyValue<Microsoft.Maui.Controls.IVisual>? IVisualElement.Visual { get; set; }
        PropertyValue<bool>? IVisualElement.IsVisible { get; set; }
        PropertyValue<double>? IVisualElement.Opacity { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? IVisualElement.BackgroundColor { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? IVisualElement.Background { get; set; }
        PropertyValue<double>? IVisualElement.WidthRequest { get; set; }
        PropertyValue<double>? IVisualElement.HeightRequest { get; set; }
        PropertyValue<double>? IVisualElement.MinimumWidthRequest { get; set; }
        PropertyValue<double>? IVisualElement.MinimumHeightRequest { get; set; }
        PropertyValue<double>? IVisualElement.MaximumWidthRequest { get; set; }
        PropertyValue<double>? IVisualElement.MaximumHeightRequest { get; set; }
        PropertyValue<Microsoft.Maui.FlowDirection>? IVisualElement.FlowDirection { get; set; }

        Action? IVisualElement.ChildrenReorderedAction { get; set; }
        Action<object?, EventArgs>? IVisualElement.ChildrenReorderedActionWithArgs { get; set; }
        Action? IVisualElement.FocusedAction { get; set; }
        Action<object?, FocusEventArgs>? IVisualElement.FocusedActionWithArgs { get; set; }
        Action? IVisualElement.MeasureInvalidatedAction { get; set; }
        Action<object?, EventArgs>? IVisualElement.MeasureInvalidatedActionWithArgs { get; set; }
        Action? IVisualElement.SizeChangedAction { get; set; }
        Action<object?, EventArgs>? IVisualElement.SizeChangedActionWithArgs { get; set; }
        Action? IVisualElement.UnfocusedAction { get; set; }
        Action<object?, FocusEventArgs>? IVisualElement.UnfocusedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIVisualElement = (IVisualElement)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.ShadowProperty, thisAsIVisualElement.Shadow);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.StyleProperty, thisAsIVisualElement.Style);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.InputTransparentProperty, thisAsIVisualElement.InputTransparent);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.IsEnabledProperty, thisAsIVisualElement.IsEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.AnchorXProperty, thisAsIVisualElement.AnchorX);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.AnchorYProperty, thisAsIVisualElement.AnchorY);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.TranslationXProperty, thisAsIVisualElement.TranslationX);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.TranslationYProperty, thisAsIVisualElement.TranslationY);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.RotationProperty, thisAsIVisualElement.Rotation);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.RotationXProperty, thisAsIVisualElement.RotationX);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.RotationYProperty, thisAsIVisualElement.RotationY);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.ScaleProperty, thisAsIVisualElement.Scale);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.ScaleXProperty, thisAsIVisualElement.ScaleX);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.ScaleYProperty, thisAsIVisualElement.ScaleY);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.VisualProperty, thisAsIVisualElement.Visual);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, thisAsIVisualElement.IsVisible);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.OpacityProperty, thisAsIVisualElement.Opacity);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.BackgroundColorProperty, thisAsIVisualElement.BackgroundColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.BackgroundProperty, thisAsIVisualElement.Background);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.WidthRequestProperty, thisAsIVisualElement.WidthRequest);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.HeightRequestProperty, thisAsIVisualElement.HeightRequest);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.MinimumWidthRequestProperty, thisAsIVisualElement.MinimumWidthRequest);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.MinimumHeightRequestProperty, thisAsIVisualElement.MinimumHeightRequest);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.MaximumWidthRequestProperty, thisAsIVisualElement.MaximumWidthRequest);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.MaximumHeightRequestProperty, thisAsIVisualElement.MaximumHeightRequest);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.FlowDirectionProperty, thisAsIVisualElement.FlowDirection);


            base.OnUpdate();

            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIVisualElement = (IVisualElement)this;

            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.RotationProperty, thisAsIVisualElement.Rotation);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.RotationXProperty, thisAsIVisualElement.RotationX);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.RotationYProperty, thisAsIVisualElement.RotationY);

            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIVisualElement = (IVisualElement)this;
            if (thisAsIVisualElement.ChildrenReorderedAction != null || thisAsIVisualElement.ChildrenReorderedActionWithArgs != null)
            {
                NativeControl.ChildrenReordered += NativeControl_ChildrenReordered;
            }
            if (thisAsIVisualElement.FocusedAction != null || thisAsIVisualElement.FocusedActionWithArgs != null)
            {
                NativeControl.Focused += NativeControl_Focused;
            }
            if (thisAsIVisualElement.MeasureInvalidatedAction != null || thisAsIVisualElement.MeasureInvalidatedActionWithArgs != null)
            {
                NativeControl.MeasureInvalidated += NativeControl_MeasureInvalidated;
            }
            if (thisAsIVisualElement.SizeChangedAction != null || thisAsIVisualElement.SizeChangedActionWithArgs != null)
            {
                NativeControl.SizeChanged += NativeControl_SizeChanged;
            }
            if (thisAsIVisualElement.UnfocusedAction != null || thisAsIVisualElement.UnfocusedActionWithArgs != null)
            {
                NativeControl.Unfocused += NativeControl_Unfocused;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_ChildrenReordered(object? sender, EventArgs e)
        {
            var thisAsIVisualElement = (IVisualElement)this;
            thisAsIVisualElement.ChildrenReorderedAction?.Invoke();
            thisAsIVisualElement.ChildrenReorderedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_Focused(object? sender, FocusEventArgs e)
        {
            var thisAsIVisualElement = (IVisualElement)this;
            thisAsIVisualElement.FocusedAction?.Invoke();
            thisAsIVisualElement.FocusedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_MeasureInvalidated(object? sender, EventArgs e)
        {
            var thisAsIVisualElement = (IVisualElement)this;
            thisAsIVisualElement.MeasureInvalidatedAction?.Invoke();
            thisAsIVisualElement.MeasureInvalidatedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_SizeChanged(object? sender, EventArgs e)
        {
            var thisAsIVisualElement = (IVisualElement)this;
            thisAsIVisualElement.SizeChangedAction?.Invoke();
            thisAsIVisualElement.SizeChangedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_Unfocused(object? sender, FocusEventArgs e)
        {
            var thisAsIVisualElement = (IVisualElement)this;
            thisAsIVisualElement.UnfocusedAction?.Invoke();
            thisAsIVisualElement.UnfocusedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.ChildrenReordered -= NativeControl_ChildrenReordered;
                NativeControl.Focused -= NativeControl_Focused;
                NativeControl.MeasureInvalidated -= NativeControl_MeasureInvalidated;
                NativeControl.SizeChanged -= NativeControl_SizeChanged;
                NativeControl.Unfocused -= NativeControl_Unfocused;
            }

            base.OnDetachNativeEvents();
        }

    }


    public static partial class VisualElementExtensions
    {
        public static T Shadow<T>(this T visualElement, Microsoft.Maui.Controls.Shadow shadow) where T : IVisualElement
        {
            visualElement.Shadow = new PropertyValue<Microsoft.Maui.Controls.Shadow>(shadow);
            return visualElement;
        }

        public static T Shadow<T>(this T visualElement, Func<Microsoft.Maui.Controls.Shadow> shadowFunc) where T : IVisualElement
        {
            visualElement.Shadow = new PropertyValue<Microsoft.Maui.Controls.Shadow>(shadowFunc);
            return visualElement;
        }



        public static T Style<T>(this T visualElement, Microsoft.Maui.Controls.Style style) where T : IVisualElement
        {
            visualElement.Style = new PropertyValue<Microsoft.Maui.Controls.Style>(style);
            return visualElement;
        }

        public static T Style<T>(this T visualElement, Func<Microsoft.Maui.Controls.Style> styleFunc) where T : IVisualElement
        {
            visualElement.Style = new PropertyValue<Microsoft.Maui.Controls.Style>(styleFunc);
            return visualElement;
        }



        public static T InputTransparent<T>(this T visualElement, bool inputTransparent) where T : IVisualElement
        {
            visualElement.InputTransparent = new PropertyValue<bool>(inputTransparent);
            return visualElement;
        }

        public static T InputTransparent<T>(this T visualElement, Func<bool> inputTransparentFunc) where T : IVisualElement
        {
            visualElement.InputTransparent = new PropertyValue<bool>(inputTransparentFunc);
            return visualElement;
        }



        public static T IsEnabled<T>(this T visualElement, bool isEnabled) where T : IVisualElement
        {
            visualElement.IsEnabled = new PropertyValue<bool>(isEnabled);
            return visualElement;
        }

        public static T IsEnabled<T>(this T visualElement, Func<bool> isEnabledFunc) where T : IVisualElement
        {
            visualElement.IsEnabled = new PropertyValue<bool>(isEnabledFunc);
            return visualElement;
        }



        public static T AnchorX<T>(this T visualElement, double anchorX, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.AnchorX = new PropertyValue<double>(anchorX);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.AnchorXProperty, customAnimation ?? new RxDoubleAnimation(anchorX), v => visualElement.AnchorX = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T AnchorX<T>(this T visualElement, Func<double> anchorXFunc) where T : IVisualElement
        {
            visualElement.AnchorX = new PropertyValue<double>(anchorXFunc);
            return visualElement;
        }



        public static T AnchorY<T>(this T visualElement, double anchorY, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.AnchorY = new PropertyValue<double>(anchorY);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.AnchorYProperty, customAnimation ?? new RxDoubleAnimation(anchorY), v => visualElement.AnchorY = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T AnchorY<T>(this T visualElement, Func<double> anchorYFunc) where T : IVisualElement
        {
            visualElement.AnchorY = new PropertyValue<double>(anchorYFunc);
            return visualElement;
        }



        public static T TranslationX<T>(this T visualElement, double translationX, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.TranslationX = new PropertyValue<double>(translationX);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.TranslationXProperty, customAnimation ?? new RxDoubleAnimation(translationX), v => visualElement.TranslationX = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T TranslationX<T>(this T visualElement, Func<double> translationXFunc) where T : IVisualElement
        {
            visualElement.TranslationX = new PropertyValue<double>(translationXFunc);
            return visualElement;
        }



        public static T TranslationY<T>(this T visualElement, double translationY, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.TranslationY = new PropertyValue<double>(translationY);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.TranslationYProperty, customAnimation ?? new RxDoubleAnimation(translationY), v => visualElement.TranslationY = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T TranslationY<T>(this T visualElement, Func<double> translationYFunc) where T : IVisualElement
        {
            visualElement.TranslationY = new PropertyValue<double>(translationYFunc);
            return visualElement;
        }



        public static T Rotation<T>(this T visualElement, double rotation, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.Rotation = new PropertyValue<double>(rotation);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.RotationProperty, customAnimation ?? new RxDoubleAnimation(rotation), v => visualElement.Rotation = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T Rotation<T>(this T visualElement, Func<double> rotationFunc) where T : IVisualElement
        {
            visualElement.Rotation = new PropertyValue<double>(rotationFunc);
            return visualElement;
        }



        public static T RotationX<T>(this T visualElement, double rotationX, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.RotationX = new PropertyValue<double>(rotationX);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.RotationXProperty, customAnimation ?? new RxDoubleAnimation(rotationX), v => visualElement.RotationX = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T RotationX<T>(this T visualElement, Func<double> rotationXFunc) where T : IVisualElement
        {
            visualElement.RotationX = new PropertyValue<double>(rotationXFunc);
            return visualElement;
        }



        public static T RotationY<T>(this T visualElement, double rotationY, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.RotationY = new PropertyValue<double>(rotationY);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.RotationYProperty, customAnimation ?? new RxDoubleAnimation(rotationY), v => visualElement.RotationY = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T RotationY<T>(this T visualElement, Func<double> rotationYFunc) where T : IVisualElement
        {
            visualElement.RotationY = new PropertyValue<double>(rotationYFunc);
            return visualElement;
        }



        public static T Scale<T>(this T visualElement, double scale, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.Scale = new PropertyValue<double>(scale);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.ScaleProperty, customAnimation ?? new RxDoubleAnimation(scale), v => visualElement.Scale = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T Scale<T>(this T visualElement, Func<double> scaleFunc) where T : IVisualElement
        {
            visualElement.Scale = new PropertyValue<double>(scaleFunc);
            return visualElement;
        }



        public static T ScaleX<T>(this T visualElement, double scaleX, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.ScaleX = new PropertyValue<double>(scaleX);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.ScaleXProperty, customAnimation ?? new RxDoubleAnimation(scaleX), v => visualElement.ScaleX = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T ScaleX<T>(this T visualElement, Func<double> scaleXFunc) where T : IVisualElement
        {
            visualElement.ScaleX = new PropertyValue<double>(scaleXFunc);
            return visualElement;
        }



        public static T ScaleY<T>(this T visualElement, double scaleY, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.ScaleY = new PropertyValue<double>(scaleY);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.ScaleYProperty, customAnimation ?? new RxDoubleAnimation(scaleY), v => visualElement.ScaleY = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T ScaleY<T>(this T visualElement, Func<double> scaleYFunc) where T : IVisualElement
        {
            visualElement.ScaleY = new PropertyValue<double>(scaleYFunc);
            return visualElement;
        }



        public static T Visual<T>(this T visualElement, Microsoft.Maui.Controls.IVisual visual) where T : IVisualElement
        {
            visualElement.Visual = new PropertyValue<Microsoft.Maui.Controls.IVisual>(visual);
            return visualElement;
        }

        public static T Visual<T>(this T visualElement, Func<Microsoft.Maui.Controls.IVisual> visualFunc) where T : IVisualElement
        {
            visualElement.Visual = new PropertyValue<Microsoft.Maui.Controls.IVisual>(visualFunc);
            return visualElement;
        }



        public static T IsVisible<T>(this T visualElement, bool isVisible) where T : IVisualElement
        {
            visualElement.IsVisible = new PropertyValue<bool>(isVisible);
            return visualElement;
        }

        public static T IsVisible<T>(this T visualElement, Func<bool> isVisibleFunc) where T : IVisualElement
        {
            visualElement.IsVisible = new PropertyValue<bool>(isVisibleFunc);
            return visualElement;
        }



        public static T Opacity<T>(this T visualElement, double opacity, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.Opacity = new PropertyValue<double>(opacity);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.OpacityProperty, customAnimation ?? new RxDoubleAnimation(opacity), v => visualElement.Opacity = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T Opacity<T>(this T visualElement, Func<double> opacityFunc) where T : IVisualElement
        {
            visualElement.Opacity = new PropertyValue<double>(opacityFunc);
            return visualElement;
        }



        public static T BackgroundColor<T>(this T visualElement, Microsoft.Maui.Graphics.Color backgroundColor) where T : IVisualElement
        {
            visualElement.BackgroundColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(backgroundColor);
            return visualElement;
        }

        public static T BackgroundColor<T>(this T visualElement, Func<Microsoft.Maui.Graphics.Color> backgroundColorFunc) where T : IVisualElement
        {
            visualElement.BackgroundColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(backgroundColorFunc);
            return visualElement;
        }



        public static T Background<T>(this T visualElement, Microsoft.Maui.Controls.Brush background) where T : IVisualElement
        {
            visualElement.Background = new PropertyValue<Microsoft.Maui.Controls.Brush>(background);
            return visualElement;
        }

        public static T Background<T>(this T visualElement, Func<Microsoft.Maui.Controls.Brush> backgroundFunc) where T : IVisualElement
        {
            visualElement.Background = new PropertyValue<Microsoft.Maui.Controls.Brush>(backgroundFunc);
            return visualElement;
        }



        public static T WidthRequest<T>(this T visualElement, double widthRequest, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.WidthRequest = new PropertyValue<double>(widthRequest);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.WidthRequestProperty, customAnimation ?? new RxDoubleAnimation(widthRequest), v => visualElement.WidthRequest = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T WidthRequest<T>(this T visualElement, Func<double> widthRequestFunc) where T : IVisualElement
        {
            visualElement.WidthRequest = new PropertyValue<double>(widthRequestFunc);
            return visualElement;
        }



        public static T HeightRequest<T>(this T visualElement, double heightRequest, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.HeightRequest = new PropertyValue<double>(heightRequest);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.HeightRequestProperty, customAnimation ?? new RxDoubleAnimation(heightRequest), v => visualElement.HeightRequest = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T HeightRequest<T>(this T visualElement, Func<double> heightRequestFunc) where T : IVisualElement
        {
            visualElement.HeightRequest = new PropertyValue<double>(heightRequestFunc);
            return visualElement;
        }



        public static T MinimumWidthRequest<T>(this T visualElement, double minimumWidthRequest, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.MinimumWidthRequest = new PropertyValue<double>(minimumWidthRequest);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.MinimumWidthRequestProperty, customAnimation ?? new RxDoubleAnimation(minimumWidthRequest), v => visualElement.MinimumWidthRequest = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T MinimumWidthRequest<T>(this T visualElement, Func<double> minimumWidthRequestFunc) where T : IVisualElement
        {
            visualElement.MinimumWidthRequest = new PropertyValue<double>(minimumWidthRequestFunc);
            return visualElement;
        }



        public static T MinimumHeightRequest<T>(this T visualElement, double minimumHeightRequest, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.MinimumHeightRequest = new PropertyValue<double>(minimumHeightRequest);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.MinimumHeightRequestProperty, customAnimation ?? new RxDoubleAnimation(minimumHeightRequest), v => visualElement.MinimumHeightRequest = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T MinimumHeightRequest<T>(this T visualElement, Func<double> minimumHeightRequestFunc) where T : IVisualElement
        {
            visualElement.MinimumHeightRequest = new PropertyValue<double>(minimumHeightRequestFunc);
            return visualElement;
        }



        public static T MaximumWidthRequest<T>(this T visualElement, double maximumWidthRequest, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.MaximumWidthRequest = new PropertyValue<double>(maximumWidthRequest);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.MaximumWidthRequestProperty, customAnimation ?? new RxDoubleAnimation(maximumWidthRequest), v => visualElement.MaximumWidthRequest = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T MaximumWidthRequest<T>(this T visualElement, Func<double> maximumWidthRequestFunc) where T : IVisualElement
        {
            visualElement.MaximumWidthRequest = new PropertyValue<double>(maximumWidthRequestFunc);
            return visualElement;
        }



        public static T MaximumHeightRequest<T>(this T visualElement, double maximumHeightRequest, RxDoubleAnimation? customAnimation = null) where T : IVisualElement
        {
            visualElement.MaximumHeightRequest = new PropertyValue<double>(maximumHeightRequest);
            visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.MaximumHeightRequestProperty, customAnimation ?? new RxDoubleAnimation(maximumHeightRequest), v => visualElement.MaximumHeightRequest = new PropertyValue<double>(v.CurrentValue()));
            return visualElement;
        }

        public static T MaximumHeightRequest<T>(this T visualElement, Func<double> maximumHeightRequestFunc) where T : IVisualElement
        {
            visualElement.MaximumHeightRequest = new PropertyValue<double>(maximumHeightRequestFunc);
            return visualElement;
        }



        public static T FlowDirection<T>(this T visualElement, Microsoft.Maui.FlowDirection flowDirection) where T : IVisualElement
        {
            visualElement.FlowDirection = new PropertyValue<Microsoft.Maui.FlowDirection>(flowDirection);
            return visualElement;
        }

        public static T FlowDirection<T>(this T visualElement, Func<Microsoft.Maui.FlowDirection> flowDirectionFunc) where T : IVisualElement
        {
            visualElement.FlowDirection = new PropertyValue<Microsoft.Maui.FlowDirection>(flowDirectionFunc);
            return visualElement;
        }




        public static T OnChildrenReordered<T>(this T visualElement, Action childrenReorderedAction) where T : IVisualElement
        {
            visualElement.ChildrenReorderedAction = childrenReorderedAction;
            return visualElement;
        }

        public static T OnChildrenReordered<T>(this T visualElement, Action<object?, EventArgs> childrenReorderedActionWithArgs) where T : IVisualElement
        {
            visualElement.ChildrenReorderedActionWithArgs = childrenReorderedActionWithArgs;
            return visualElement;
        }
        public static T OnFocused<T>(this T visualElement, Action focusedAction) where T : IVisualElement
        {
            visualElement.FocusedAction = focusedAction;
            return visualElement;
        }

        public static T OnFocused<T>(this T visualElement, Action<object?, FocusEventArgs> focusedActionWithArgs) where T : IVisualElement
        {
            visualElement.FocusedActionWithArgs = focusedActionWithArgs;
            return visualElement;
        }
        public static T OnMeasureInvalidated<T>(this T visualElement, Action measureInvalidatedAction) where T : IVisualElement
        {
            visualElement.MeasureInvalidatedAction = measureInvalidatedAction;
            return visualElement;
        }

        public static T OnMeasureInvalidated<T>(this T visualElement, Action<object?, EventArgs> measureInvalidatedActionWithArgs) where T : IVisualElement
        {
            visualElement.MeasureInvalidatedActionWithArgs = measureInvalidatedActionWithArgs;
            return visualElement;
        }
        public static T OnSizeChanged<T>(this T visualElement, Action sizeChangedAction) where T : IVisualElement
        {
            visualElement.SizeChangedAction = sizeChangedAction;
            return visualElement;
        }

        public static T OnSizeChanged<T>(this T visualElement, Action<object?, EventArgs> sizeChangedActionWithArgs) where T : IVisualElement
        {
            visualElement.SizeChangedActionWithArgs = sizeChangedActionWithArgs;
            return visualElement;
        }
        public static T OnUnfocused<T>(this T visualElement, Action unfocusedAction) where T : IVisualElement
        {
            visualElement.UnfocusedAction = unfocusedAction;
            return visualElement;
        }

        public static T OnUnfocused<T>(this T visualElement, Action<object?, FocusEventArgs> unfocusedActionWithArgs) where T : IVisualElement
        {
            visualElement.UnfocusedActionWithArgs = unfocusedActionWithArgs;
            return visualElement;
        }
    }
}
