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
using System.IO;

namespace ztp_projekt_fiszki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int difficult = 0;
        private int color = 0;

        public MainWindow()
        {
            InitializeComponent();

            /* W settings.txt sa 2 wiersze z 0/1
             *      1. wiersz to poziom trudnosci
             *      2. wiersz to wersja kolorystyczna
             * Wrzucam to do pliku, zeby pamietalo ustawienia przy kolejnych wlaczeniach programu.
             */
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader("settings.txt"))
                {
                    // Read the stream as a string, and write the string to the console.
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Brakuje pliku z ustawieniami:");
                Console.WriteLine(e.Message);
            }
            
            for(int i=0;i<8;i++)
            {
                while (i < 3)
                    if (i == 1) difficult = i;
                while (i > 2)
                    if (i == 1) color = i - 3;
            }


        }

        private void Difficult_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            /* 1. easy
             * 2. medium
             * 3. hard
             */
        }

        private void colorSetter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /* 1. szary
             * 2. rozowy
             * 3. niebieski
             * 4. zielony
             * 5. krejzolski
             */
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            highscore.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;
            gameOver.Visibility = Visibility.Hidden;
        }
    }
}
