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
    /// Interaction logic for WeatherReport.xaml
    /// </summary>
    public partial class WeatherReport : Window
    {
        public WeatherReport()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WeatherWebService.WeatherWebServiceSoapClient ws = new WeatherWebService.WeatherWebServiceSoapClient();
            string[] strWeather = ws.getWeatherbyCityName("上海");
            DirectoryInfo di = new DirectoryInfo(System.Environment.CurrentDirectory);
            string strPath = di.Parent.Parent.FullName;
            BitmapImage image = new BitmapImage(new Uri(strPath + @"/weatherlogo/a_" + strWeather[8], UriKind.RelativeOrAbsolute));
            image1.Source = image;
            label1.Content = strWeather[6];
            label2.Content = strWeather[10].Split('；');
        }

        
    }
}
