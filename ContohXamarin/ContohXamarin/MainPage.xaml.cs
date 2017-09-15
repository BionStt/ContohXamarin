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

        private async void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            if(txtUsername.Text=="erick" && txtPassword.Text=="rahasia")
            {
                Application.Current.Properties["username"] = txtUsername.Text;
                await DisplayAlert("Keterangan", "Login berhasil !","OK");
            }
            else
            {
                await DisplayAlert("Keterangan", "Username / Password tidak tepat", "OK");
            }
            
            
        }

        private async void DaftarDokterItem_Clicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties["username"].ToString() != string.Empty)
                await Navigation.PushAsync(new DokterPage());
            else
                await DisplayAlert("Keterangan", "Anda harus login dulu", "OK");
        }

        private async void CalculatorItem_Clicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties["username"].ToString() != string.Empty)
                await Navigation.PushAsync(new SampleGridLayout());
            else
                await DisplayAlert("Keterangan", "Anda harus login dulu", "OK");
        }
    }
}
