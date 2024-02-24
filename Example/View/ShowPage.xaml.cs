using Example.Data;
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

namespace Example.View
{
    /// <summary>
    /// Логика взаимодействия для ShowPage.xaml
    /// </summary>
    public partial class ShowPage : Window
    {
        public ShowPage()
        {
            InitializeComponent();
            MyGrid.ItemsSource = MyContext.Get().Play.ToList();
        }
        private void Back (object sender, RoutedEventArgs e)
        {
            this.Hide();
            Switcher.PrevPage.Show();
        }
    }
}
