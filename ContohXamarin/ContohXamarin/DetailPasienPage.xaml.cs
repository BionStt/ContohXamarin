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
    public partial class DetailPasienPage : ContentPage
    {
        public DetailPasienPage()
        {
            InitializeComponent();
        }

        private async void btnEdit_Clicked(object sender, EventArgs e)
        {
            var editPasien = new Pasien
            {
                Nama = txtNama.Text,
                Alamat = txtAlamat.Text,
                Telpon = txtTelpon.Text,
                Umur = Convert.ToInt32(txtUmur.Text),
                PasienID = Convert.ToInt32(txtPasienID.Text)
            };

            PasienServices pasienServices = new PasienServices();
            try
            {
                await pasienServices.UpdatePasien(editPasien);
                await DisplayAlert("Keterangan", "Data Pasien berhasil diedit", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {
            var deletePasien = new Pasien
            {
                Nama = txtNama.Text,
                Alamat = txtAlamat.Text,
                Telpon = txtTelpon.Text,
                Umur = Convert.ToInt32(txtUmur.Text),
                PasienID = Convert.ToInt32(txtPasienID.Text)
            };

            PasienServices pasienServices = new PasienServices();
            try
            {
                await pasienServices.DeletePasien(deletePasien);
                await DisplayAlert("Keterangan", "Data Pasien berhasil didelete", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}