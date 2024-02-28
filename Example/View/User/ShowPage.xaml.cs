using Example.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Example.View.User
{
    public partial class ShowPage : Window
    {
        public ShowPage()
        {
            InitializeComponent();
            MyGrid.ItemsSource = MyContext.Get().Repertuar.ToList();
        }
        private void Back (object sender, RoutedEventArgs e)
        {
            this.Hide();
            Switcher.PrevPage.Show();
        }

        private void TicketBuy(object sender, RoutedEventArgs e)
        {
            var CurrentPlayID = ((sender as Button).DataContext as Repertuar).PlayID;
            Switcher.PrevPage = this;
            this.Hide();
            new TicketBuyPage(CurrentPlayID).Show();
        }

        private void DateChange(object sender, RoutedEventArgs e)
        {
            var CurrentPlayID = ((sender as Button).DataContext as Repertuar).PlayID;
            Switcher.PrevPage = this;
            this.Hide();
            new DateChangingPage(CurrentPlayID).Show();
        }
    }
}
