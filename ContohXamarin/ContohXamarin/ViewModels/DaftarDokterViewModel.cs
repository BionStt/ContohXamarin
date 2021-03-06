﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ContohXamarin.Models;

namespace ContohXamarin.ViewModels
{
    public class DaftarDokterViewModel : BindableObject
    {
        private List<Dokter> listDokter;
        public List<Dokter> ListDokter
        {
            get { return listDokter; }
            set { listDokter = value; OnPropertyChanged("ListDokter"); }
        }

        public DaftarDokterViewModel()
        {
            listDokter = new List<Dokter>
            {
                new Dokter {NIA="12345",Nama="drg.Andi Setiawan",Spesialisasi="Prosto",
                    Gambar ="first.png",Alamat="Jl Mangga 12"},
                new Dokter {NIA="23456",Nama="drg.Bambang Wahyudi",Spesialisasi="Bedah Mulut",
                    Gambar ="second.png",Alamat="Jl Rajawali 23"},
                new Dokter {NIA="34567",Nama="drg.Budi Halim",Spesialisasi="Orto",
                    Gambar ="third.png",Alamat="Jl Mawar 11"}
            };
        }

    }
}
