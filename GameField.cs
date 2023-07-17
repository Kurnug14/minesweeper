using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;

namespace minesweeper
{
    public class GameField
    {
        public int height;
        public int width;
        public int minesnum=3;
        public List<Cell> cells = new List<Cell>();
        public void MakeField()
        {
            Random rng = new Random();
            for (int i = 0; i < minesnum; i+=0) 
            {
                int minepos = rng.Next(0, cells.Count());
                if (cells[minepos].isMined==false)
                {
                    cells[minepos].isMined = true;
                    i++;
                }
            }
        }
        public void ClearField()
        {

        }
        public void CalcNearby(int xaxis, int yaxis)
        {
            Cell celltrack = cells.Find(cell => cell.xaxis == xaxis && cell.yaxis == yaxis);
            if (celltrack != null && celltrack.isOpened==false)
            {
                celltrack.Opening();
                int count = 0;

                List<Cell> nearcells = cells.FindAll(cell => 
                (
                    (cell.xaxis == xaxis - 1    && (cell.yaxis == yaxis-1 || cell.yaxis == yaxis+1 || cell.yaxis==yaxis)) 
                ||  (cell.xaxis == xaxis + 1    && (cell.yaxis == yaxis - 1 || cell.yaxis == yaxis + 1 || cell.yaxis == yaxis))
                ||  (cell.yaxis== yaxis-1       && (cell.xaxis == xaxis-1 || cell.xaxis== xaxis+1 || cell.xaxis== xaxis))
                ||  (cell.yaxis == yaxis + 1 && (cell.xaxis == xaxis - 1 || cell.xaxis == xaxis + 1 || cell.xaxis == xaxis))
                && cell.isOpened == false
            ));
                foreach (Cell cell in nearcells)
                {
                    if (cell.isMined== true)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    CalcNearby(xaxis+1, yaxis);
                }
                else
                {
                    celltrack.CalcValue(count);
                }
            }
        }
    }
}
