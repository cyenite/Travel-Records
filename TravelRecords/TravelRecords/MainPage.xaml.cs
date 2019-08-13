using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecords
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = String.IsNullOrEmpty(emailentry.Text);
            bool isPasswordEmpty = String.IsNullOrEmpty(passwordEntry.Text);
            if (isPasswordEmpty || isEmailEmpty)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());

            }            
        }
    }
}
