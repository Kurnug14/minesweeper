using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
            }
        public void Opening()
        {
            IsEnabled = false;
            isOpened= true;
        }
        public void CalcValue(int i)
        {
            if (this.isMined==true)
            {
                Image pic = new Image();
                pic.Source = new BitmapImage(new Uri("mine.png", UriKind.Relative));
                Content = pic;
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
                Content = image;
            }
            
        }
            
        
        public void UnFlagging()
        {
            if (isFlagged== false) 
            {
                Image pic = new Image();
                isFlagged= true;
                pic.Source = new BitmapImage(new Uri("flag.png", UriKind.Relative));
              
                Content = pic;
            }
            else
            {
                isFlagged= false;
                image = "";
                Content= image;
            }
        }
        public void Mine ()
        {
            Image pic = new Image();
            pic.Source = new BitmapImage(new Uri("mine.png", UriKind.Relative));
            Content = pic;
        }
    }
}
