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

namespace isrpoLR12
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

        private void LetsgoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text == "1234")
            {
                this.Hide();
                Window1 w1 = new Window1();
                w1.Show();
            }
            else
                MessageBox.Show("Неправильный код(правильный 1234:))");
        }
    }
}

