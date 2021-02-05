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

namespace roket_yer_bilgisayari.UserControls
{
    /// <summary>
    /// UCAltitude.xaml etkileşim mantığı
    /// </summary>
    public partial class UCAltitude : UserControl
    {


        public static readonly DependencyProperty AltitudePropery = DependencyProperty.Register("Altitude", typeof(double), typeof(UCAltitude));
        public double Altitude

        {

            get { return (double) GetValue(AltitudePropery);}

            set { SetValue(AltitudePropery, value);}

        }


        public UCAltitude()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
