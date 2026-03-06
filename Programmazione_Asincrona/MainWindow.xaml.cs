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

namespace Programmazione_Asincrona
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

        string[] alfabeto = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "Z", "X", "Y","Z" };
        int i = 0;
        string lettera = "";
        private async void btnEstrai_Click(object sender, RoutedEventArgs e)
        {
            parola.Add(lettera);
            lblParola.Content = parola;
            await Task.Delay(100);
        }

        List<string> parola = new List<string>();
        private async void btnStart_Click(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                if (i == 26)
                {
                    i = -1;
                }
                i++;
                lettera = alfabeto[i];
                lblLabel.Content = lettera;
                await Task.Delay(100);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}