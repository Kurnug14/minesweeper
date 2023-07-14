using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace minesweeper
{
    public class Cell : Button
    {
        public int coords = 1;
        public bool isMined;
        int value;
        bool isFlagged = false;
        public string image="i";
        bool isOpened;
        int width = 80;
        int height = 80;
        public Cell() {
            CalcValue(1);
            }
        public void Opening()
        {

        }
        public void CalcValue(int i)
        {
            if (isMined==true)
            {
                image ="*";
            }
            else
            {

            }
        }
        public void UnFlagging()
        {

        }
        public void SetSymbol(int mode)
        {

        }
    }
}
