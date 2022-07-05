using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3_2.NET
{
    class Model : INotifyPropertyChanged
    {
        public ObservableCollection<Albumy> Lista { get; set; } = new ObservableCollection<Albumy>(new Albumy[]
        {
            new Albumy()
            {
            Tytul = "Black Album",
            Autor = "Metallica",
            Wydawca = "WB",
            Nosnik = "CD",
            DataWydania = DateTime.Parse("10/10/1992")
            },   
            
        });

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void Edytuj(Albumy wybrany)
        {
            Edytowanie szczegoly = new Edytowanie(wybrany);
            szczegoly.Show();
            NotifyPropertyChanged();
        }
        internal void DodajNowy()
        {
            Albumy nowa = new Albumy(){ Autor = "Nieznany", Wydawca = "Nieznany", Nosnik = "Nieznany", Tytul = "Nieznany", DataWydania = DateTime.Parse("1/1/1900") };
            Lista.Add(nowa);
            NotifyPropertyChanged();
        }
    }
}
