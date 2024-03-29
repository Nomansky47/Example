﻿using Example.Data;
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
    public partial class MenuPage : Window
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void Tickets(object sender, RoutedEventArgs e)
        {
            new TicketsShowPage().Show();
        }

        private void Spectacles(object sender, RoutedEventArgs e)
        {
            new ShowPage().Show();
        }
    }
}
