using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPFTest.UI.Menu
{
    /// <summary>
    /// MenuPageChapter9.xaml 的交互逻辑
    /// </summary>
    public partial class MenuPageChapter9 : ChildPage
    {
        public MenuPageChapter9()
        {
            InitializeComponent();
        }

        private void ChildPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            FireNextEvent("chapter9_sy2");
        }

        private void file_Click_1(object sender, RoutedEventArgs e)
        {
            FireNextEvent("chapter9_sy1");
        }

        private void excel_Click_1(object sender, RoutedEventArgs e)
        {
            FireNextEvent("chapter9_sy2");
        }

        private void ado_Click_1(object sender, RoutedEventArgs e)
        {
            FireNextEvent("chapter9_sy3");
        }
    }
}
