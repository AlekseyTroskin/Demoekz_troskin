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
using Demoekz_Troskin.AppDataFile;

namespace Demoekz_Troskin.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageClients());
        }

        private void btnModel_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageModel());
        }

        private void btnPostavchiki_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PagePostavchiki());
        }

        private void btnAddClient_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageAddClient());
        }

        private void btnAddModel_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageAddModel());
        }

        private void btnAddPostavchik_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageAddPostavchik());
        }
    }
}
