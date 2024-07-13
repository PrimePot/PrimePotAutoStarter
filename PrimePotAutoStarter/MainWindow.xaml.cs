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

namespace PrimePotAutoStarter {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e) {
            ShortCutCreator shortCutCreator = new ShortCutCreator();
            shortCutCreator.Create();
            System.Windows.Application.Current.Shutdown();
        }

        private void No_Click(object sender, RoutedEventArgs e) {
            System.Windows.Application.Current.Shutdown();
        }
    }
}