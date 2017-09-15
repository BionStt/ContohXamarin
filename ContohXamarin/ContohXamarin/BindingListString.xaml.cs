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
    public partial class BindingListString : ContentPage
    {
        public BindingListString()
        {
            InitializeComponent();

            List<string> items = 
                new List<string> { "Samsung Galaxy S8", "Samsung Note 8", "Iphone X", "Iphone 8S", "Iphone 8" };
            listView.ItemsSource = items;

            listView.ItemTapped += ListView_ItemTapped;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Keterangan", "Anda memilih : " + e.Item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}