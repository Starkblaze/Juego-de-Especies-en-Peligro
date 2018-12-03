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

        //Inicializar el juego
        private void BotonJugar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal.Visibility = System.Windows.Visibility.Collapsed;
            Pregunta1.Visibility = System.Windows.Visibility.Visible;
        }

        //Respuestas de la pregunta número 1
        private void BotonCazador_Click(object sender, RoutedEventArgs e)
        {
            Pregunta1.Visibility = System.Windows.Visibility.Collapsed;
            RespuestaCorrecta.Visibility = System.Windows.Visibility.Visible;
        }

        private void BotonBasura_Click(object sender, RoutedEventArgs e)
        {
            Pregunta1.Visibility = System.Windows.Visibility.Collapsed;
            RespuestaErronea.Visibility = System.Windows.Visibility.Visible;
        }

        private void BotonHacha_Click(object sender, RoutedEventArgs e)
        {
            Pregunta1.Visibility = System.Windows.Visibility.Collapsed;
            RespuestaErronea.Visibility = System.Windows.Visibility.Visible;
        }

        //Respuestas de la pregunta número 2
        private void Boton300_Click(object sender, RoutedEventArgs e)
        {
            Pregunta2.Visibility = System.Windows.Visibility.Collapsed;
            RespuestaErronea.Visibility = System.Windows.Visibility.Visible;
        }

        private void Boton582_Click(object sender, RoutedEventArgs e)
        {
            Pregunta2.Visibility = System.Windows.Visibility.Collapsed;
            RespuestaErronea.Visibility = System.Windows.Visibility.Visible;
        }

        private void Boton1131_Click(object sender, RoutedEventArgs e)
        {
            Pregunta2.Visibility = System.Windows.Visibility.Collapsed;
            RespuestaCorrecta.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
