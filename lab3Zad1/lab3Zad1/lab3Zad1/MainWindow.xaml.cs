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

namespace lab3Zad1
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            float x = float.Parse(tBox1.Text);
            float y = float.Parse(tBox2.Text);
            float z= x + y;
            lWynik.Content ="Suma: "+x+"+"+y+ "="+ z;
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            float x = float.Parse(tBox1.Text);
            float y = float.Parse(tBox2.Text);
            float z = x - y;
            lWynik.Content ="różnica: " + x + "-" + y + "=" + z;
        }

        private void btnM_Click(object sender, RoutedEventArgs e)
        {
            float x = float.Parse(tBox1.Text);
            float y = float.Parse(tBox2.Text);
            float z = x * y;
            lWynik.Content ="Iloczyn = " + x + "*" + y + "=" + z;
        }

        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            float x = float.Parse(tBox1.Text);
            float y = float.Parse(tBox2.Text);

            if (y==0)
            {
                lWynik.Content = "Nie dzielimy przez 0!";
                MessageBox.Show("Nie dzielimy przez 0!");
                
            }
            else
            {
                float z = x / y;
                lWynik.Content ="Iloraz: " + x + "/" + y + "=" + z;
            }
            
        }
    }
}
