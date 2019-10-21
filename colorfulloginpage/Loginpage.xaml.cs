using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace colorfulloginpage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loginpage : ContentPage
    {
        public Loginpage()
        {
            InitializeComponent();
        }
        private void submit_Clicked(object sender, EventArgs e)
        {
            string name = username.Text;
            string pass = password.Text;

            DisplayAlert("Entries value", name + " " + pass, "ok");
        }
    }
}