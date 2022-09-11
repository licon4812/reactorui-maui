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
    public partial interface IShadow : IElement
    {
        PropertyValue<float>? Radius { get; set; }
        PropertyValue<float>? Opacity { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? Brush { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Point>? Offset { get; set; }


    }

    public partial class Shadow<T> : Element<T>, IShadow where T : Microsoft.Maui.Controls.Shadow, new()
    {
        public Shadow()
        {

        }

        public Shadow(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<float>? IShadow.Radius { get; set; }
        PropertyValue<float>? IShadow.Opacity { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? IShadow.Brush { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Point>? IShadow.Offset { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIShadow = (IShadow)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shadow.RadiusProperty, thisAsIShadow.Radius);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shadow.OpacityProperty, thisAsIShadow.Opacity);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shadow.BrushProperty, thisAsIShadow.Brush);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shadow.OffsetProperty, thisAsIShadow.Offset);


            base.OnUpdate();

            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIShadow = (IShadow)this;

            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shadow.OffsetProperty, thisAsIShadow.Offset);

            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }

    public partial class Shadow : Shadow<Microsoft.Maui.Controls.Shadow>
    {
        public Shadow()
        {

        }

        public Shadow(Action<Microsoft.Maui.Controls.Shadow?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class ShadowExtensions
    {
        public static T Radius<T>(this T shadow, float radius) where T : IShadow
        {
            shadow.Radius = new PropertyValue<float>(radius);
            return shadow;
        }

        public static T Radius<T>(this T shadow, Func<float> radiusFunc) where T : IShadow
        {
            shadow.Radius = new PropertyValue<float>(radiusFunc);
            return shadow;
        }



        public static T Opacity<T>(this T shadow, float opacity) where T : IShadow
        {
            shadow.Opacity = new PropertyValue<float>(opacity);
            return shadow;
        }

        public static T Opacity<T>(this T shadow, Func<float> opacityFunc) where T : IShadow
        {
            shadow.Opacity = new PropertyValue<float>(opacityFunc);
            return shadow;
        }



        public static T Brush<T>(this T shadow, Microsoft.Maui.Controls.Brush brush) where T : IShadow
        {
            shadow.Brush = new PropertyValue<Microsoft.Maui.Controls.Brush>(brush);
            return shadow;
        }

        public static T Brush<T>(this T shadow, Func<Microsoft.Maui.Controls.Brush> brushFunc) where T : IShadow
        {
            shadow.Brush = new PropertyValue<Microsoft.Maui.Controls.Brush>(brushFunc);
            return shadow;
        }



        public static T Offset<T>(this T shadow, Microsoft.Maui.Graphics.Point offset, RxPointAnimation? customAnimation = null) where T : IShadow
        {
            shadow.Offset = new PropertyValue<Microsoft.Maui.Graphics.Point>(offset);
            shadow.AppendAnimatable(Microsoft.Maui.Controls.Shadow.OffsetProperty, customAnimation ?? new RxSimplePointAnimation(offset), v => shadow.Offset = new PropertyValue<Microsoft.Maui.Graphics.Point>(v.CurrentValue()));
            return shadow;
        }

        public static T Offset<T>(this T shadow, Func<Microsoft.Maui.Graphics.Point> offsetFunc) where T : IShadow
        {
            shadow.Offset = new PropertyValue<Microsoft.Maui.Graphics.Point>(offsetFunc);
            return shadow;
        }
        public static T Offset<T>(this T shadow, double x, double y) where T : IShadow
        {
            shadow.Offset = new PropertyValue<Microsoft.Maui.Graphics.Point>(new Microsoft.Maui.Graphics.Point(x, y));
            return shadow;
        }




    }
}
