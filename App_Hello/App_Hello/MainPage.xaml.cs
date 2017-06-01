using System;
using Xamarin.Forms;

namespace App_Hello
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            /*------ Styles dinâmicos ------*/
            Resources["dynamicStyle"] = Resources["blackButtonStyle"];
        }

        async void OnPerson(object sender, EventArgs args) => await Navigation.PushAsync(new PersonPage());
        async void OnTalk(object sender, EventArgs args) => await Navigation.PushAsync(new TalkPage());
    }
}
