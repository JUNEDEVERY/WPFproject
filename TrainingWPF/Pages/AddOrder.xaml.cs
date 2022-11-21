using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Page
    {


        List<ModelDB.Menu> menus = DataBase.tbE.Menu.ToList();
        List<string> str = new List<string>();
        public AddOrder()
        {
            InitializeComponent();

            lVMenu.ItemsSource = str;
            cmbBludo.ItemsSource = menus;
            cmbBludo.SelectedValuePath = "idMenu";
            cmbBludo.DisplayMemberPath = "titile";
        }

        private void cmbBludo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbcount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            str.Add("Блюдо " + cmbBludo.Text + " в количестве " + tb1.Text + " шт.");
            lVMenu.Items.Refresh();
        }
        Regex rx = new Regex(@"\D", RegexOptions.IgnoreCase);
        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            tb1.Text = rx.Replace(tb1.Text, "");
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            str.Remove(lVMenu.SelectedValue.ToString());
            lVMenu.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Zakaz zakaz = new Zakaz()
            {
                idStatus = 2,
                i
            };
            foreach (string str2 in str)
            {
              string[] array =  str2.Split(' '); // 1 // 4
             
            }
           
        }
    }
}


