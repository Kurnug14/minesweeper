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
        public List<Cell> cells = new List<Cell>();
        public void MakeField(int minesnum)
        {
            Random rng = new Random();
            for (int i = 0; i < minesnum; i+=0) 
            {
                int minepos = rng.Next(0, cells.Count());
                if (cells[minepos].isMined==false)
                {
                    cells[minepos].image = "*";
                    cells[minepos].isMined = true;
                    i++;
                }
            }
        }
        public void ClearField()
        {
            foreach (Cell cell in cells)
            {
               CalcNearby(cell.xaxis, cell.yaxis);
                cell.Content = cell.image;
            }
        }
        public void CalcNearby(int xaxis, int yaxis)
        {
            int tracker = 0;
            List<Cell> queue = new List<Cell>();
            Cell celltrack = cells.Find(cell => cell.xaxis == xaxis && cell.yaxis == yaxis);
            queue.Add(celltrack);
            
            while (tracker< queue.Count) { 
                int count = 0;
                xaxis = queue[tracker].xaxis;
                yaxis = queue[tracker].yaxis;
                queue[tracker].Opening();
                

                List<Cell> nearcells = cells.FindAll(cell => 
                (
                    (cell.xaxis == xaxis - 1    && (cell.yaxis == yaxis-1 || cell.yaxis == yaxis+1 || cell.yaxis==yaxis)) 
                ||  (cell.xaxis == xaxis + 1    && (cell.yaxis == yaxis - 1 || cell.yaxis == yaxis + 1 || cell.yaxis == yaxis))
                ||  (cell.xaxis== xaxis      && (cell.yaxis == yaxis-1 || cell.yaxis== yaxis+1))
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
                    List<Cell> temp = queue;
                    temp.AddRange(nearcells);
                    queue = temp.Distinct().ToList();
                }
                else
                {
                    queue[tracker].CalcValue(count);
                }
                tracker++;
            }
        }
    }
}
