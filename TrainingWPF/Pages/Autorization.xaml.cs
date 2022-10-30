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
using TrainingWPF.ModelDB;
using TrainingWPF.Pages;

namespace TrainingWPF
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
            DataBase.tbE = new Entities1();
           
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameWork.MainFrame.Navigate(new AdminPage());
        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {

            string p = Convert.ToString(tbpass.Password.GetHashCode());
            Users users = DataBase.tbE.Users.FirstOrDefault(x => x.Login == tblog.Text && x.Password ==p);
            if(users != null)
            {
                if(users.idRole == 1)
                {
                    // admin - gerasimov 22!Aaaaa
                    NavigationService.Navigate(new AdminPage2());
                }
                else
                {
                    MessageBox.Show("Приветик, друг");
                    NavigationService.Navigate(new ShowMenu());
                }
               
            }

        }

        private void btngoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }
    }
}
