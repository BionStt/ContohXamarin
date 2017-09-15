using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ContohXamarin.ViewModels;
using ContohXamarin.Models;

namespace ContohXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DokterPage : ContentPage
    {
        public DokterPage()
        {
            InitializeComponent();
            BindingContext = new DaftarDokterViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var dokter = (Dokter)e.Item;
            DisplayAlert("Keterangan", "Anda memilih Dokter: " + dokter.Nama, "OK");
        }
    }
}