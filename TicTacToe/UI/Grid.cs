using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe.UI
{
    public class Grid
    {
        private Button[,] _cells;
        private int _gridSize;
        private double _score;
        public Grid(int gridSize)
        {
            _cells = new Button[gridSize, gridSize];
            _gridSize = gridSize;
        }
        public Button[,] Cells
        {
            get { return _cells; }
            set { _cells = value; }
        }
        public int GridSize
        {
            get { return _gridSize; }
            set { _gridSize = value; }
        }
        public double Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public List<Button> GetEmptyCells()
        {
            List<Button> emptyCells = new List<Button>();
            for (int x = 0; x < _gridSize; x++)
            {
                for (int y = 0; y < _gridSize; y++)
                {
                    if (_cells[x, y].Text == "")
                    {
                        emptyCells.Add(_cells[x, y]);
                    }
                }
            }
            return emptyCells;
        }
    }
}
