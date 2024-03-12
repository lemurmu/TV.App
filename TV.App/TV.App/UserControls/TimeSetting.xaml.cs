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

namespace TV.App.UserControls
{
    /// <summary>
    /// TimeSetting.xaml 的交互逻辑
    /// </summary>
    public partial class TimeSetting : UserControl
    {
        public TimeSetting() {
            InitializeComponent();
        }

        public string Title {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(TimeSetting), new PropertyMetadata(""));



        public string Text {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TimeSetting), new PropertyMetadata(""));



        public bool HasToggle {
            get { return (bool)GetValue(HasToggleProperty); }
            set { SetValue(HasToggleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HasToggle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasToggleProperty =
            DependencyProperty.Register("HasToggle", typeof(bool), typeof(TimeSetting), new PropertyMetadata(false));



        public bool HasText {
            get { return (bool)GetValue(HasTextProperty); }
            set { SetValue(HasTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HasText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasTextProperty =
            DependencyProperty.Register("HasText", typeof(bool), typeof(TimeSetting), new PropertyMetadata(false));



        public bool IsChecked {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(TimeSetting), new PropertyMetadata(false));




    }
}
