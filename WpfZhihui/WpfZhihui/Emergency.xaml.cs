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
using System.Web;
using System.Runtime.Serialization;
using System.IO;
using System.Data;
using System.Runtime.Serialization.Json;

namespace WpfZhihui
{
    /// <summary>
    /// Emergency.xaml 的交互逻辑
    /// </summary>
    public partial class Emergency : Window
    {
        public Emergency()
        {
            InitializeComponent();
            //string path=Directory.GetParent(System.Environment.CurrentDirectory + @"/html.htm").Parent.Parent.ToString();
            //webBrowser1.Navigate(
            //    new Uri(System.Environment.CurrentDirectory + @"/html.htm",
            //        UriKind.RelativeOrAbsolute));//获取根目录的日历文件  
            DirectoryInfo di = new DirectoryInfo(System.Environment.CurrentDirectory);
            string path = di.Parent.Parent.FullName;
            ds = new Basic();
            webBrowser1.Navigate(new Uri(path + @"/html/Emergency.htm", UriKind.RelativeOrAbsolute));//获取根目录的日历文件
            webBrowser1.ObjectForScripting = ds;//该对象可由显示在WebBrowser控件中的网页所包含的脚本代码访问

        }
        public Basic ds;
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]//将该类设置为com可访问
        public class Basic
        {
            public static string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public void ClickEvent(string str)
            {
                int ijudge = 0;
                if (str == "火灾")
                {
                    this.Name = str + "1";
                    ijudge = 1;
                }
                if (str == "突发事件")
                {
                    this.Name = str + "2";
                    ijudge = 2;
                }
            }
        }
    }
}
