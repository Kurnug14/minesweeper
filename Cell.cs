using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace minesweeper
{
    public class Cell : Button
    {
        public int coords = 1;
        public bool isMined;
        int value;
        public bool isFlagged = false;
        public string image="";
        public bool isOpened=false;
        public int xaxis = 0;
        public int yaxis = 0;
        public Cell() {
            CalcValue(1);
            }
        public void Opening()
        {
            IsEnabled = false;
        }
        public void CalcValue(int i)
        {
            if (isMined==true)
            {
                image = "*";
                Foreground = Brushes.Black;
                Background = new SolidColorBrush(Colors.Red);
                
            }
            else {     
            switch (i)
                {
                    case 1:
                        Foreground = Brushes.Blue;
                        break;
                    case 2:
                        Foreground = Brushes.Green;
                        break;
                    case 3:
                        Foreground = Brushes.Red;
                        break;
                    case 4:
                        Foreground = Brushes.DarkBlue;
                        break;
                    case 5:
                        Foreground = Brushes.DarkGreen;
                        break;
                    case 6:
                        Foreground = Brushes.DarkRed;
                        break;
                    case 7:
                        Foreground = Brushes.LightCyan;
                        break;
                    case 8:
                        Foreground = Brushes.Black;
                        break;
                    default:
                        Foreground = Brushes.Black;
                        
                    break;
                }
                image = i.ToString();
            }
            Content = image;
        }
            
        
        public void UnFlagging()
        {
            if (isFlagged== false) 
            {
                isFlagged= true;
                image = "|>";
            }
            else
            {
                isFlagged= false;
                image = "";
            }
            Content= image;
            

        }
        public void SetSymbol(int mode)
        {

        }
    }
}
