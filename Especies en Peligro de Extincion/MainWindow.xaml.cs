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

namespace Especies_en_Peligro_de_Extincion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonJugar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal.Visibility = System.Windows.Visibility.Collapsed;
            Pregunta1.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
