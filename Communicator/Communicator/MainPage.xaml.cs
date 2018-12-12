using System;

using Xamarin.Forms;

namespace Communicator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert(
                "Booom",
                $"You have searched for {Test_search.Text}",
                "OK");
            //Test_Label.Text = $"You have searched for {Test_search.Text}";
        }
    }
}
