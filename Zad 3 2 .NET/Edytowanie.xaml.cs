using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Zad_3_2.NET
{
    /// <summary>
    /// Logika interakcji dla klasy Edytowanie.xaml
    /// </summary>
    public partial class Edytowanie : Window
    {
        Albumy albumy;
        public Edytowanie(Albumy albumy)
        {
            this.albumy = albumy;
            DataContext = albumy;
            InitializeComponent();
        }

        private void Zamknij(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
