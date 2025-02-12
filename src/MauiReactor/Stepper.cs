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
    public partial interface IStepper : IView
    {
        PropertyValue<double>? Maximum { get; set; }

        PropertyValue<double>? Minimum { get; set; }

        PropertyValue<double>? Value { get; set; }

        PropertyValue<double>? Increment { get; set; }

        Action? ValueChangedAction { get; set; }

        Action<object?, ValueChangedEventArgs>? ValueChangedActionWithArgs { get; set; }
    }

    public partial class Stepper<T> : View<T>, IStepper where T : Microsoft.Maui.Controls.Stepper, new()
    {
        public Stepper()
        {
        }

        public Stepper(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<double>? IStepper.Maximum { get; set; }

        PropertyValue<double>? IStepper.Minimum { get; set; }

        PropertyValue<double>? IStepper.Value { get; set; }

        PropertyValue<double>? IStepper.Increment { get; set; }

        Action? IStepper.ValueChangedAction { get; set; }

        Action<object?, ValueChangedEventArgs>? IStepper.ValueChangedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIStepper = (IStepper)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Stepper.MaximumProperty, thisAsIStepper.Maximum);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Stepper.MinimumProperty, thisAsIStepper.Minimum);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Stepper.ValueProperty, thisAsIStepper.Value);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Stepper.IncrementProperty, thisAsIStepper.Increment);
            base.OnUpdate();
            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            OnBeginAnimate();
            var thisAsIStepper = (IStepper)this;
            AnimateProperty(Microsoft.Maui.Controls.Stepper.MaximumProperty, thisAsIStepper.Maximum);
            AnimateProperty(Microsoft.Maui.Controls.Stepper.MinimumProperty, thisAsIStepper.Minimum);
            AnimateProperty(Microsoft.Maui.Controls.Stepper.ValueProperty, thisAsIStepper.Value);
            AnimateProperty(Microsoft.Maui.Controls.Stepper.IncrementProperty, thisAsIStepper.Increment);
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
            var thisAsIStepper = (IStepper)this;
            if (thisAsIStepper.ValueChangedAction != null || thisAsIStepper.ValueChangedActionWithArgs != null)
            {
                NativeControl.ValueChanged += NativeControl_ValueChanged;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_ValueChanged(object? sender, ValueChangedEventArgs e)
        {
            var thisAsIStepper = (IStepper)this;
            thisAsIStepper.ValueChangedAction?.Invoke();
            thisAsIStepper.ValueChangedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.ValueChanged -= NativeControl_ValueChanged;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class Stepper : Stepper<Microsoft.Maui.Controls.Stepper>
    {
        public Stepper()
        {
        }

        public Stepper(Action<Microsoft.Maui.Controls.Stepper?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class StepperExtensions
    {
        public static T Maximum<T>(this T stepper, double maximum, RxDoubleAnimation? customAnimation = null)
            where T : IStepper
        {
            stepper.Maximum = new PropertyValue<double>(maximum);
            stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.MaximumProperty, customAnimation ?? new RxDoubleAnimation(maximum), v => stepper.Maximum = new PropertyValue<double>(v.CurrentValue()));
            return stepper;
        }

        public static T Maximum<T>(this T stepper, Func<double> maximumFunc)
            where T : IStepper
        {
            stepper.Maximum = new PropertyValue<double>(maximumFunc);
            return stepper;
        }

        public static T Minimum<T>(this T stepper, double minimum, RxDoubleAnimation? customAnimation = null)
            where T : IStepper
        {
            stepper.Minimum = new PropertyValue<double>(minimum);
            stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.MinimumProperty, customAnimation ?? new RxDoubleAnimation(minimum), v => stepper.Minimum = new PropertyValue<double>(v.CurrentValue()));
            return stepper;
        }

        public static T Minimum<T>(this T stepper, Func<double> minimumFunc)
            where T : IStepper
        {
            stepper.Minimum = new PropertyValue<double>(minimumFunc);
            return stepper;
        }

        public static T Value<T>(this T stepper, double value, RxDoubleAnimation? customAnimation = null)
            where T : IStepper
        {
            stepper.Value = new PropertyValue<double>(value);
            stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.ValueProperty, customAnimation ?? new RxDoubleAnimation(value), v => stepper.Value = new PropertyValue<double>(v.CurrentValue()));
            return stepper;
        }

        public static T Value<T>(this T stepper, Func<double> valueFunc)
            where T : IStepper
        {
            stepper.Value = new PropertyValue<double>(valueFunc);
            return stepper;
        }

        public static T Increment<T>(this T stepper, double increment, RxDoubleAnimation? customAnimation = null)
            where T : IStepper
        {
            stepper.Increment = new PropertyValue<double>(increment);
            stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.IncrementProperty, customAnimation ?? new RxDoubleAnimation(increment), v => stepper.Increment = new PropertyValue<double>(v.CurrentValue()));
            return stepper;
        }

        public static T Increment<T>(this T stepper, Func<double> incrementFunc)
            where T : IStepper
        {
            stepper.Increment = new PropertyValue<double>(incrementFunc);
            return stepper;
        }

        public static T OnValueChanged<T>(this T stepper, Action? valueChangedAction)
            where T : IStepper
        {
            stepper.ValueChangedAction = valueChangedAction;
            return stepper;
        }

        public static T OnValueChanged<T>(this T stepper, Action<object?, ValueChangedEventArgs>? valueChangedActionWithArgs)
            where T : IStepper
        {
            stepper.ValueChangedActionWithArgs = valueChangedActionWithArgs;
            return stepper;
        }
    }
}