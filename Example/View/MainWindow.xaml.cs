using Example.Data;
using Example.View;
using Example.View.Admin;
using Example.View.User;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NextPage(object sender, RoutedEventArgs e)
        {
            var user=MyContext.Get().Users.First();
            CurrentUser.UserID = user.UserID;
            Switcher.PrevPage = this;
            new MenuPage().Show();
            this.Hide();
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            var user = MyContext.Get().Users.FirstOrDefault(p => p.Password == Password.Text && p.Login == Login.Text);
            if (user != null)
            {
                CurrentUser.UserID= user.UserID;
                Switcher.PrevPage = this;
                this.Hide();
                if (user.isAdmin)
                {
                    new AdminMenu().Show();
                }
                else
                {
                    new MenuPage().Show();
                }
            }
            else MessageBox.Show("Введен неправильный логин/пароль");
        }
    }
}
