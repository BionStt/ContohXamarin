using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContohXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleGridLayout : ContentPage
    {
        public SampleGridLayout()
        {
            InitializeComponent();

            btnTambah.Clicked += BtnHitung_Clicked;
            btnKurang.Clicked += BtnHitung_Clicked;
            btnKali.Clicked += BtnHitung_Clicked;
            btnBagi.Clicked += BtnHitung_Clicked;
        }

        private void BtnHitung_Clicked(object sender, EventArgs e)
        {
            double bil1 = Convert.ToDouble(txtBil1.Text);
            double bil2 = Convert.ToDouble(txtBil2.Text);
            double hasil;

            var myBtn = (Button)sender;
            if (myBtn.Text == "Tambah")
            {
                hasil = bil1 + bil2;
            }
            else if (myBtn.Text == "Kurang")
            {
                hasil = bil1 - bil2;
            }
            else if(myBtn.Text == "Kali")
            {
                hasil = bil1 * bil2;
            }
            else
            {
                hasil = bil1 / bil2;
            }
            txtHasil.Text = hasil.ToString();
        }

        private async void btnCek_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Keterangan", "Data : " + Application.Current.Properties["username"].ToString(),
                "OK");
        }
    }
}