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

namespace Example.View.User
{
    /// <summary>
    /// Логика взаимодействия для DateChangingPage.xaml
    /// </summary>
    public partial class DateChangingPage : Window
    {
        public int _id { get; set; }
        public DateChangingPage(int id)
        {
            _id = id;
            InitializeComponent();
            DateText.Text = MyContext.Get().Repertuar.FirstOrDefault(p => p.PlayID == id).RDate.ToString();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            var changing = MyContext.Get().Repertuar.FirstOrDefault(p=>p.PlayID==_id);
            changing.RDate=DateTime.Parse(DateText.Text);
            MyContext.Get().SaveChanges();
            Switcher.PrevPage.Show();
            this.Hide();
        }
    }
}
