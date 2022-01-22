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
    public partial interface ILinearItemsLayout : IItemsLayout
    {
        PropertyValue<double>? ItemSpacing { get; set; }


    }
    public abstract partial class LinearItemsLayout<T> : ItemsLayout<T>, ILinearItemsLayout where T : Microsoft.Maui.Controls.LinearItemsLayout, new()
    {
        protected LinearItemsLayout()
        {

        }

        protected LinearItemsLayout(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<double>? ILinearItemsLayout.ItemSpacing { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsILinearItemsLayout = (ILinearItemsLayout)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.LinearItemsLayout.ItemSpacingProperty, thisAsILinearItemsLayout.ItemSpacing);


            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }


    public static partial class LinearItemsLayoutExtensions
    {
        public static T ItemSpacing<T>(this T linearItemsLayout, double itemSpacing, RxDoubleAnimation? customAnimation = null) where T : ILinearItemsLayout
        {
            linearItemsLayout.ItemSpacing = new PropertyValue<double>(itemSpacing);
            linearItemsLayout.AppendAnimatable(Microsoft.Maui.Controls.LinearItemsLayout.ItemSpacingProperty, customAnimation ?? new RxDoubleAnimation(itemSpacing), v => linearItemsLayout.ItemSpacing = new PropertyValue<double>(v.CurrentValue()));
            return linearItemsLayout;
        }

        public static T ItemSpacing<T>(this T linearItemsLayout, Func<double> itemSpacingFunc) where T : ILinearItemsLayout
        {
            linearItemsLayout.ItemSpacing = new PropertyValue<double>(itemSpacingFunc);
            return linearItemsLayout;
        }




    }
}
