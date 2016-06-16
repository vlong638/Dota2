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

namespace DOTA2DataManager
{
    /// <summary>
    /// DataCreator.xaml 的交互逻辑
    /// </summary>
    public partial class DataCreator : Window
    {
        public DataCreator()
        {
            InitializeComponent();
            
        }

        private void AddTeam(object sender, RoutedEventArgs e)
        {
            var name = tb_TeamName.Text;
            var nameAbbr = tb_TeamNameAbbr.Text;
            var mmr = int.Parse(tb_MMR.Text);
            var result = Facade.CreateTeam(name, nameAbbr, mmr);
            MessageBox.Show(result.Message);
        }
        private void AddPlayer(object sender, RoutedEventArgs e)
        {
            var name = tb_TeamName.Text;
            var nameAbbr = tb_TeamNameAbbr.Text;
            var result = Facade.CreatePlayer(name, nameAbbr);
            MessageBox.Show(result.Message);
        }
    }
}
