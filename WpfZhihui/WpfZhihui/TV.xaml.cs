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
using System.Windows.Shapes;
using System.IO;

namespace WpfZhihui
{
    /// <summary>
    /// Interaction logic for TV.xaml
    /// </summary>
    public partial class TV : Window
    {
        public TV()
        {
            InitializeComponent();
            //listView1.Items.Add(ListViewItem);
        }
        private void rdDongfangweishi_Checked(object sender, RoutedEventArgs e)
        {
            rdCCTV5.IsChecked = false;
            rdWuxingtiyu.IsChecked = false;
            DirectoryInfo di = new DirectoryInfo(System.Environment.CurrentDirectory);
            string strPath = di.Parent.Parent.FullName;
            webBrowserTV.Navigate(new Uri(strPath + @"/html/zhiboDongfangweishi.htm", UriKind.RelativeOrAbsolute));
        }

        private void rdWuxingtiyu_Checked(object sender, RoutedEventArgs e)
        {
            rdDongfangweishi.IsChecked = false;
            rdCCTV5.IsChecked = false;
            DirectoryInfo di = new DirectoryInfo(System.Environment.CurrentDirectory);
            string strPath = di.Parent.Parent.FullName;
            webBrowserTV.Navigate(new Uri(strPath + @"/html/zhiboWuxingtiyu.htm", UriKind.RelativeOrAbsolute));
        }

        private void rdCCTV5_Checked(object sender, RoutedEventArgs e)
        {
            rdWuxingtiyu.IsChecked = false;
            rdDongfangweishi.IsChecked = false;
            DirectoryInfo di = new DirectoryInfo(System.Environment.CurrentDirectory);
            string strPath = di.Parent.Parent.FullName;
            webBrowserTV.Navigate(new Uri(strPath + @"/html/zhiboCCTV5.htm", UriKind.RelativeOrAbsolute));
        }
    }
}
