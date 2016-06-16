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
    /// DataList.xaml 的交互逻辑
    /// </summary>
    public partial class DataList : Window
    {
        public DataList()
        {
            InitializeComponent();
            
        }

        private void ViewTeams(object sender, MouseButtonEventArgs e)
        {
            LoadTeams();
        }

        private void RefreshTeam(object sender, RoutedEventArgs e)
        {
            LoadTeams();
        }
        private void DeleteTeam(object sender, RoutedEventArgs e)
        {

        }
        private void LoadTeams()
        {
            var result = Facade.SelectTeams();
            if (result.ResultCode == VL.Common.Protocol.IService.EResultCode.Success)
            {
                Grid_Team.DataContext= result.SubResultCode;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void ViewPlayers(object sender, MouseButtonEventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            var result = Facade.SelectPlayers();
            if (result.ResultCode == VL.Common.Protocol.IService.EResultCode.Success)
            {
                Grid_Team.ItemsSource = result.SubResultCode;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
