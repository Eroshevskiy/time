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

namespace test2
{
    /// <summary>
    /// Логика взаимодействия для Autor.xaml
    /// </summary>
    public partial class Autor : Window
    {
        public Autor()
        {
            InitializeComponent();
        }

        private void Openmain(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();
        }

        private void vhodClick(object sender, RoutedEventArgs e)
        {
            string log = login.Text;
            string pas = pass.Password;


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
            

        }
    }
}
