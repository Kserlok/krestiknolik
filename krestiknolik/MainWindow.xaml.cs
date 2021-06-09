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

namespace krestiknolik 
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string temp = "X";

        public MainWindow()
        {
            InitializeComponent();
        }

        bool WinLose()
        {
            if (Button0.Content == Button1.Content && Button2.Content == Button1.Content)
            {
                return true;
            }

            else if (Button0.Content == Button3.Content && Button3.Content == Button6.Content)
            {
                return true;
            }

            else if (Button0.Content == Button4.Content && Button4.Content == Button8.Content)
            {
                return true;
            }

            else if (Button1.Content == Button4.Content && Button4.Content == Button7.Content)
            {
                return true;
            }

            else if (Button3.Content == Button4.Content && Button4.Content == Button5.Content)
            {
                return true;
            }

            else if (Button6.Content == Button4.Content && Button6.Content == Button2.Content)
            {
                return true;
            }

            else if (Button6.Content == Button7.Content && Button7.Content == Button8.Content)
            {
                return true;
            }

            else if (Button2.Content == Button5.Content && Button2.Content == Button8.Content)
            {
                return true;
            }

            return false;
        }

        void Win()
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("ВОТ ЭТО " + temp + " КЛАССНЫЕ ПАЦАНЫ", 
                "WIIIN", MessageBoxButton.OKCancel,
                MessageBoxImage.Error);
            if (messageBoxResult == MessageBoxResult.OK)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
       void Najat (Button button)
       {
            button.Content = temp;
            button.IsEnabled = false;

            if (WinLose())
            {
                Win();
                return;
            }

            if (temp == "X") temp = "O";
            else if (temp == "O") temp = "X";

       }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Najat(Button0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Najat(Button1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Najat(Button2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Najat(Button3);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Najat(Button4);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Najat(Button5);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Najat(Button6);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Najat(Button7);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Najat(Button8);
        }
    }
}
