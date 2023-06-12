using MauiReactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactorTabbedDemo.Pages
{
    internal class LoginTabbedPage : Component
    {
        public override VisualNode Render()
        {
            return new TabbedPage()
            {
                //new LoginPage(),
                //new RegisterPage(),

                new ContentPage()
                {
                    new Label("Label 1"),
                },
                new ContentPage()
                {
                    new Label("Label 2"),
                },
            };
        }
    }
}
