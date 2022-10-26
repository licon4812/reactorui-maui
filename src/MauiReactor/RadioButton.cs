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
    public partial interface IRadioButton : ITemplatedView
    {
        PropertyValue<object>? Value { get; set; }

        PropertyValue<bool>? IsChecked { get; set; }

        PropertyValue<string>? GroupName { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? TextColor { get; set; }

        PropertyValue<double>? CharacterSpacing { get; set; }

        PropertyValue<Microsoft.Maui.TextTransform>? TextTransform { get; set; }

        PropertyValue<Microsoft.Maui.Controls.FontAttributes>? FontAttributes { get; set; }

        PropertyValue<string>? FontFamily { get; set; }

        PropertyValue<double>? FontSize { get; set; }

        PropertyValue<bool>? FontAutoScalingEnabled { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? BorderColor { get; set; }

        PropertyValue<int>? CornerRadius { get; set; }

        PropertyValue<double>? BorderWidth { get; set; }

        Action? CheckedChangedAction { get; set; }

        Action<object?, CheckedChangedEventArgs>? CheckedChangedActionWithArgs { get; set; }
    }

    public partial class RadioButton<T> : TemplatedView<T>, IRadioButton where T : Microsoft.Maui.Controls.RadioButton, new()
    {
        public RadioButton()
        {
        }

        public RadioButton(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<object>? IRadioButton.Value { get; set; }

        PropertyValue<bool>? IRadioButton.IsChecked { get; set; }

        PropertyValue<string>? IRadioButton.GroupName { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? IRadioButton.TextColor { get; set; }

        PropertyValue<double>? IRadioButton.CharacterSpacing { get; set; }

        PropertyValue<Microsoft.Maui.TextTransform>? IRadioButton.TextTransform { get; set; }

        PropertyValue<Microsoft.Maui.Controls.FontAttributes>? IRadioButton.FontAttributes { get; set; }

        PropertyValue<string>? IRadioButton.FontFamily { get; set; }

        PropertyValue<double>? IRadioButton.FontSize { get; set; }

        PropertyValue<bool>? IRadioButton.FontAutoScalingEnabled { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? IRadioButton.BorderColor { get; set; }

        PropertyValue<int>? IRadioButton.CornerRadius { get; set; }

        PropertyValue<double>? IRadioButton.BorderWidth { get; set; }

        Action? IRadioButton.CheckedChangedAction { get; set; }

        Action<object?, CheckedChangedEventArgs>? IRadioButton.CheckedChangedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIRadioButton = (IRadioButton)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.ValueProperty, thisAsIRadioButton.Value);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.IsCheckedProperty, thisAsIRadioButton.IsChecked);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.GroupNameProperty, thisAsIRadioButton.GroupName);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.TextColorProperty, thisAsIRadioButton.TextColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty, thisAsIRadioButton.CharacterSpacing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.TextTransformProperty, thisAsIRadioButton.TextTransform);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.FontAttributesProperty, thisAsIRadioButton.FontAttributes);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.FontFamilyProperty, thisAsIRadioButton.FontFamily);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.FontSizeProperty, thisAsIRadioButton.FontSize);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty, thisAsIRadioButton.FontAutoScalingEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.BorderColorProperty, thisAsIRadioButton.BorderColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty, thisAsIRadioButton.CornerRadius);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.BorderWidthProperty, thisAsIRadioButton.BorderWidth);
            base.OnUpdate();
            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIRadioButton = (IRadioButton)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty, thisAsIRadioButton.CharacterSpacing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.FontSizeProperty, thisAsIRadioButton.FontSize);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.RadioButton.BorderWidthProperty, thisAsIRadioButton.BorderWidth);
            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
        partial void OnAttachingNativeEvents();
        partial void OnDetachingNativeEvents();
        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIRadioButton = (IRadioButton)this;
            if (thisAsIRadioButton.CheckedChangedAction != null || thisAsIRadioButton.CheckedChangedActionWithArgs != null)
            {
                NativeControl.CheckedChanged += NativeControl_CheckedChanged;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_CheckedChanged(object? sender, CheckedChangedEventArgs e)
        {
            var thisAsIRadioButton = (IRadioButton)this;
            thisAsIRadioButton.CheckedChangedAction?.Invoke();
            thisAsIRadioButton.CheckedChangedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.CheckedChanged -= NativeControl_CheckedChanged;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class RadioButton : RadioButton<Microsoft.Maui.Controls.RadioButton>
    {
        public RadioButton()
        {
        }

        public RadioButton(Action<Microsoft.Maui.Controls.RadioButton?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class RadioButtonExtensions
    {
        public static T Value<T>(this T radioButton, object value)
            where T : IRadioButton
        {
            radioButton.Value = new PropertyValue<object>(value);
            return radioButton;
        }

        public static T Value<T>(this T radioButton, Func<object> valueFunc)
            where T : IRadioButton
        {
            radioButton.Value = new PropertyValue<object>(valueFunc);
            return radioButton;
        }

        public static T IsChecked<T>(this T radioButton, bool isChecked)
            where T : IRadioButton
        {
            radioButton.IsChecked = new PropertyValue<bool>(isChecked);
            return radioButton;
        }

        public static T IsChecked<T>(this T radioButton, Func<bool> isCheckedFunc)
            where T : IRadioButton
        {
            radioButton.IsChecked = new PropertyValue<bool>(isCheckedFunc);
            return radioButton;
        }

        public static T GroupName<T>(this T radioButton, string groupName)
            where T : IRadioButton
        {
            radioButton.GroupName = new PropertyValue<string>(groupName);
            return radioButton;
        }

        public static T GroupName<T>(this T radioButton, Func<string> groupNameFunc)
            where T : IRadioButton
        {
            radioButton.GroupName = new PropertyValue<string>(groupNameFunc);
            return radioButton;
        }

        public static T TextColor<T>(this T radioButton, Microsoft.Maui.Graphics.Color textColor)
            where T : IRadioButton
        {
            radioButton.TextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(textColor);
            return radioButton;
        }

        public static T TextColor<T>(this T radioButton, Func<Microsoft.Maui.Graphics.Color> textColorFunc)
            where T : IRadioButton
        {
            radioButton.TextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(textColorFunc);
            return radioButton;
        }

        public static T CharacterSpacing<T>(this T radioButton, double characterSpacing, RxDoubleAnimation? customAnimation = null)
            where T : IRadioButton
        {
            radioButton.CharacterSpacing = new PropertyValue<double>(characterSpacing);
            radioButton.AppendAnimatable(Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty, customAnimation ?? new RxDoubleAnimation(characterSpacing), v => radioButton.CharacterSpacing = new PropertyValue<double>(v.CurrentValue()));
            return radioButton;
        }

        public static T CharacterSpacing<T>(this T radioButton, Func<double> characterSpacingFunc)
            where T : IRadioButton
        {
            radioButton.CharacterSpacing = new PropertyValue<double>(characterSpacingFunc);
            return radioButton;
        }

        public static T TextTransform<T>(this T radioButton, Microsoft.Maui.TextTransform textTransform)
            where T : IRadioButton
        {
            radioButton.TextTransform = new PropertyValue<Microsoft.Maui.TextTransform>(textTransform);
            return radioButton;
        }

        public static T TextTransform<T>(this T radioButton, Func<Microsoft.Maui.TextTransform> textTransformFunc)
            where T : IRadioButton
        {
            radioButton.TextTransform = new PropertyValue<Microsoft.Maui.TextTransform>(textTransformFunc);
            return radioButton;
        }

        public static T FontAttributes<T>(this T radioButton, Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : IRadioButton
        {
            radioButton.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributes);
            return radioButton;
        }

        public static T FontAttributes<T>(this T radioButton, Func<Microsoft.Maui.Controls.FontAttributes> fontAttributesFunc)
            where T : IRadioButton
        {
            radioButton.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributesFunc);
            return radioButton;
        }

        public static T FontFamily<T>(this T radioButton, string fontFamily)
            where T : IRadioButton
        {
            radioButton.FontFamily = new PropertyValue<string>(fontFamily);
            return radioButton;
        }

        public static T FontFamily<T>(this T radioButton, Func<string> fontFamilyFunc)
            where T : IRadioButton
        {
            radioButton.FontFamily = new PropertyValue<string>(fontFamilyFunc);
            return radioButton;
        }

        public static T FontSize<T>(this T radioButton, double fontSize, RxDoubleAnimation? customAnimation = null)
            where T : IRadioButton
        {
            radioButton.FontSize = new PropertyValue<double>(fontSize);
            radioButton.AppendAnimatable(Microsoft.Maui.Controls.RadioButton.FontSizeProperty, customAnimation ?? new RxDoubleAnimation(fontSize), v => radioButton.FontSize = new PropertyValue<double>(v.CurrentValue()));
            return radioButton;
        }

        public static T FontSize<T>(this T radioButton, Func<double> fontSizeFunc)
            where T : IRadioButton
        {
            radioButton.FontSize = new PropertyValue<double>(fontSizeFunc);
            return radioButton;
        }

        public static T FontAutoScalingEnabled<T>(this T radioButton, bool fontAutoScalingEnabled)
            where T : IRadioButton
        {
            radioButton.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabled);
            return radioButton;
        }

        public static T FontAutoScalingEnabled<T>(this T radioButton, Func<bool> fontAutoScalingEnabledFunc)
            where T : IRadioButton
        {
            radioButton.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabledFunc);
            return radioButton;
        }

        public static T BorderColor<T>(this T radioButton, Microsoft.Maui.Graphics.Color borderColor)
            where T : IRadioButton
        {
            radioButton.BorderColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(borderColor);
            return radioButton;
        }

        public static T BorderColor<T>(this T radioButton, Func<Microsoft.Maui.Graphics.Color> borderColorFunc)
            where T : IRadioButton
        {
            radioButton.BorderColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(borderColorFunc);
            return radioButton;
        }

        public static T CornerRadius<T>(this T radioButton, int cornerRadius)
            where T : IRadioButton
        {
            radioButton.CornerRadius = new PropertyValue<int>(cornerRadius);
            return radioButton;
        }

        public static T CornerRadius<T>(this T radioButton, Func<int> cornerRadiusFunc)
            where T : IRadioButton
        {
            radioButton.CornerRadius = new PropertyValue<int>(cornerRadiusFunc);
            return radioButton;
        }

        public static T BorderWidth<T>(this T radioButton, double borderWidth, RxDoubleAnimation? customAnimation = null)
            where T : IRadioButton
        {
            radioButton.BorderWidth = new PropertyValue<double>(borderWidth);
            radioButton.AppendAnimatable(Microsoft.Maui.Controls.RadioButton.BorderWidthProperty, customAnimation ?? new RxDoubleAnimation(borderWidth), v => radioButton.BorderWidth = new PropertyValue<double>(v.CurrentValue()));
            return radioButton;
        }

        public static T BorderWidth<T>(this T radioButton, Func<double> borderWidthFunc)
            where T : IRadioButton
        {
            radioButton.BorderWidth = new PropertyValue<double>(borderWidthFunc);
            return radioButton;
        }

        public static T OnCheckedChanged<T>(this T radioButton, Action? checkedChangedAction)
            where T : IRadioButton
        {
            radioButton.CheckedChangedAction = checkedChangedAction;
            return radioButton;
        }

        public static T OnCheckedChanged<T>(this T radioButton, Action<object?, CheckedChangedEventArgs>? checkedChangedActionWithArgs)
            where T : IRadioButton
        {
            radioButton.CheckedChangedActionWithArgs = checkedChangedActionWithArgs;
            return radioButton;
        }
    }
}