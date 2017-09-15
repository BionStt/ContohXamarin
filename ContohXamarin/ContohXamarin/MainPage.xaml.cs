using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContohXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnSubmit.Clicked += BtnSubmit_Clicked;
        }

        private void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", "Jadi nama anda "+txtFirstname.Text+" "+
                txtLastname.Text, "OK");
        }

        private void DaftarDokterItem_Clicked(object sender, EventArgs e)
        {

        }

        private void CalculatorItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}
