﻿using System;
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
            lVMenu.ItemsSource = DataBase.tbE.Zakaz.ToList();

        }
    }
}
