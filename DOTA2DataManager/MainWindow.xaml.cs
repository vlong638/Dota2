using System.Linq;
using System.Windows;

namespace DOTA2DataManager
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var result = Facade.DataCotext.InitForService();
            var message = string.Join("\r\n", result.DependencyDetails.Select(c => c.Message));
            MessageBox.Show(message);
        }
        private void OpenDataCreator(object sender, RoutedEventArgs e)
        {
            new DataCreator().Show();
        }
        private void OpenDataList(object sender, RoutedEventArgs e)
        {
            new DataList().Show();
        }
    }
}
