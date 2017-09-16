
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ContohXamarin.Models;
using ContohXamarin.Services;

namespace ContohXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TambahPasienPage : ContentPage
    {
        public TambahPasienPage()
        {
            InitializeComponent();
        }

        private async void btnTambah_Clicked(object sender, EventArgs e)
        {
            var newPasien = new Pasien
            {
                Nama = txtNama.Text,
                Alamat = txtAlamat.Text,
                Telpon = txtTelpon.Text,
                Umur = Convert.ToInt32(txtUmur.Text)
            };

            PasienServices pasienServices = new PasienServices();
            try
            {
                await pasienServices.TambahPasien(newPasien);
                await DisplayAlert("Keterangan", "Data Pasien berhasil ditambah", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}