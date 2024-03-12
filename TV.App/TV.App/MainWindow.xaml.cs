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

namespace TV.App
{

    public enum AppPages
    {
        About, Settting, Storage, Time, Network
    }


    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        private Pages.Setting_Page _settingPage = new Pages.Setting_Page();
        private Pages.About_Page _aboutPage = new Pages.About_Page();
        private Pages.Storage_Page _storagePage = new Pages.Storage_Page();
        private Pages.Time_Page _timePage = new Pages.Time_Page();
        private Pages.NetworkPage _networkPage = new Pages.NetworkPage();

        private bool IsMaximized = false;

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if (e.ClickCount == 2) {
                if (IsMaximized) {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1280;
                    this.Height = 780;

                    IsMaximized = false;
                }
                else {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ChangedButton == MouseButton.Left) {
                this.DragMove();
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e) {
            container.Content = _settingPage;
            backBtn.Visibility = Visibility.Collapsed;
            titleTxt.Text = "Settings";
        }

        public void ExecutePage(AppPages page) {
            backBtn.Visibility = Visibility.Visible;

            switch (page) {
                case AppPages.About:
                    container.Content = _aboutPage;
                    titleTxt.Text = "About Us";
                    break;
                case AppPages.Settting:
                    container.Content = _settingPage;
                    titleTxt.Text = "Settings";
                    break;
                case AppPages.Storage:
                    container.Content = _storagePage;
                    titleTxt.Text = "Storage";
                    break;
                case AppPages.Time:
                    container.Content = _timePage;
                    titleTxt.Text = "Time Settings";
                    break;
                case AppPages.Network:
                    container.Content = _networkPage;
                    titleTxt.Text = "Network Settings";
                    break;
                default:
                    break;
            }
        }
    }
}
