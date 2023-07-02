using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace wpfEvents_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void TopDown(object sender, MouseButtonEventArgs e)
        {
            DoStep(sender as Control);
            if(sender.Equals(e.Source))
            {
                Log.Text += "Up Down\n";
            }
        }

        void DownUp(object sender, MouseButtonEventArgs e) 
        {
            if (sender.Equals(e.Source))
            {
                Log.Text += "Down Up\n";
            }
            DoStep(sender as Control);
        }

        void Clear(object sender, MouseButtonEventArgs e)
        {
            LastGroupBox.Foreground = Brushes.Black;
            FirstLabel.Foreground = Brushes.Black;
            FirstGroupBox.Foreground = Brushes.Black;
            LastLabel.Foreground = Brushes.Black;
            Log.Text = "";
        }

        void DoStep(Control control)
        {
            Log.Text += control.Name + "\n";
            control.Foreground = Brushes.Red;
            MessageBox.Show("Дальше");
        }

    }
}
