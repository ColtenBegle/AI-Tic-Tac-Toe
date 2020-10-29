using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.UI
{
    public class Grid
    {
        private Button[,] _cells;
        public Grid(int gridSize)
        {
            _cells = new Button[gridSize, gridSize];
        }
        public Button[,] Cells
        {
            get { return _cells; }
            set { _cells = value; }
        }
    }
}
