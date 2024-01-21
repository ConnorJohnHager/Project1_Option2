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

namespace Project1_Option2
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

        private void Input_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void Trigger_Click(object sender, RoutedEventArgs e)
        {
            int numberOfEllipses = int.Parse(Input.Text);

            if (numberOfEllipses >= 50)
            {
                errorMessage.Text = "Please input a number smaller than 50";
            }

            else
            {
                errorMessage.Text = "";

                Ellipse[] ellipseArray = new Ellipse[50];

                for (int i = 0; i < numberOfEllipses; i++)
                {
                    Ellipse ellipse = new Ellipse();
                    ellipseArray[i] = ellipse;
                }

                foreach (Ellipse ellipse in ellipseArray)
                {

                }
            }
        }
    }
}
