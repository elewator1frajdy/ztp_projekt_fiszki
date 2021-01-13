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

namespace ztp_projekt_fiszki
{
    class Strategia
    {
        private int difficult;      // 0-easy 1-medium 2-hard

        public Strategia(int difficult)
        {
            this.difficult = difficult;
        }

        /*private void nauka()
        {
            if (this.difficult == 0)
                MainWindow.questionNumEasy.Visibility = Visibility.Hidden;
            else if (this.difficult == 1)
                MainWindow.questionNumMedium.Visibility = Visibility.Visible;
            else if (this.difficult == 2)
                MainWindow.questionNumHard.Visibility = Visibility.Visible;
        }

        private void test()
        {
            if (this.difficult == 0)
                MainWindow.questionNumEasy.Visibility = Visibility.Hidden;
            else if (this.difficult == 1)
                MainWindow.questionNumMedium.Visibility = Visibility.Hidden;
            else if (this.difficult == 2)
                MainWindow.questionNumHard.Visibility = Visibility.Hidden;
        }*/
    }
}
