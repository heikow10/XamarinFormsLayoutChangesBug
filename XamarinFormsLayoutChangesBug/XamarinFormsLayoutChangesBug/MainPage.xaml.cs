using System;
using Xamarin.Forms;

namespace XamarinFormsLayoutChangesBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ContainerStackLayout.Children.Add(new StackLayout() { BackgroundColor = Color.Gray, HeightRequest = 40.0 });
        }
    }
}
