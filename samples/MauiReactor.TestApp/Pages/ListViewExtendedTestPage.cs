﻿using MauiReactor.TestApp.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactor.TestApp.Pages;

class ListViewExtendedTestPageState
{
    public Person? SelectedPerson { get; set; }
}

class ListViewExtendedTestPage : Component<ListViewExtendedTestPageState>
{
    public override VisualNode Render()
    {
        return new ContentPage("ListView Extended Test (BETA)")
        {
            new ListView(MauiControls.ListViewCachingStrategy.RecycleElementAndDataTemplate)
                .IsGroupingEnabled(true)
                .ItemsSource<ListView, GroupOfPerson, Person>(GroupOfPerson.All, RenderGroup, RenderItem)
                .SeparatorVisibility(MauiControls.SeparatorVisibility.None)
                .OnItemSelected(OnSelectedItem)
                //NOTE: Header/Footer not working under .net 7
                //https://github.com/dotnet/maui/issues/13560
                //https://github.com/dotnet/maui/issues/12312
                //.Header(new Label("Header"))
                //.Footer(new Label("Footer"))
        };
    }

    private void OnSelectedItem(object? sender, SelectedItemChangedEventArgs args)
    {
        SetState(s => s.SelectedPerson = args.SelectedItem as Person);
    }

    private ViewCell RenderGroup(GroupOfPerson person)
    {
        return new ViewCell
        {
            new Label(person.Initial)
            {
                new MenuFlyout
                {
                    new MenuFlyoutItem("MenuItem1")
                        .OnClicked(()=>OnClickMenuItem("MenuItem1")),
                    new MenuFlyoutItem("MenuItem2")
                        .OnClicked(()=>OnClickMenuItem("MenuItem2")),
                    new MenuFlyoutItem("MenuItem3")
                        .OnClicked(()=>OnClickMenuItem("MenuItem3")),
                }
            }
            .FontSize(14.0)
            .FontAttributes(MauiControls.FontAttributes.Bold)
            .Margin(5)
            .BackgroundColor(Colors.LightGray)
            ,
        };
    }

    private ViewCell RenderItem(Person person)
    {
        return new ViewCell
        {
            new Label($"{person.FirstName} {person.LastName}")
                .FontSize(14.0)
                .FontAttributes(MauiControls.FontAttributes.Bold)
                .Padding(5)
                .VerticalTextAlignment(TextAlignment.Center)
        };
    }

    private void OnClickMenuItem(string title)
    {
        ContainerPage?.DisplayAlert("MauiReactor", $"Clicked menu {title}", "OK");
    }

}
