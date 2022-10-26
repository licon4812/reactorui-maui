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
    public partial interface IToolbarItem : IMenuItem
    {
    }

    public partial class ToolbarItem<T> : MenuItem<T>, IToolbarItem where T : Microsoft.Maui.Controls.ToolbarItem, new()
    {
        public ToolbarItem()
        {
        }

        public ToolbarItem(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            base.OnUpdate();
            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
    }

    public partial class ToolbarItem : ToolbarItem<Microsoft.Maui.Controls.ToolbarItem>
    {
        public ToolbarItem()
        {
        }

        public ToolbarItem(Action<Microsoft.Maui.Controls.ToolbarItem?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class ToolbarItemExtensions
    {
    }
}