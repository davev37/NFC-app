using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFC_App
{
    
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        public void GoToLoginPage(object Sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}