using Microsoft.Maps.MapControl.WPF;
using roket_yer_bilgisayari.ViewModel;
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

namespace ders2_10._01._2020
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {



        double m_longitude = 32.818283;
        double m_latitude = 39.970777;
        public MainWindow()
        {
            InitializeComponent();
            lb_rocket_name.DataContext = RoketViewModel.YıldırımRoket;
            gauge_altitude.DataContext = RoketViewModel.YıldırımRoket;
            gauge_speed.DataContext = RoketViewModel.YıldırımRoket;
        }


        private void AddPoint(double longitude, double latitude, Brush box_color)
        {
            Canvas m_canvas = new Canvas();
            m_canvas.Width = 10;
            m_canvas.Height = 10;
            m_canvas.Background = box_color;
            MapLayer.SetPosition(m_canvas, new Location() { Longitude = longitude, Latitude = latitude });

            map_layer.Children.Add(m_canvas);
        }

        private void bt_sag_Click(object sender, RoutedEventArgs e)
        {

            m_longitude = m_longitude + 0.0005;
            AddPoint(m_longitude, m_latitude, Brushes.Red);
            
        }

        private void bt_sol_Click(object sender, RoutedEventArgs e)
        {
            m_longitude = m_longitude - 0.0005;
            AddPoint(m_longitude, m_latitude, Brushes.Gray);
        }

        private void bt_yukari_Click(object sender, RoutedEventArgs e)
        {
            m_latitude = m_latitude + 0.0005;
            AddPoint(m_longitude, m_latitude, Brushes.Orange);
        }

        private void bt_asagi_Click(object sender, RoutedEventArgs e)
        {
            m_latitude = m_latitude - 0.0010;
            AddPoint(m_longitude, m_latitude, Brushes.Turquoise);
        }

        private void bt_sag_yukari_capraz_Click(object sender, RoutedEventArgs e)
        {
            m_latitude = m_latitude + 0.0005;
            m_longitude = m_longitude + 0.0005;
            AddPoint(m_longitude, m_latitude, Brushes.RoyalBlue);
        }

        double alt = 0;
        double spd = 0;
        private void bt_isim_degistir_Click(object sender, RoutedEventArgs e)
        {
            alt++;
            spd--;
            RoketViewModel.setName("Mücahit Yıldırım");
            RoketViewModel.setAltitude(alt);
            RoketViewModel.setSpeed(spd);
        }
    }
}
