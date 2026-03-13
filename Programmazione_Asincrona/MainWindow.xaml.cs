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
            parola += lettera;

            if (parola.Length == 6)
            {
                lstBox.Items.Add(parola);
                parola="";
                
                
            }
            lblParola.Content= parola;
            await Task.Delay(50);
        }

        string parola = "";
        private async void btnStart_Click(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                i = (i + 1) % alfabeto.Length;
                lettera = alfabeto[i];
                lblLabel.Content = lettera;  // Aggiorna la label dove è presente la lettera che gira 
                await Task.Delay(100);
            }
            }

        private void lstBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstBox.Items.Add(parola);
        }

    }
}