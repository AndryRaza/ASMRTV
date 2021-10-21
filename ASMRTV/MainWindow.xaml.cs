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

namespace ASMRTV
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

  
        private void navigate(string url)
        {
            //Uri uri = new Uri(url, UriKind.RelativeOrAbsolute);
            //tvBrowser.Navigate(uri);

            string page =
                "<html>"
                + "<head><meta http-equiv='X-UA-Compatible' content='IE=11' />"
                + "<body>" + "\r\n"
                + "<iframe width=\"750\" height=\"310\" src=\""+ url + "\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard - write; encrypted - media; gyroscope; picture -in-picture\"></iframe>"
                + "</body></html>";
            tvBrowser.NavigateToString(page);
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            navigate(@"https://www.youtube.com/embed/DjH7CX9IlKU");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            navigate(@"https://www.youtube.com/embed/FvIAmOI96bc");
       
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            navigate(@"https://www.youtube.com/embed/5mdBDAPD4RU");
        }
    }
}
