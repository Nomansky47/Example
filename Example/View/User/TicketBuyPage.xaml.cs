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

    public partial class TicketBuyPage : Window
    {
        private int _id { get; set; }
        public TicketBuyPage(int id)
        {
            _id= id;
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (Trow.Text != "" && Tseat.Text != "" && Trow.Text != null && Tseat.Text != null)
            {
                CardNumber.Text = "";
                var ticket = new Ticket();
                ticket.TCost = 1000;
                ticket.PlayID = _id;
                ticket.TRow = int.Parse(Trow.Text);
                ticket.TSeat = int.Parse(Tseat.Text);
                ticket.TDate = MyContext.Get().Repertuar.FirstOrDefault(p => p.PlayID == _id).RDate;
                if (MyContext.Get().Ticket.FirstOrDefault(p => p.TRow == ticket.TRow&&p.TSeat==ticket.TSeat&&p.PlayID==_id&&p.TDate==ticket.TDate) == null)
                {
                    try
                    {
                        MyContext.Get().Ticket.Add(ticket);
                        MyContext.Get().SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Возникла какая-то ошибка!");
                    }
                } else MessageBox.Show("Билет с такими данными уже забронирован на данный спектакль и дату! Введите другие данные");
            }
            else MessageBox.Show("Введите данные");
            MessageBox.Show("Успешно");
            Switcher.PrevPage.Show();
            this.Hide();
    }
    }
}
