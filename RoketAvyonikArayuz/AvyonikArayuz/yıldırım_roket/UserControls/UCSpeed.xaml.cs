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
    /// UCSpeed.xaml etkileşim mantığı
    /// </summary>
    public partial class UCSpeed : UserControl
    {

        public static readonly DependencyProperty SpeedPropery = DependencyProperty.Register("Speed", typeof(double), typeof(UCSpeed));
        public double Speed

        {

            get { return (double)GetValue(SpeedPropery); }

            set { SetValue(SpeedPropery, value); }

        }

        public UCSpeed()
        {
            this.DataContext = this;
            InitializeComponent();
        }
    }
}
