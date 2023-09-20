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

namespace test2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void OpenAutor(object sender, RoutedEventArgs e)
        {
            Autor objAutor = new Autor();
            this.Visibility = Visibility.Hidden;
            objAutor.Show();

        }

        private void RegClick(object sender, RoutedEventArgs e)
        {
            string log = login.Text;
            string pas = pass.Password;
            string proo = proof.Password;

            if (log.Length < 5)
            {
                login.ToolTip = "мало символов!";
                login.BorderBrush = Brushes.Red;
            }
            else
            {
                login.ToolTip = "Все хорошо!";
                login.BorderBrush = Brushes.LimeGreen;
            }
            if (pas.Length < 5)
            {
                pass.ToolTip = "мало символов!";
                pass.BorderBrush = Brushes.Red;
            }
            else
            {
                pass.ToolTip = "Все хорошо!";
                pass.BorderBrush = Brushes.LimeGreen;
            }
            if (proo != pas)
            {
                proof.ToolTip = "неверный пароль!";
                proof.BorderBrush = Brushes.Red;
            }
            else
            {
                proof.ToolTip = "Все хорошо!";
                proof.BorderBrush = Brushes.LimeGreen;
            }
        }
    }
}
