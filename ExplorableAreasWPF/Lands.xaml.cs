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

namespace ExplorableAreasWPF
{
    /// <summary>
    /// Interaction logic for Lands.xaml
    /// </summary>
    public partial class Lands : Page
    {
        public Lands()
        {
            InitializeComponent();
        }

        private void bt_Uno_Click(object sender, RoutedEventArgs e)
        {
            switch(bt_Uno.Content)
            {
                case "Lake":
                    img_Background.Source = new BitmapImage(new Uri("Lake.png", UriKind.Relative));
                    bt_Uno.Content = "Beach";
                    bt_Dous.Content = "Mountain";
                    break;
                case "Beach":
                    img_Background.Source = new BitmapImage(new Uri("Beach.png", UriKind.Relative));
                    bt_Uno.Content = "Lake";
                    bt_Dous.Content = "Mountain";
                    break;
                case "Mountain":
                    img_Background.Source = new BitmapImage(new Uri("Mountains.png", UriKind.Relative));
                    bt_Uno.Content = "Beach";
                    bt_Dous.Content = "Lake";
                    break;
            }
        }

        private void bt_Dous_Click(object sender, RoutedEventArgs e)
        {
            switch (bt_Dous.Content)
            {
                case "Lake":
                    img_Background.Source = new BitmapImage(new Uri("Lake.png", UriKind.Relative));
                    bt_Uno.Content = "Beach";
                    bt_Dous.Content = "Mountain";
                    break;
                case "Beach":
                    img_Background.Source = new BitmapImage(new Uri("Beach.png", UriKind.Relative));
                    bt_Uno.Content = "Lake";
                    bt_Dous.Content = "Mountain";
                    break;
                case "Mountain":
                    img_Background.Source = new BitmapImage(new Uri("Mountains.png", UriKind.Relative));
                    bt_Uno.Content = "Lake";
                    bt_Dous.Content = "Beach";
                    break;
            }
        }
    }
}
