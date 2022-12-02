using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Collections;
using System.Collections.ObjectModel;

namespace WeatherApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Weather> _wetter =
            new ObservableCollection<Weather>();




        [ObservableProperty]
        Weather _wetter1 = new Weather()
        {
            Bild = "",
            Datum = DateTime.Now,
            Titel = "",
            Beschreibung = ""
        };


        public MainViewModel()
        {
            Weather w1 = new Weather()
            {
                Titel = "Sonnenschein",
                Beschreibung = "Die Sonne scheint.",
                Bild = "sonne.jpg",
                Datum = DateTime.Now


            };
            this.Wetter.Add(w1);

            Weather w2 = new Weather()
            {
                Titel = "Regnerisch",
                Beschreibung = "Es regnet viel.",
                Bild = "regen.jpg",
                Datum = DateTime.Now


            };
            this.Wetter.Add(w2);

            Weather w3 = new Weather()
            {
                Titel = "Schnee",
                Beschreibung = "Es schneit und viel schnee liegt am Boden.",
                Bild = "schnee.jpg",
                Datum = DateTime.Now


            };
            this.Wetter.Add(w3);


        }
    }
}
