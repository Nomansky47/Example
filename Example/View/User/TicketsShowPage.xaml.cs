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

namespace Example.View.User
{
    /// <summary>
    /// Логика взаимодействия для TicketsShowPage.xaml
    /// </summary>
    public partial class TicketsShowPage : Window
    {
        public TicketsShowPage()
        {
            InitializeComponent();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MyGrid.ItemsSource = null;
            MyGrid.ItemsSource = MyContext.Get().Ticket.ToList();
        }
    }
}
