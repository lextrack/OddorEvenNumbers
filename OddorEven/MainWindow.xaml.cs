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

namespace OddorEven
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

        private void BtnIngreso_Click(object sender, RoutedEventArgs e)
        {
            Operaciones ObjetoEvaluar = new Operaciones();
            try
            {
                BtnIngreso.ContentStringFormat = Convert.ToString(ObjetoEvaluar.Primos(Convert.ToInt64(numero.Text)));
            }
            catch (Exception)
            {

                MessageBox.Show("You can't enter letters, symbols or left the TextBox blank.", "Error");
            }

        }

        private void numero_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
