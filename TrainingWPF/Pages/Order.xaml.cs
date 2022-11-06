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

namespace TrainingWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Page
    {
        public Order()
        {
            InitializeComponent();
            DataBase.tbE = new Entities22();
          
            //lVMenu.ItemsSource = DataBase.tbE.Zakaz.ToList();
            //lVMenu.ItemsSource = DataBase.tbE.Users.ToList();
            
           // lVMenu.ItemsSource = DataBase.tbE.Zakaz.tO(x => x.Status).ToList();
        }
    }
}
