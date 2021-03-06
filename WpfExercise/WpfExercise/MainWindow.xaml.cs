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
using WpfExercise.ViewModels;

namespace WpfExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Stop using camera.
            MyVideoSourceViewModel.StopVideoSource();
        }


        private void CntClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
