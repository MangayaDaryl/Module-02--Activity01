using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PDC03_MOD2
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Button btn = new Button();
            btn.Text = "Click Me!";
            btn.TextColor = Color.Olive;
            btn.BackgroundColor = Color.Accent;
            btn.FontSize = 25;
            btn.Clicked += Btn_Clicked;
            Content = new StackLayout
            {
                Children = {btn }
            };
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Second());
        }
    }
}