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
    public partial interface IFlexLayout : ILayout
    {
        PropertyValue<Microsoft.Maui.Layouts.FlexDirection>? Direction { get; set; }
        PropertyValue<Microsoft.Maui.Layouts.FlexJustify>? JustifyContent { get; set; }
        PropertyValue<Microsoft.Maui.Layouts.FlexAlignContent>? AlignContent { get; set; }
        PropertyValue<Microsoft.Maui.Layouts.FlexAlignItems>? AlignItems { get; set; }
        PropertyValue<Microsoft.Maui.Layouts.FlexPosition>? Position { get; set; }
        PropertyValue<Microsoft.Maui.Layouts.FlexWrap>? Wrap { get; set; }


    }
    public partial class FlexLayout<T> : Layout<T>, IFlexLayout where T : Microsoft.Maui.Controls.FlexLayout, new()
    {
        public FlexLayout()
        {

        }

        public FlexLayout(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Layouts.FlexDirection>? IFlexLayout.Direction { get; set; }
        PropertyValue<Microsoft.Maui.Layouts.FlexJustify>? IFlexLayout.JustifyContent { get; set; }
        PropertyValue<Microsoft.Maui.Layouts.FlexAlignContent>? IFlexLayout.AlignContent { get; set; }
        PropertyValue<Microsoft.Maui.Layouts.FlexAlignItems>? IFlexLayout.AlignItems { get; set; }
        PropertyValue<Microsoft.Maui.Layouts.FlexPosition>? IFlexLayout.Position { get; set; }
        PropertyValue<Microsoft.Maui.Layouts.FlexWrap>? IFlexLayout.Wrap { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIFlexLayout = (IFlexLayout)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.FlexLayout.DirectionProperty, thisAsIFlexLayout.Direction);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.FlexLayout.JustifyContentProperty, thisAsIFlexLayout.JustifyContent);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.FlexLayout.AlignContentProperty, thisAsIFlexLayout.AlignContent);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.FlexLayout.AlignItemsProperty, thisAsIFlexLayout.AlignItems);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.FlexLayout.PositionProperty, thisAsIFlexLayout.Position);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.FlexLayout.WrapProperty, thisAsIFlexLayout.Wrap);


            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }

    public partial class FlexLayout : FlexLayout<Microsoft.Maui.Controls.FlexLayout>
    {
        public FlexLayout()
        {

        }

        public FlexLayout(Action<Microsoft.Maui.Controls.FlexLayout?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class FlexLayoutExtensions
    {
        public static T Direction<T>(this T flexLayout, Microsoft.Maui.Layouts.FlexDirection direction) where T : IFlexLayout
        {
            flexLayout.Direction = new PropertyValue<Microsoft.Maui.Layouts.FlexDirection>(direction);
            return flexLayout;
        }

        public static T Direction<T>(this T flexLayout, Func<Microsoft.Maui.Layouts.FlexDirection> directionFunc) where T : IFlexLayout
        {
            flexLayout.Direction = new PropertyValue<Microsoft.Maui.Layouts.FlexDirection>(directionFunc);
            return flexLayout;
        }



        public static T JustifyContent<T>(this T flexLayout, Microsoft.Maui.Layouts.FlexJustify justifyContent) where T : IFlexLayout
        {
            flexLayout.JustifyContent = new PropertyValue<Microsoft.Maui.Layouts.FlexJustify>(justifyContent);
            return flexLayout;
        }

        public static T JustifyContent<T>(this T flexLayout, Func<Microsoft.Maui.Layouts.FlexJustify> justifyContentFunc) where T : IFlexLayout
        {
            flexLayout.JustifyContent = new PropertyValue<Microsoft.Maui.Layouts.FlexJustify>(justifyContentFunc);
            return flexLayout;
        }



        public static T AlignContent<T>(this T flexLayout, Microsoft.Maui.Layouts.FlexAlignContent alignContent) where T : IFlexLayout
        {
            flexLayout.AlignContent = new PropertyValue<Microsoft.Maui.Layouts.FlexAlignContent>(alignContent);
            return flexLayout;
        }

        public static T AlignContent<T>(this T flexLayout, Func<Microsoft.Maui.Layouts.FlexAlignContent> alignContentFunc) where T : IFlexLayout
        {
            flexLayout.AlignContent = new PropertyValue<Microsoft.Maui.Layouts.FlexAlignContent>(alignContentFunc);
            return flexLayout;
        }



        public static T AlignItems<T>(this T flexLayout, Microsoft.Maui.Layouts.FlexAlignItems alignItems) where T : IFlexLayout
        {
            flexLayout.AlignItems = new PropertyValue<Microsoft.Maui.Layouts.FlexAlignItems>(alignItems);
            return flexLayout;
        }

        public static T AlignItems<T>(this T flexLayout, Func<Microsoft.Maui.Layouts.FlexAlignItems> alignItemsFunc) where T : IFlexLayout
        {
            flexLayout.AlignItems = new PropertyValue<Microsoft.Maui.Layouts.FlexAlignItems>(alignItemsFunc);
            return flexLayout;
        }



        public static T Position<T>(this T flexLayout, Microsoft.Maui.Layouts.FlexPosition position) where T : IFlexLayout
        {
            flexLayout.Position = new PropertyValue<Microsoft.Maui.Layouts.FlexPosition>(position);
            return flexLayout;
        }

        public static T Position<T>(this T flexLayout, Func<Microsoft.Maui.Layouts.FlexPosition> positionFunc) where T : IFlexLayout
        {
            flexLayout.Position = new PropertyValue<Microsoft.Maui.Layouts.FlexPosition>(positionFunc);
            return flexLayout;
        }



        public static T Wrap<T>(this T flexLayout, Microsoft.Maui.Layouts.FlexWrap wrap) where T : IFlexLayout
        {
            flexLayout.Wrap = new PropertyValue<Microsoft.Maui.Layouts.FlexWrap>(wrap);
            return flexLayout;
        }

        public static T Wrap<T>(this T flexLayout, Func<Microsoft.Maui.Layouts.FlexWrap> wrapFunc) where T : IFlexLayout
        {
            flexLayout.Wrap = new PropertyValue<Microsoft.Maui.Layouts.FlexWrap>(wrapFunc);
            return flexLayout;
        }




    }
}
