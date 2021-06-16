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

        private int player;
        public MainWindow()
        {
            InitializeComponent();
            player = 1;
            Label1.Content = "Ходит игрок 1";
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
                "WIIIN", MessageBoxButton.OKCancel ,
                MessageBoxImage.Error);
            if (messageBoxResult == MessageBoxResult.OK)
            {
                try
                {
                    Button0.IsEnabled = true;
                    Button1.IsEnabled = true;
                    Button2.IsEnabled = true;
                    Button3.IsEnabled = true;
                    Button4.IsEnabled = true;
                    Button5.IsEnabled = true;
                    Button6.IsEnabled = true;
                    Button7.IsEnabled = true;
                    Button8.IsEnabled = true;
                    Button0.Content = "";
                    Button1.Content = " ";
                    Button2.Content = "  ";
                    Button3.Content = "   ";
                    Button4.Content = "    ";
                    Button5.Content = "     ";
                    Button6.Content = "      ";
                    Button7.Content = "       ";
                    Button8.Content = "        "; /// отвратительно 
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
            switch (player)
            {
                case 1:
                    if (temp == "X")
                        player = 0;
                    Label1.Content = "Ходит игрок 2";
                    break;
                case 0:
                    if (temp == "O")
                        player = 1;
                    Label1.Content = "Ходит игрок 1";
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Najat(Button1);
            switch (player)
            {
                case 1:
                    if (temp == "X")
                        player = 0;
                    Label1.Content = "Ходит игрок 2";
                    break;
                case 0:
                    if (temp == "O")
                        player = 1;
                    Label1.Content = "Ходит игрок 1";
                    break;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Najat(Button2);
            switch (player)
            {
                case 1:
                    if (temp == "X")
                        player = 0;
                    Label1.Content = "Ходит игрок 2";
                    break;
                case 0:
                    if (temp == "O")
                        player = 1;
                    Label1.Content = "Ходит игрок 1";
                    break;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Najat(Button3);
            switch (player)
            {
                case 1:
                    if (temp == "X")
                        player = 0;
                    Label1.Content = "Ходит игрок 2";
                    break;
                case 0:
                    if (temp == "O")
                        player = 1;
                    Label1.Content = "Ходит игрок 1";
                    break;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Najat(Button4);
            switch (player)
            {
                case 1:
                    if (temp == "X")
                        player = 0;
                    Label1.Content = "Ходит игрок 2";
                    break;
                case 0:
                    if (temp == "O")
                        player = 1;
                    Label1.Content = "Ходит игрок 1";
                    break;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Najat(Button5);
            switch (player)
            {
                case 1:
                    if (temp == "X")
                        player = 0;
                    Label1.Content = "Ходит игрок 2";
                    break;
                case 0:
                    if (temp == "O")
                        player = 1;
                    Label1.Content = "Ходит игрок 1";
                    break;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Najat(Button6);
            switch (player)
            {
                case 1:
                    if (temp == "X")
                        player = 0;
                    Label1.Content = "Ходит игрок 2";
                    break;
                case 0:
                    if (temp == "O")
                        player = 1;
                    Label1.Content = "Ходит игрок 1";
                    break;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Najat(Button7);
            switch (player)
            {
                case 1:
                    if (temp == "X")
                        player = 0;
                    Label1.Content = "Ходит игрок 2";
                    break;
                case 0:
                    if (temp == "O")
                        player = 1;
                    Label1.Content = "Ходит игрок 1";
                    break;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Najat(Button8);
            switch (player)
            {
                case 1:
                    if (temp == "X")
                        player = 0;
                    Label1.Content = "Ходит игрок 2";
                    break;
                case 0:
                    if (temp == "O")
                        player = 1;
                    Label1.Content = "Ходит игрок 1";
                    break;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            _4 taskWindow = new _4();
            taskWindow.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Button0.IsEnabled = true;
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;
            Button0.Content = "";
            Button1.Content = " ";
            Button2.Content = "  ";
            Button3.Content = "   ";
            Button4.Content = "    ";
            Button5.Content = "     ";
            Button6.Content = "      ";
            Button7.Content = "       ";
            Button8.Content = "        "; /// отвратительно 
        }
    }
}
