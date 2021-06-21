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
using System.Windows.Shapes;

namespace krestiknolik
{
    /// <summary>
    /// Логика взаимодействия для Bot.xaml
    /// </summary>
    public partial class Bot : Window
    {


        string temp = "X";
        int[] array = new int[9];
        Random random = new Random();   
        Button[] button = new Button[9];



        public Bot()
        {
            InitializeComponent();
           
            button[0] = Button11;
            button[1] = Button12;
            button[2] = Button13;
            button[3] = Button14;
            button[4] = Button15;
            button[5] = Button16;
            button[6] = Button17;
            button[7] = Button18;
            button[8] = Button19; 
        }

        void BotHod(Random random)
        {
            //gbpltw
            //это была провальная попытка написать бота, чоооорт 
        }
        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            if (temp == "X")
            {
                for (int i = 0; i < button.Length; i++)
                {
                    if (sender == button[i])
                    {
                        button[i].Content = "X";
                        temp = "0";
                        button[i].IsEnabled = false;
                        array[i] = 1;
                        break;
                    }
                }
            }

            if (array[0] == 1 && array[1] == 1 && array[2] == 1)
            {
                button[0].Content = "ты лох";
                button[1].Content = "ты лох";
                button[2].Content = "ты лох";
            }

            for (int i = 0; i < button.Length; i++)
            {
                button[i].IsEnabled = false;
            }
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
   
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button15_Click(object sender, RoutedEventArgs e)
        {
 
        }

        private void Button16_Click(object sender, RoutedEventArgs e)
        {
 
        }

        private void Button17_Click(object sender, RoutedEventArgs e)
        {
      
        }

        private void Button18_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button19_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
