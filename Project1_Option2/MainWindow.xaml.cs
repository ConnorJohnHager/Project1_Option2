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

            if (numberOfEllipses > 360)
            {
                errorMessage.Text = "Please input a number smaller than or equal to 360";
            }

            else
            {
                myCanvas.Children.Clear();

                errorMessage.Text = "";
                int yPosition = 0;
                int ellipseNumberInRow = 0;

                for (int i = 0; i < numberOfEllipses; i++)
                {

                    if (ellipseNumberInRow < 30)
                    {
                        Ellipse ellipse = new Ellipse
                        {
                            Height = 25,
                            Width = 25,
                            StrokeThickness = 1,
                            Stroke = Brushes.Black, 
                        };

                        Canvas.SetLeft(ellipse, 25 * ellipseNumberInRow);
                        Canvas.SetTop(ellipse, yPosition);

                        myCanvas.Children.Add(ellipse);

                        ellipseNumberInRow++;
                    }
                    else
                    {
                        ellipseNumberInRow = 0;
                        yPosition = yPosition + 25;

                        Ellipse ellipse = new Ellipse
                        {
                            Height = 25,
                            Width = 25,
                            StrokeThickness = 1,
                            Stroke = Brushes.Black,
                        };

                        Canvas.SetLeft(ellipse, 25 * ellipseNumberInRow);
                        Canvas.SetTop(ellipse, yPosition);

                        myCanvas.Children.Add(ellipse);

                        ellipseNumberInRow++;
                    }
                }  
            }
        }
    }
}
