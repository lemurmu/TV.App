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

namespace TV.App.Pages
{
    /// <summary>
    /// Setting_Page.xaml 的交互逻辑
    /// </summary>
    public partial class Setting_Page : UserControl
    {
        public Setting_Page() {
            InitializeComponent();
        }

        private MainWindow window;

        private void LoadWindow() {
            if(window == null) {
                window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
            }
        }

        private void Element_ElementClick(object sender, RoutedEventArgs e) {
            LoadWindow();
            window.ExecutePage(AppPages.Network);
        }

        private void Element_ElementClick1(object sender, RoutedEventArgs e) {
            LoadWindow();
            window.ExecutePage(AppPages.Time);
        }

        private void Element_ElementClick2(object sender, RoutedEventArgs e) {
            LoadWindow();
            window.ExecutePage(AppPages.Storage);
        }

        private void Element_ElementClick3(object sender, RoutedEventArgs e) {
            LoadWindow();
            window.ExecutePage(AppPages.About);
        }
    }
}
