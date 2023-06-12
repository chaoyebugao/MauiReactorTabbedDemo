using MauiReactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactorTabbedDemo.Pages
{
    internal class LoginPage : Component
    {
        public override VisualNode Render()
        {
            return new ContentPage()
            {
                new Label("Login Page Label")
            }.Title("Login Page");
        }
    }
}
