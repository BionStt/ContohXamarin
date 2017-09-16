using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using ContohXamarin.Services;
using ContohXamarin.Models;

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
            PenggunaServices penggunaServices = new PenggunaServices();
            Pengguna pgn = new Pengguna
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };
            var isValid = await penggunaServices.Login(pgn);

            if (isValid)
            {
                Application.Current.Properties["username"] = txtUsername.Text;
                await Navigation.PushAsync(new DaftarPasienPage());
            }
            else
            {
                await DisplayAlert("Keterangan", "Username / Password tidak sesuai", "OK");
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
