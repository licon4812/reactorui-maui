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
    public partial interface IDropGestureRecognizer : IGestureRecognizer
    {
        PropertyValue<bool>? AllowDrop { get; set; }

        Action? DragLeaveAction { get; set; }

        Action<object?, DragEventArgs>? DragLeaveActionWithArgs { get; set; }

        Action? DragOverAction { get; set; }

        Action<object?, DragEventArgs>? DragOverActionWithArgs { get; set; }

        Action? DropAction { get; set; }

        Action<object?, DropEventArgs>? DropActionWithArgs { get; set; }
    }

    public partial class DropGestureRecognizer<T> : GestureRecognizer<T>, IDropGestureRecognizer where T : Microsoft.Maui.Controls.DropGestureRecognizer, new()
    {
        public DropGestureRecognizer()
        {
        }

        public DropGestureRecognizer(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<bool>? IDropGestureRecognizer.AllowDrop { get; set; }

        Action? IDropGestureRecognizer.DragLeaveAction { get; set; }

        Action<object?, DragEventArgs>? IDropGestureRecognizer.DragLeaveActionWithArgs { get; set; }

        Action? IDropGestureRecognizer.DragOverAction { get; set; }

        Action<object?, DragEventArgs>? IDropGestureRecognizer.DragOverActionWithArgs { get; set; }

        Action? IDropGestureRecognizer.DropAction { get; set; }

        Action<object?, DropEventArgs>? IDropGestureRecognizer.DropActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIDropGestureRecognizer = (IDropGestureRecognizer)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DropGestureRecognizer.AllowDropProperty, thisAsIDropGestureRecognizer.AllowDrop);
            base.OnUpdate();
            OnEndUpdate();
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
            var thisAsIDropGestureRecognizer = (IDropGestureRecognizer)this;
            if (thisAsIDropGestureRecognizer.DragLeaveAction != null || thisAsIDropGestureRecognizer.DragLeaveActionWithArgs != null)
            {
                NativeControl.DragLeave += NativeControl_DragLeave;
            }

            if (thisAsIDropGestureRecognizer.DragOverAction != null || thisAsIDropGestureRecognizer.DragOverActionWithArgs != null)
            {
                NativeControl.DragOver += NativeControl_DragOver;
            }

            if (thisAsIDropGestureRecognizer.DropAction != null || thisAsIDropGestureRecognizer.DropActionWithArgs != null)
            {
                NativeControl.Drop += NativeControl_Drop;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_DragLeave(object? sender, DragEventArgs e)
        {
            var thisAsIDropGestureRecognizer = (IDropGestureRecognizer)this;
            thisAsIDropGestureRecognizer.DragLeaveAction?.Invoke();
            thisAsIDropGestureRecognizer.DragLeaveActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_DragOver(object? sender, DragEventArgs e)
        {
            var thisAsIDropGestureRecognizer = (IDropGestureRecognizer)this;
            thisAsIDropGestureRecognizer.DragOverAction?.Invoke();
            thisAsIDropGestureRecognizer.DragOverActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_Drop(object? sender, DropEventArgs e)
        {
            var thisAsIDropGestureRecognizer = (IDropGestureRecognizer)this;
            thisAsIDropGestureRecognizer.DropAction?.Invoke();
            thisAsIDropGestureRecognizer.DropActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.DragLeave -= NativeControl_DragLeave;
                NativeControl.DragOver -= NativeControl_DragOver;
                NativeControl.Drop -= NativeControl_Drop;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class DropGestureRecognizer : DropGestureRecognizer<Microsoft.Maui.Controls.DropGestureRecognizer>
    {
        public DropGestureRecognizer()
        {
        }

        public DropGestureRecognizer(Action<Microsoft.Maui.Controls.DropGestureRecognizer?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class DropGestureRecognizerExtensions
    {
        public static T AllowDrop<T>(this T dropGestureRecognizer, bool allowDrop)
            where T : IDropGestureRecognizer
        {
            dropGestureRecognizer.AllowDrop = new PropertyValue<bool>(allowDrop);
            return dropGestureRecognizer;
        }

        public static T AllowDrop<T>(this T dropGestureRecognizer, Func<bool> allowDropFunc)
            where T : IDropGestureRecognizer
        {
            dropGestureRecognizer.AllowDrop = new PropertyValue<bool>(allowDropFunc);
            return dropGestureRecognizer;
        }

        public static T OnDragLeave<T>(this T dropGestureRecognizer, Action? dragLeaveAction)
            where T : IDropGestureRecognizer
        {
            dropGestureRecognizer.DragLeaveAction = dragLeaveAction;
            return dropGestureRecognizer;
        }

        public static T OnDragLeave<T>(this T dropGestureRecognizer, Action<object?, DragEventArgs>? dragLeaveActionWithArgs)
            where T : IDropGestureRecognizer
        {
            dropGestureRecognizer.DragLeaveActionWithArgs = dragLeaveActionWithArgs;
            return dropGestureRecognizer;
        }

        public static T OnDragOver<T>(this T dropGestureRecognizer, Action? dragOverAction)
            where T : IDropGestureRecognizer
        {
            dropGestureRecognizer.DragOverAction = dragOverAction;
            return dropGestureRecognizer;
        }

        public static T OnDragOver<T>(this T dropGestureRecognizer, Action<object?, DragEventArgs>? dragOverActionWithArgs)
            where T : IDropGestureRecognizer
        {
            dropGestureRecognizer.DragOverActionWithArgs = dragOverActionWithArgs;
            return dropGestureRecognizer;
        }

        public static T OnDrop<T>(this T dropGestureRecognizer, Action? dropAction)
            where T : IDropGestureRecognizer
        {
            dropGestureRecognizer.DropAction = dropAction;
            return dropGestureRecognizer;
        }

        public static T OnDrop<T>(this T dropGestureRecognizer, Action<object?, DropEventArgs>? dropActionWithArgs)
            where T : IDropGestureRecognizer
        {
            dropGestureRecognizer.DropActionWithArgs = dropActionWithArgs;
            return dropGestureRecognizer;
        }
    }
}