using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ContohXamarin.Models;
using ContohXamarin.Services;
using System.Collections.ObjectModel;

namespace ContohXamarin.ViewModels
{
    public class DaftarPasienViewModel :BindableObject
    {
        private ObservableCollection<Pasien> listPasien;
        public ObservableCollection<Pasien> ListPasien
        {
            get { return listPasien; }
            set { listPasien = value; OnPropertyChanged("ListPasien"); }
        }

        public async void Create()
        {
            PasienServices pasienService = new PasienServices();
            listPasien = new ObservableCollection<Pasien>(await pasienService.GetAllPasien());
        }

        public DaftarPasienViewModel()
        {
            Create();
        }
    }
}
