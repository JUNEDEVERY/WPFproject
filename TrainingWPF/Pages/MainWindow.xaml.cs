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
using TrainingWPF.ModelDB;

namespace TrainingWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            DataBase.tbE = new Entities1();
            FrameWork.MainFrame = fMain;
            FrameWork.MainFrame.Navigate(new AdminPage());
        }

      

        private void fMain_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
          
        }

       
    }
}
