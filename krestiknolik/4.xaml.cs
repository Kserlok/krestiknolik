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
    /// Логика взаимодействия для _4.xaml
    /// </summary>
    public partial class _4 : Window
    {
        string temp = "X";
        private int WinSchet;
        public _4()
        {
            InitializeComponent();
        }

        void Najat(Button button)
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

        void Win()
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("ВОТ ЭТО " + temp + " КЛАССНЫЕ ПАЦАНЫ",
                "WIIIN", MessageBoxButton.OKCancel,
                MessageBoxImage.Error);
            if (messageBoxResult == MessageBoxResult.OK)
            {
                try
                {
                    ButtonA.IsEnabled = true; ButtonA.Content = " ";
                    ButtonB.IsEnabled = true; ButtonB.Content = "  ";
                    ButtonC.IsEnabled = true; ButtonC.Content = "   ";
                    ButtonD.IsEnabled = true; ButtonD.Content = "    ";
                    ButtonE.IsEnabled = true; ButtonE.Content = "     ";
                    ButtonF.IsEnabled = true; ButtonF.Content = "      ";
                    ButtonG.IsEnabled = true; ButtonG.Content = "       ";
                    ButtonH.IsEnabled = true; ButtonH.Content = "        ";
                    ButtonI.IsEnabled = true; ButtonI.Content = "         ";
                    ButtonJ.IsEnabled = true; ButtonJ.Content = "          ";
                    ButtonK.IsEnabled = true; ButtonK.Content = "           ";
                    ButtonL.IsEnabled = true; ButtonL.Content = "            ";
                    ButtonM.IsEnabled = true; ButtonM.Content = "             ";
                    ButtonN.IsEnabled = true; ButtonN.Content = "              ";
                    ButtonO.IsEnabled = true; ButtonO.Content = "               ";
                    ButtonP.IsEnabled = true; ButtonP.Content = "                ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Button_Click_A(object sender, RoutedEventArgs e)
        {
            Najat(ButtonA);
        }

        private void Button_Click_B(object sender, RoutedEventArgs e)
        {
            Najat(ButtonB);
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            Najat(ButtonC);
        }

        private void Button_Click_D(object sender, RoutedEventArgs e)
        {
            Najat(ButtonD);
        }

        private void Button_Click_E(object sender, RoutedEventArgs e)
        {
            Najat(ButtonE);
        }

        private void Button_Click_F(object sender, RoutedEventArgs e)
        {
            Najat(ButtonF);
        }

        private void Button_Click_G(object sender, RoutedEventArgs e)
        {
            Najat(ButtonG);
        }

        private void Button_Click_H(object sender, RoutedEventArgs e)
        {
            Najat(ButtonH);
        }

        private void Button_Click_I(object sender, RoutedEventArgs e)
        {
            Najat(ButtonI);
        }

        private void Button_Click_J(object sender, RoutedEventArgs e)
        {
            Najat(ButtonJ);
        }

        private void Button_Click_K(object sender, RoutedEventArgs e)
        {
            Najat(ButtonK);
        }

        private void Button_Click_L(object sender, RoutedEventArgs e)
        {
            Najat(ButtonL);
        }

        private void Button_Click_M(object sender, RoutedEventArgs e)
        {
            Najat(ButtonM);
        }

        private void Button_Click_N(object sender, RoutedEventArgs e)
        {
            Najat(ButtonN);
        }

        private void Button_Click_O(object sender, RoutedEventArgs e)
        {
            Najat(ButtonO);
        }

        private void Button_Click_P(object sender, RoutedEventArgs e)
        {
            Najat(ButtonP);
        }
        bool WinLose()
        {
            if (ButtonA.Content == ButtonB.Content && ButtonB.Content == ButtonC.Content && ButtonC.Content == ButtonD.Content)
            {
                return true;

            }

            else if (ButtonE.Content == ButtonF.Content && ButtonF.Content == ButtonG.Content && ButtonG.Content == ButtonH.Content)
            {
                return true;
            }

            else if (ButtonI.Content == ButtonJ.Content && ButtonJ.Content == ButtonK.Content && ButtonK.Content == ButtonL.Content)
            {
                return true;
            }

            else if (ButtonM.Content == ButtonN.Content && ButtonN.Content == ButtonO.Content && ButtonO.Content == ButtonP.Content)
            {
                return true;
            }

            else if (ButtonA.Content == ButtonE.Content && ButtonE.Content == ButtonI.Content && ButtonI.Content == ButtonM.Content)
            {
                return true;
            }

            else if (ButtonB.Content == ButtonF.Content && ButtonF.Content == ButtonJ.Content && ButtonJ.Content == ButtonN.Content)
            {
                return true;
            }

            else if (ButtonC.Content == ButtonG.Content && ButtonG.Content == ButtonK.Content && ButtonK.Content == ButtonO.Content)
            {
                return true;
            }

            else if (ButtonE.Content == ButtonF.Content && ButtonF.Content == ButtonG.Content && ButtonG.Content == ButtonH.Content)
            {
                return true;
            }

            else if (ButtonD.Content == ButtonH.Content && ButtonH.Content == ButtonL.Content && ButtonL.Content == ButtonP.Content)
            {
                return true;
            }

            else if (ButtonA.Content == ButtonF.Content && ButtonF.Content == ButtonK.Content && ButtonK.Content == ButtonP.Content)
            {
                return true;
            }

            else if (ButtonD.Content == ButtonG.Content && ButtonG.Content == ButtonJ.Content && ButtonJ.Content == ButtonM.Content)
            {
                return true;
            }

            return false;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ButtonA.IsEnabled = true; ButtonA.Content = " ";
            ButtonB.IsEnabled = true; ButtonB.Content = "  ";
            ButtonC.IsEnabled = true; ButtonC.Content = "   ";
            ButtonD.IsEnabled = true; ButtonD.Content = "    ";
            ButtonE.IsEnabled = true; ButtonE.Content = "     ";
            ButtonF.IsEnabled = true; ButtonF.Content = "      ";
            ButtonG.IsEnabled = true; ButtonG.Content = "       ";
            ButtonH.IsEnabled = true; ButtonH.Content = "        ";
            ButtonI.IsEnabled = true; ButtonI.Content = "         ";
            ButtonJ.IsEnabled = true; ButtonJ.Content = "          ";
            ButtonK.IsEnabled = true; ButtonK.Content = "           ";
            ButtonL.IsEnabled = true; ButtonL.Content = "            ";
            ButtonM.IsEnabled = true; ButtonM.Content = "             ";
            ButtonN.IsEnabled = true; ButtonN.Content = "              ";
            ButtonO.IsEnabled = true; ButtonO.Content = "               ";
            ButtonP.IsEnabled = true; ButtonP.Content = "                ";
        }
    }
}
