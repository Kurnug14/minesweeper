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
        int loop = 6;
        int difficulty= 3;
        int diftrack= 0;
        
        private void Reset_Click(object sender, RoutedEventArgs e)
        {

            state.Visibility = Visibility.Collapsed;
            play.Content = "Playing";
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
                cell.PreviewMouseLeftButtonDown+= Cell_Click;
                cell.PreviewMouseRightButtonDown+= Cell_Click;
                grid.cells.Add(cell);
                gamegrid.Children.Add(cell);
                Grid.SetRow(cell, i);
                Grid.SetColumn(cell, 0);
            }
            }
            grid.remained = 0;
            grid.height = loop-1;
            grid.width=loop-1;
            grid.MakeField(difficulty);
            dimsize= 0;
            tracker= 0;
        }

        private void Size_Click(object sender, RoutedEventArgs e)
        {
            loop += 3;

            if (loop > 12) 
            {
                loop = 6;
            }
            switch (loop)
            {
                case 6:
                    size.Content = "Small";
                    break;
                case 9:
                    size.Content = "Medium";
                    break;
                case 12:
                    size.Content = "Big";
                    break;
            }
        }

        private void Difficulty_Click(object sender, RoutedEventArgs e)
        {
            diftrack += 1;
            if (diftrack > 3)
            {
                diftrack = 1;
            }
            switch (diftrack)
            {
                case 1:
                    diff.Content = "Easy";
                    break;
                case 2:
                    diff.Content = "Medium";
                    break;
                case 3:
                    diff.Content = "Hard";
                    break;
            }
            difficulty = loop + (diftrack * 3);

        }

        private void Cell_Click(object sender, MouseButtonEventArgs e)
        {
            Cell clickedButton = (Cell)sender;
            if (e.ChangedButton == MouseButton.Left) { 
                if (clickedButton.isMined == false && clickedButton.isFlagged==false) 
                { 
                    grid.CalcNearby(clickedButton.xaxis, clickedButton.yaxis);
                }

                
                else if (clickedButton.isMined == true && clickedButton.isFlagged == false)
                {
                    grid.ClearField();
                    play.Content = "Restart";
                    state.Content = "Lost";
                    state.Visibility= Visibility.Visible;
                    state.Foreground = Brushes.Red;
                }
                if (grid.remained==grid.cells.Count-difficulty)
                {
                    play.Content = "Restart";
                    state.Content = "Won";
                    state.Visibility = Visibility.Visible;
                    state.Foreground = Brushes.Green;
                }
            }
            else if (e.ChangedButton== MouseButton.Right) 
            {
                clickedButton.UnFlagging();
            }

            size.Content = grid.remained;
        }
    }
}
