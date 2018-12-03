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

        int pregunta = 1;
        int correctas = 0;
        int incorrectas = 0;

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

        //Respuestas de la pregunta número 3

        //Respuestas de la pregunta número 4
        private void BotonItalia_Click(object sender, RoutedEventArgs e)
        {
            Pregunta4.Visibility = System.Windows.Visibility.Collapsed;
            RespuestaErronea.Visibility = System.Windows.Visibility.Visible;
        }

        private void BotonEspaña_Click(object sender, RoutedEventArgs e)
        {
            Pregunta4.Visibility = System.Windows.Visibility.Collapsed;
            RespuestaCorrecta.Visibility = System.Windows.Visibility.Visible;
        }

        private void BotonMexico_Click(object sender, RoutedEventArgs e)
        {
            Pregunta4.Visibility = System.Windows.Visibility.Collapsed;
            RespuestaErronea.Visibility = System.Windows.Visibility.Visible;
        }

        //El area que suma las respeustas correctas
        private void BotonSiguiente_Click(object sender, RoutedEventArgs e)
        {
            correctas += 1;
            Avanzador();
        }

        //El area que suma las respeustas incorrectas
        private void BotonSiguiente2_Click(object sender, RoutedEventArgs e)
        {
            incorrectas += 1;
            Avanzador();   
        }

        //Metodo que hace avanzar el juego
        private void Avanzador()
        {
            pregunta += 1;

            if (pregunta == 2)
            {
                RespuestaCorrecta.Visibility = System.Windows.Visibility.Collapsed;
                RespuestaErronea.Visibility = System.Windows.Visibility.Collapsed;
                Pregunta2.Visibility = System.Windows.Visibility.Visible;
            }
            if (pregunta == 3)
            {
                RespuestaCorrecta.Visibility = System.Windows.Visibility.Collapsed;
                RespuestaErronea.Visibility = System.Windows.Visibility.Collapsed;
                Pregunta3.Visibility = System.Windows.Visibility.Visible;
            }
            if (pregunta == 4)
            {
                RespuestaCorrecta.Visibility = System.Windows.Visibility.Collapsed;
                RespuestaErronea.Visibility = System.Windows.Visibility.Collapsed;
                Pregunta4.Visibility = System.Windows.Visibility.Visible;
            }
            if (pregunta == 5)
            {
                RespuestaCorrecta.Visibility = System.Windows.Visibility.Collapsed;
                RespuestaErronea.Visibility = System.Windows.Visibility.Collapsed;
                Pregunta5.Visibility = System.Windows.Visibility.Visible;
            }
            if (pregunta == 6)
            {
                RespuestaCorrecta.Visibility = System.Windows.Visibility.Collapsed;
                RespuestaErronea.Visibility = System.Windows.Visibility.Collapsed;
                MenuFinal.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
