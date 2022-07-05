using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3_2.NET
{
   public class Albumy : INotifyPropertyChanged
    {
        public string tytul;
        public string autor;
        public string wydawca;
        public string nosnik;
        public DateTime datawydania;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private readonly static Dictionary<string, string[]> relatedProperties = new Dictionary<string, string[]>()
        {
            ["Tytul"] = new string[] { "Tytul", "FormatListy" },
            ["Autor"] = new string[] { "Autor", "FormatListy" },
            ["Wydawca"] = new string[] { "Wydawca", "FormatListy" },
            ["Nosnik"] = new string[] { "Nosnik", "FormatListy" },
             ["DataWydania"] = new string[] { "DataWydania", "FormatListy" }
        };

        public string Tytul
        {
            get { return tytul; }
            set 
            { 
                tytul = value;
                NotifyPropertyChanged("Tytul");
                NotifyPropertyChanged("FormatListy");
            }
            
        }
        public string Autor
        {
            get { return autor; }
            set 
            { 
                autor = value;
                NotifyPropertyChanged("Autor");
                NotifyPropertyChanged("FormatListy");
            }
        }
        public string Wydawca
        {
            get { return wydawca; }
            set 
            { 
                wydawca = value;
                NotifyPropertyChanged("Wydawca");
                NotifyPropertyChanged("FormatListy");
            }
        }
        public string Nosnik
        {
            get { return nosnik; }
            set 
            { 
                nosnik = value;
                NotifyPropertyChanged("Nosnik");
                NotifyPropertyChanged("FormatListy");
            }
        }
        public DateTime DataWydania
        {
            get { return datawydania; }
            set
            {
                datawydania = value;
                NotifyPropertyChanged("Data");
                NotifyPropertyChanged("FormatListy");
            }
        }
        public string FormatListy { get => $"{Tytul} {Autor} {Wydawca} {Nosnik} {DataWydania}"; }
        
    }
}
