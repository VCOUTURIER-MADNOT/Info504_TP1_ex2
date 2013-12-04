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

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.RegisterName("numberBox", this.numberBox);
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (!this.isNumber(e.Key))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private Boolean isNumber(Key keyDowned)
        {
            if (keyDowned.Equals(Key.NumPad0) ||
                keyDowned.Equals(Key.NumPad1) ||
                keyDowned.Equals(Key.NumPad2) ||
                keyDowned.Equals(Key.NumPad3) ||
                keyDowned.Equals(Key.NumPad4) ||
                keyDowned.Equals(Key.NumPad5) ||
                keyDowned.Equals(Key.NumPad6) ||
                keyDowned.Equals(Key.NumPad7) ||
                keyDowned.Equals(Key.NumPad8) ||
                keyDowned.Equals(Key.NumPad9))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
