using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherApp 
{
    public class  Weather
    {
        private System.DateTime _datum;



        public System.DateTime Datum
        {
            get => _datum;
            set
            {
                _datum = value;
            }
        }

        string _titel = string.Empty;
            public string Titel
        {
            get => _titel;
            set
            {
                _titel = value;
            }
        }
        string _bild = string.Empty;

        public string Bild
        {
            get => _bild;
            set
            {
                _bild = value;
            }
        }

        string _beschreibung = string.Empty;
        public string Beschreibung
        {
            get => _beschreibung;
            set
            {
                _beschreibung = value;
                
            }
        }

      
    }
}