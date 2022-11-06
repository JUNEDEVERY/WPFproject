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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrainingWPF.ModelDB;
using TrainingWPF.Pages;

namespace TrainingWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShowMenu.xaml
    /// </summary>
    public partial class ShowMenu : Page
    {
        public ShowMenu()
        {
            InitializeComponent();
            lVMenu.ItemsSource = DataBase.tbE.Menu.ToList();
        }

        private void addMenu_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int id = Convert.ToInt32(btn.Tag);
            ModelDB.Menu menu = DataBase.tbE.Menu.FirstOrDefault(x => x.idMenu == id);
            MessageBox.Show("Вы выбрали \"" + menu.titile + "\", но я еще не реализовал корзину(");
        }
    }


}



