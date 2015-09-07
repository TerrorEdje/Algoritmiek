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
        private int _numValue = 5;

        public MainWindow()
        {
            InitializeComponent();
            txtNum.Text = _numValue.ToString();
            DrawSierpinskiCarpet(0, 0, (int)MainCanvas.Height, (int)MainCanvas.Width,0);
        }

        public void DrawSierpinskiCarpet(int xOL, int yOL, int breedte, int hoogte, int level)
        {
            
            if (level >= _numValue)
            {
                Rectangle smallsquare = new Rectangle();
                smallsquare.Fill = new SolidColorBrush(Colors.White);
                smallsquare.Stroke = new SolidColorBrush(Colors.White);
                smallsquare.Width = breedte;
                smallsquare.Height = hoogte;
                Canvas.SetTop(smallsquare, yOL);
                Canvas.SetLeft(smallsquare, xOL);
                MainCanvas.Children.Add(smallsquare);        
                return;
            }
            level++;
            if (breedte > 2 && hoogte > 2)
            {
                int b = breedte / 3;
                int h = hoogte / 3;
                for (int k = 0; k < 9; k++)
                {
                    if (k != 4)
                    {
                        int i = k / 3;
                        int j = k % 3;                                    
                        DrawSierpinskiCarpet(xOL + i * b, yOL + j * h, b, h,level); // Recursie
                    }
                }
            }
        }

        public void UpdateCarpet()
        {
            MainCanvas.Children.Clear();
            DrawSierpinskiCarpet(0, 0, (int)MainCanvas.Height, (int)MainCanvas.Width,0);
        }

        public int NumValue
        {
            get { return _numValue; }
            set
            {                
                _numValue = value;
                txtNum.Text = value.ToString();
                UpdateCarpet();
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
