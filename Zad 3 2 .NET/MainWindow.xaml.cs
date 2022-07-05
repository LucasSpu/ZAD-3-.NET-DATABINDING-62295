using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zad_3_2.NET
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        Model Lista = new Model();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = Lista;
        }


        private void Dodaj(object sender, RoutedEventArgs e)
        {
            Lista.DodajNowy();
            
        }

        private void Edytuj(object sender, RoutedEventArgs e)
        {
            FrameworkElement parent = (FrameworkElement)((FrameworkElement)sender).Parent;
            ListBox lista = (ListBox)parent.FindName("ListaDoWybrania");
            Albumy wybrany = (Albumy)lista.SelectedItem;
            if (wybrany != null)
            {
                Lista.Edytuj(wybrany);
            }
        }
    }
}
