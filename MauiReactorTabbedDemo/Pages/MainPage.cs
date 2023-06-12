using MauiReactor;
using Microsoft.Maui.ApplicationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactorTabbedDemo.Pages
{
    internal class MainPageState
    {
        public int Counter { get; set; }
    }

    internal class MainPage : Component<MainPageState>
    {
        public override VisualNode Render()
        {
            return new NavigationPage()
            {
                new ContentPage
                {
                    new ScrollView
                    {
                        new VerticalStackLayout
                        {
                            new Image("dotnet_bot.png")
                                .HeightRequest(200)
                                .HCenter()
                                .Set(Microsoft.Maui.Controls.SemanticProperties.DescriptionProperty, "Cute dot net bot waving hi to you!"),

                            new Label("Hello, World!")
                                .FontSize(32)
                                .HCenter(),

                            new Label("Welcome to MauiReactor: MAUI with superpowers!")
                                .FontSize(18)
                                .HCenter(),

                            new Button(State.Counter == 0 ? "Click me" : $"Clicked {State.Counter} times!")
                                .OnClicked(HandleClick)
                                .HCenter()
                        }
                        .VCenter()
                        .Spacing(25)
                        .Padding(30, 0)
                    }
                }
            };
        }


        private void HandleClick()
        {
            SetState(s => s.Counter++);

            //var navTask = Navigation.PushAsync<LoginPage>();
            //navTask.ContinueWith(t =>
            //{
            //});

            var navTask = Navigation.PushAsync<LoginTabbedPage>();
            navTask.ContinueWith(t =>
            {
            });
        }
    }
}