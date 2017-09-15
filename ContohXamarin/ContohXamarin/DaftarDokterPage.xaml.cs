using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ContohXamarin.ViewModels;

namespace ContohXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DaftarDokterPage : ContentPage
    {
        public DaftarDokterPage()
        {
            InitializeComponent();
            BindingContext = new DaftarDokterViewModel();
        }
    }
}