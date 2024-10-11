using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lotto
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("De 6 Lotto getallen zijn: ");
            sb.AppendLine("");
            Random numberGen = new Random();

            for (int i = 1; i < 7; i++)
            {
                int randomNr = numberGen.Next(0, 46);
                string result = $"Getal {i} is {randomNr}";
                sb.AppendLine(result);

            }
            resultTextbox.Text = sb.ToString();
        }
    }
}