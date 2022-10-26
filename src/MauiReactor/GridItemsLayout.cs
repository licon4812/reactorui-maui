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
    public partial interface IGridItemsLayout : IItemsLayout
    {
        PropertyValue<int>? Span { get; set; }

        PropertyValue<double>? VerticalItemSpacing { get; set; }

        PropertyValue<double>? HorizontalItemSpacing { get; set; }
    }

    public abstract partial class GridItemsLayout<T> : ItemsLayout<T>, IGridItemsLayout where T : Microsoft.Maui.Controls.GridItemsLayout, new()
    {
        protected GridItemsLayout()
        {
        }

        protected GridItemsLayout(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<int>? IGridItemsLayout.Span { get; set; }

        PropertyValue<double>? IGridItemsLayout.VerticalItemSpacing { get; set; }

        PropertyValue<double>? IGridItemsLayout.HorizontalItemSpacing { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIGridItemsLayout = (IGridItemsLayout)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.GridItemsLayout.SpanProperty, thisAsIGridItemsLayout.Span);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.GridItemsLayout.VerticalItemSpacingProperty, thisAsIGridItemsLayout.VerticalItemSpacing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.GridItemsLayout.HorizontalItemSpacingProperty, thisAsIGridItemsLayout.HorizontalItemSpacing);
            base.OnUpdate();
            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIGridItemsLayout = (IGridItemsLayout)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.GridItemsLayout.VerticalItemSpacingProperty, thisAsIGridItemsLayout.VerticalItemSpacing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.GridItemsLayout.HorizontalItemSpacingProperty, thisAsIGridItemsLayout.HorizontalItemSpacing);
            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
    }

    public static partial class GridItemsLayoutExtensions
    {
        public static T Span<T>(this T gridItemsLayout, int span)
            where T : IGridItemsLayout
        {
            gridItemsLayout.Span = new PropertyValue<int>(span);
            return gridItemsLayout;
        }

        public static T Span<T>(this T gridItemsLayout, Func<int> spanFunc)
            where T : IGridItemsLayout
        {
            gridItemsLayout.Span = new PropertyValue<int>(spanFunc);
            return gridItemsLayout;
        }

        public static T VerticalItemSpacing<T>(this T gridItemsLayout, double verticalItemSpacing, RxDoubleAnimation? customAnimation = null)
            where T : IGridItemsLayout
        {
            gridItemsLayout.VerticalItemSpacing = new PropertyValue<double>(verticalItemSpacing);
            gridItemsLayout.AppendAnimatable(Microsoft.Maui.Controls.GridItemsLayout.VerticalItemSpacingProperty, customAnimation ?? new RxDoubleAnimation(verticalItemSpacing), v => gridItemsLayout.VerticalItemSpacing = new PropertyValue<double>(v.CurrentValue()));
            return gridItemsLayout;
        }

        public static T VerticalItemSpacing<T>(this T gridItemsLayout, Func<double> verticalItemSpacingFunc)
            where T : IGridItemsLayout
        {
            gridItemsLayout.VerticalItemSpacing = new PropertyValue<double>(verticalItemSpacingFunc);
            return gridItemsLayout;
        }

        public static T HorizontalItemSpacing<T>(this T gridItemsLayout, double horizontalItemSpacing, RxDoubleAnimation? customAnimation = null)
            where T : IGridItemsLayout
        {
            gridItemsLayout.HorizontalItemSpacing = new PropertyValue<double>(horizontalItemSpacing);
            gridItemsLayout.AppendAnimatable(Microsoft.Maui.Controls.GridItemsLayout.HorizontalItemSpacingProperty, customAnimation ?? new RxDoubleAnimation(horizontalItemSpacing), v => gridItemsLayout.HorizontalItemSpacing = new PropertyValue<double>(v.CurrentValue()));
            return gridItemsLayout;
        }

        public static T HorizontalItemSpacing<T>(this T gridItemsLayout, Func<double> horizontalItemSpacingFunc)
            where T : IGridItemsLayout
        {
            gridItemsLayout.HorizontalItemSpacing = new PropertyValue<double>(horizontalItemSpacingFunc);
            return gridItemsLayout;
        }
    }
}