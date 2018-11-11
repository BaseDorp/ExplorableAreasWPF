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
using System.Windows.Threading;

namespace ExplorableAreasWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Forward = true;
        bool flipflop = true;

        public MainWindow()
        {
            InitializeComponent();

            // Creating Timer for Changing Background
            DispatcherTimer ColorTimer = new System.Windows.Threading.DispatcherTimer();
            ColorTimer.Tick += new EventHandler(ChangeColor);
            DispatcherTimer MenuTimer = new System.Windows.Threading.DispatcherTimer();
            MenuTimer.Tick += new EventHandler(MenuText);

            // Setting Intervals of Timers
            MenuTimer.Interval = new TimeSpan(0, 0, 1);

            // Creating Timers
            MenuTimer.Start();
            ColorTimer.Start();

            GradientStop.Offset = 0.0;
        }

        void MenuText(object sender, EventArgs e)
        {
            if (flipflop == true)
            {
                tb_MainMenu.Text = "^^ Press a Button vv";
                flipflop = false;
            }
            else
            {
                flipflop = true;
                tb_MainMenu.Text = "vv Press a Button ^^";
            }
        }

        void ChangeColor(object sender, EventArgs e)
        {
            // Makes so that the color will start iterating back when hitting the maxed out value at one side
            if (Forward == true)
            {
                GradientStop.Offset += 0.00002;
                GradientStart.Offset -= 0.00002;
            }
            else
            {
                GradientStop.Offset -= 0.00002;
                GradientStart.Offset += 0.00002;
            }
            // Changes the boolean if either gradient hit 100 or 0%
            if (GradientStop.Offset >= 1)
            {
                Forward = false;
            }
            if (GradientStop.Offset <= 0)
            {
                Forward = true;
            }
        }

        private void bt_Start_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NavigationService.Navigate(new Uri("Lands.xaml", UriKind.Relative));
            // Hide All stuff on menu
            bt_Start.Visibility = Visibility.Hidden;
            tb_MainMenu.Visibility = Visibility.Hidden;
            // Stops timers
            //MenuTimer.Stop();
            //ColorTimer.Stop();
        }
    }
}
