using minesweeper;
using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace Minesweeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameField grid = new GameField();
        public MainWindow()
        {
            InitializeComponent();
        }
        int dimsize = 0;
        int loop = 0;
        
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            int tracker = 0;
            grid.cells.Clear();
            for (int i = 1; i<loop + 1; i++)
            {
                dimsize += 80;
            }
            gamegrid.Height = (dimsize);
            gamegrid.Width = (dimsize);
            window.Height = (dimsize +100);
            window.Width = (dimsize +80);
            for (int j = 0; j < loop; j++) {
                
            for (int i = 0; i < loop; i++) {
                    tracker++;
            string contracker = "C"+tracker.ToString();
            Cell cell = new Cell
            {
                 Height = 80,
                 Width = 80,
                 Name= contracker,
                 VerticalAlignment = VerticalAlignment.Top,
                 HorizontalAlignment = HorizontalAlignment.Left,
                 Background= Brushes.LightGray,
                 Margin = new Thickness((i * 80), (j * 80), 0, 0),
                 xaxis=i,
                 yaxis=j,
                 FontWeight= FontWeights.Bold,
                 Content = ""
                };
                cell.Click += Cell_Click;
                grid.cells.Add(cell);
                gamegrid.Children.Add(cell);
                Grid.SetRow(cell, i);
                Grid.SetColumn(cell, 0);
            }
            }
            grid.height = loop-1;
            grid.width=loop-1;
            grid.MakeField();
            dimsize= 0;
            tracker= 0;
        }

        private void Size_Click(object sender, RoutedEventArgs e)
        {
            loop += 3;

            if (loop > 9) 
            {
                loop = 3;
            }
            switch (loop)
            {
                case 3:
                    size.Content = "Small";
                    break;
                case 6:
                    size.Content = "Medium";
                    break;
                case 9:
                    size.Content = "Big";
                    break;
            }
        }

        private void Difficulty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cell_Click(object sender, RoutedEventArgs e)
        {
            Cell clickedButton = (Cell)sender;
            grid.CalcNearby(clickedButton.xaxis, clickedButton.yaxis);
            
        }
    }
}
