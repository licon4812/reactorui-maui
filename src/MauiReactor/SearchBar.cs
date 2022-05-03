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
    public partial interface ISearchBar : IInputView
    {
        PropertyValue<Microsoft.Maui.Graphics.Color>? CancelButtonColor { get; set; }
        PropertyValue<string>? FontFamily { get; set; }
        PropertyValue<double>? FontSize { get; set; }
        PropertyValue<Microsoft.Maui.Controls.FontAttributes>? FontAttributes { get; set; }
        PropertyValue<bool>? IsTextPredictionEnabled { get; set; }
        PropertyValue<int>? CursorPosition { get; set; }
        PropertyValue<int>? SelectionLength { get; set; }
        PropertyValue<bool>? FontAutoScalingEnabled { get; set; }
        PropertyValue<Microsoft.Maui.TextAlignment>? HorizontalTextAlignment { get; set; }
        PropertyValue<Microsoft.Maui.TextAlignment>? VerticalTextAlignment { get; set; }

        Action? SearchButtonPressedAction { get; set; }
        Action<object?, EventArgs>? SearchButtonPressedActionWithArgs { get; set; }

    }

    public partial class SearchBar<T> : InputView<T>, ISearchBar where T : Microsoft.Maui.Controls.SearchBar, new()
    {
        public SearchBar()
        {

        }

        public SearchBar(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Graphics.Color>? ISearchBar.CancelButtonColor { get; set; }
        PropertyValue<string>? ISearchBar.FontFamily { get; set; }
        PropertyValue<double>? ISearchBar.FontSize { get; set; }
        PropertyValue<Microsoft.Maui.Controls.FontAttributes>? ISearchBar.FontAttributes { get; set; }
        PropertyValue<bool>? ISearchBar.IsTextPredictionEnabled { get; set; }
        PropertyValue<int>? ISearchBar.CursorPosition { get; set; }
        PropertyValue<int>? ISearchBar.SelectionLength { get; set; }
        PropertyValue<bool>? ISearchBar.FontAutoScalingEnabled { get; set; }
        PropertyValue<Microsoft.Maui.TextAlignment>? ISearchBar.HorizontalTextAlignment { get; set; }
        PropertyValue<Microsoft.Maui.TextAlignment>? ISearchBar.VerticalTextAlignment { get; set; }

        Action? ISearchBar.SearchButtonPressedAction { get; set; }
        Action<object?, EventArgs>? ISearchBar.SearchButtonPressedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsISearchBar = (ISearchBar)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.CancelButtonColorProperty, thisAsISearchBar.CancelButtonColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.FontFamilyProperty, thisAsISearchBar.FontFamily);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.FontSizeProperty, thisAsISearchBar.FontSize);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.FontAttributesProperty, thisAsISearchBar.FontAttributes);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.IsTextPredictionEnabledProperty, thisAsISearchBar.IsTextPredictionEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.CursorPositionProperty, thisAsISearchBar.CursorPosition);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.SelectionLengthProperty, thisAsISearchBar.SelectionLength);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.FontAutoScalingEnabledProperty, thisAsISearchBar.FontAutoScalingEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty, thisAsISearchBar.HorizontalTextAlignment);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty, thisAsISearchBar.VerticalTextAlignment);


            base.OnUpdate();

            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsISearchBar = (ISearchBar)this;

            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SearchBar.FontSizeProperty, thisAsISearchBar.FontSize);

            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsISearchBar = (ISearchBar)this;
            if (thisAsISearchBar.SearchButtonPressedAction != null || thisAsISearchBar.SearchButtonPressedActionWithArgs != null)
            {
                NativeControl.SearchButtonPressed += NativeControl_SearchButtonPressed;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_SearchButtonPressed(object? sender, EventArgs e)
        {
            var thisAsISearchBar = (ISearchBar)this;
            thisAsISearchBar.SearchButtonPressedAction?.Invoke();
            thisAsISearchBar.SearchButtonPressedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.SearchButtonPressed -= NativeControl_SearchButtonPressed;
            }

            base.OnDetachNativeEvents();
        }

    }

    public partial class SearchBar : SearchBar<Microsoft.Maui.Controls.SearchBar>
    {
        public SearchBar()
        {

        }

        public SearchBar(Action<Microsoft.Maui.Controls.SearchBar?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class SearchBarExtensions
    {
        public static T CancelButtonColor<T>(this T searchBar, Microsoft.Maui.Graphics.Color cancelButtonColor) where T : ISearchBar
        {
            searchBar.CancelButtonColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(cancelButtonColor);
            return searchBar;
        }

        public static T CancelButtonColor<T>(this T searchBar, Func<Microsoft.Maui.Graphics.Color> cancelButtonColorFunc) where T : ISearchBar
        {
            searchBar.CancelButtonColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(cancelButtonColorFunc);
            return searchBar;
        }



        public static T FontFamily<T>(this T searchBar, string fontFamily) where T : ISearchBar
        {
            searchBar.FontFamily = new PropertyValue<string>(fontFamily);
            return searchBar;
        }

        public static T FontFamily<T>(this T searchBar, Func<string> fontFamilyFunc) where T : ISearchBar
        {
            searchBar.FontFamily = new PropertyValue<string>(fontFamilyFunc);
            return searchBar;
        }



        public static T FontSize<T>(this T searchBar, double fontSize, RxDoubleAnimation? customAnimation = null) where T : ISearchBar
        {
            searchBar.FontSize = new PropertyValue<double>(fontSize);
            searchBar.AppendAnimatable(Microsoft.Maui.Controls.SearchBar.FontSizeProperty, customAnimation ?? new RxDoubleAnimation(fontSize), v => searchBar.FontSize = new PropertyValue<double>(v.CurrentValue()));
            return searchBar;
        }

        public static T FontSize<T>(this T searchBar, Func<double> fontSizeFunc) where T : ISearchBar
        {
            searchBar.FontSize = new PropertyValue<double>(fontSizeFunc);
            return searchBar;
        }



        public static T FontAttributes<T>(this T searchBar, Microsoft.Maui.Controls.FontAttributes fontAttributes) where T : ISearchBar
        {
            searchBar.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributes);
            return searchBar;
        }

        public static T FontAttributes<T>(this T searchBar, Func<Microsoft.Maui.Controls.FontAttributes> fontAttributesFunc) where T : ISearchBar
        {
            searchBar.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributesFunc);
            return searchBar;
        }



        public static T IsTextPredictionEnabled<T>(this T searchBar, bool isTextPredictionEnabled) where T : ISearchBar
        {
            searchBar.IsTextPredictionEnabled = new PropertyValue<bool>(isTextPredictionEnabled);
            return searchBar;
        }

        public static T IsTextPredictionEnabled<T>(this T searchBar, Func<bool> isTextPredictionEnabledFunc) where T : ISearchBar
        {
            searchBar.IsTextPredictionEnabled = new PropertyValue<bool>(isTextPredictionEnabledFunc);
            return searchBar;
        }



        public static T CursorPosition<T>(this T searchBar, int cursorPosition) where T : ISearchBar
        {
            searchBar.CursorPosition = new PropertyValue<int>(cursorPosition);
            return searchBar;
        }

        public static T CursorPosition<T>(this T searchBar, Func<int> cursorPositionFunc) where T : ISearchBar
        {
            searchBar.CursorPosition = new PropertyValue<int>(cursorPositionFunc);
            return searchBar;
        }



        public static T SelectionLength<T>(this T searchBar, int selectionLength) where T : ISearchBar
        {
            searchBar.SelectionLength = new PropertyValue<int>(selectionLength);
            return searchBar;
        }

        public static T SelectionLength<T>(this T searchBar, Func<int> selectionLengthFunc) where T : ISearchBar
        {
            searchBar.SelectionLength = new PropertyValue<int>(selectionLengthFunc);
            return searchBar;
        }



        public static T FontAutoScalingEnabled<T>(this T searchBar, bool fontAutoScalingEnabled) where T : ISearchBar
        {
            searchBar.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabled);
            return searchBar;
        }

        public static T FontAutoScalingEnabled<T>(this T searchBar, Func<bool> fontAutoScalingEnabledFunc) where T : ISearchBar
        {
            searchBar.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabledFunc);
            return searchBar;
        }



        public static T HorizontalTextAlignment<T>(this T searchBar, Microsoft.Maui.TextAlignment horizontalTextAlignment) where T : ISearchBar
        {
            searchBar.HorizontalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(horizontalTextAlignment);
            return searchBar;
        }

        public static T HorizontalTextAlignment<T>(this T searchBar, Func<Microsoft.Maui.TextAlignment> horizontalTextAlignmentFunc) where T : ISearchBar
        {
            searchBar.HorizontalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(horizontalTextAlignmentFunc);
            return searchBar;
        }



        public static T VerticalTextAlignment<T>(this T searchBar, Microsoft.Maui.TextAlignment verticalTextAlignment) where T : ISearchBar
        {
            searchBar.VerticalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(verticalTextAlignment);
            return searchBar;
        }

        public static T VerticalTextAlignment<T>(this T searchBar, Func<Microsoft.Maui.TextAlignment> verticalTextAlignmentFunc) where T : ISearchBar
        {
            searchBar.VerticalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(verticalTextAlignmentFunc);
            return searchBar;
        }




        public static T OnSearchButtonPressed<T>(this T searchBar, Action searchButtonPressedAction) where T : ISearchBar
        {
            searchBar.SearchButtonPressedAction = searchButtonPressedAction;
            return searchBar;
        }

        public static T OnSearchButtonPressed<T>(this T searchBar, Action<object?, EventArgs> searchButtonPressedActionWithArgs) where T : ISearchBar
        {
            searchBar.SearchButtonPressedActionWithArgs = searchButtonPressedActionWithArgs;
            return searchBar;
        }
    }
}
