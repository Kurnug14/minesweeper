using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    public class GameField
    {
        public int height;
        int width;
        int minesnum;
        List<int> alreadymined = new List<int>();
        public List<Cell> cells = new List<Cell>();
        public void MakeField(int height, int width, int mines)
        {
            int size = height * width;
            for (int i = 0; i < size; i++)
            {
                cells.Add(new Cell());
                if (i == 3||i==4 ||i==5)
                {
                    alreadymined.Add(i);
                }
                if (alreadymined.Contains(i))
                { 
                    cells[i].isMined = true; 
                };
            }
        }
        public void ClearField()
        {

        }
        public int CalcNearby(int coord)
        {
            return 0;
        }
    }
}
