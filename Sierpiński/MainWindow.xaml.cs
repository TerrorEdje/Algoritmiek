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

namespace Sierpiński
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _numValue = 0;

        public MainWindow()
        {
            InitializeComponent();
            txtNum.Text = _numValue.ToString();
            DrawSierpinskiCarpet(0, 0, (int)MainCanvas.Height, (int)MainCanvas.Width);
        }

        public void DrawSierpinskiCarpet(int xOL, int yOL, int breedte, int hoogte)
        {
            if (breedte > 2 && hoogte > 2)
            {
                int b = breedte / 3;
                int h = hoogte / 3;
                Rectangle rect = new Rectangle();
                rect.Fill = new SolidColorBrush(Colors.White);
                rect.Width = b;
                rect.Height = h;
                Canvas.SetTop(rect, yOL + h);
                Canvas.SetLeft(rect, xOL + b);
                MainCanvas.Children.Add(rect);
                for (int k = 0; k < 9; k++)
                {
                    int i = k / 3;
                    int j = k % 3;
                    Rectangle smallsquare = new Rectangle();
                    smallsquare.Fill = new SolidColorBrush(Colors.Black);
                    smallsquare.Width = b;
                    smallsquare.Height = h;
                    Canvas.SetTop(smallsquare, yOL + h);
                    Canvas.SetLeft(smallsquare, xOL + b);
                    MainCanvas.Children.Add(smallsquare);
                    if (k != 4)
                    {                        
                        DrawSierpinskiCarpet(xOL + i * b, yOL + j * h, b, h); // Recursie
                    }
                }
            }
        }

        public void UpdateCarpet()
        {
            MainCanvas.Children.Clear();
            //DrawSierpinskiCarpet(0, 0, (int)MainCanvas.Height, (int)MainCanvas.Width);
        }

        public int NumValue
        {
            get { return _numValue; }
            set
            {
                UpdateCarpet();
                _numValue = value;
                txtNum.Text = value.ToString();
            }
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            NumValue--;
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }

            if (!int.TryParse(txtNum.Text, out _numValue))
            {
                txtNum.Text = _numValue.ToString();
            }                
        }
    }    
}
