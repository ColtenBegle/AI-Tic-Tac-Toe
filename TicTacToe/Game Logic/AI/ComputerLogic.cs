using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TicTacToe
{
    class ComputerLogic
    {
        public static Holder determineAndPlaceMark(Holder[,] board)
        {
            Holder move = new Holder();
            move.setValue(Board.O);

            // See if middle is empty
            if (board[1, 1].getValue() == Board.B)
            {
                move.setLocation(new System.Drawing.Point(1, 1));
                return move;
            }

        // See if there are any open rows of two O's
            // Check vertical combos
            for (int x = 0; x < 3; x++)
            {
                if (board[x, 0].getValue() == Board.O && board[x, 1].getValue() == Board.O && board[x, 2].getValue() == Board.B)
                {
                    move.setLocation(new Point(x, 2));
                    return move;
                }
            }

            // checks across the board for possible rows of 3
            for (int x = 0; x < 3; x++)
            {
                if (board[x, 0].getValue() == Board.B && board[x, 1].getValue() == Board.O && board[x, 2].getValue() == Board.O)
                {
                    move.setLocation(new Point(x, 0));
                    return move;
                }
            }

            // checks across the board for possible rows of 3
            for (int x = 0; x < 3; x++)
            {
                if (board[x, 0].getValue() == Board.O && board[x, 1].getValue() == Board.B && board[x, 2].getValue() == Board.O)
                {
                    move.setLocation(new Point(x, 1));
                    return move;
                }
            }


            // Check horizontal combos
            for (int y = 0; y < 3; y++)
            {
                if (board[0, y].getValue() == Board.O && board[1, y].getValue() == Board.O && board[2, y].getValue() == Board.B)
                {
                    move.setLocation(new Point(2, y));
                    return move;
                }
            }

            // Check
            for (int y = 0; y < 3; y++)
            {
                if (board[0, y].getValue() == Board.B && board[1, y].getValue() == Board.O && board[2, y].getValue() == Board.O)
                {
                    move.setLocation(new Point(0, y));
                    return move;
                }
            }

            // Check
            for (int y = 0; y < 3; y++)
            {
                if (board[0, y].getValue() == Board.O && board[1, y].getValue() == Board.B && board[2, y].getValue() == Board.O)
                {
                    move.setLocation(new Point(1, y));
                    return move;
                }
            }


            // Check for diagonal combos

            if (board[0,0].getValue() == Board.O && board[1,1].getValue() == Board.O && board[2,2].getValue() == Board.B)
            {
                move.setLocation(new Point (2, 2));
                return move;
            }
                
            else if (board[2, 0].getValue() == Board.O && board[1, 1].getValue() == Board.O && board[0, 2].getValue() == Board.B)
            {
                move.setLocation(new Point(0, 2));
                return move;
            }

            // check
            if (board[2,0].getValue() == Board.O && board[1,1].getValue() == Board.O && board[0,2].getValue() == Board.B)
            {
                move.setLocation(new Point (0, 2));
                return move;
            }
            else if (board[2, 2].getValue() == Board.O && board[1, 1].getValue() == Board.O && board[0, 0].getValue() == Board.B)
            {
                move.setLocation(new Point(0, 0));
                return move;
            }

            // check
            if (board[0, 0].getValue() == Board.O && board[1, 1].getValue() == Board.B && board[2, 2].getValue() == Board.O)
            {
                move.setLocation(new Point(1, 1));
                return move;
            }
            else if (board[0, 2].getValue() == Board.O && board[1, 1].getValue() == Board.B && board[2, 0].getValue() == Board.O)
            {
                move.setLocation(new Point(1, 1));
                return move;
            }

            // ------------------ Check for defense ----------------------------

            // See if there are any open rows of two O's
            // Check vertical combos
            for (int x = 0; x < 3; x++)
            {
                if (board[x, 0].getValue() == Board.X && board[x, 1].getValue() == Board.X && board[x, 2].getValue() == Board.B)
                {
                    move.setLocation(new Point(x, 2));
                    return move;
                }
            }

            // checks across the board for possible rows of 3
            for (int x = 0; x < 3; x++)
            {
                if (board[x, 0].getValue() == Board.B && board[x, 1].getValue() == Board.X && board[x, 2].getValue() == Board.X)
                {
                    move.setLocation(new Point(x, 0));
                    return move;
                }
            }

            // checks across the board for possible rows of 3
            for (int x = 0; x < 3; x++)
            {
                if (board[x, 0].getValue() == Board.X && board[x, 1].getValue() == Board.B && board[x, 2].getValue() == Board.X)
                {
                    move.setLocation(new Point(x, 1));
                    return move;
                }
            }


            // Check horizontal combos
            for (int y = 0; y < 3; y++)
            {
                if (board[0, y].getValue() == Board.O && board[1, y].getValue() == Board.O && board[2, y].getValue() == Board.B)
                {
                    move.setLocation(new Point(2, y));
                    return move;
                }
            }

            // Check
            for (int y = 0; y < 3; y++)
            {
                if (board[0, y].getValue() == Board.B && board[1, y].getValue() == Board.X && board[2, y].getValue() == Board.X)
                {
                    move.setLocation(new Point(0, y));
                    return move;
                }
            }

            // Check
            for (int y = 0; y < 3; y++)
            {
                if (board[0, y].getValue() == Board.X && board[1, y].getValue() == Board.B && board[2, y].getValue() == Board.X)
                {
                    move.setLocation(new Point(1, y));
                    return move;
                }
            }


            // Check for diagonal combos

            if (board[0, 0].getValue() == Board.X && board[1, 1].getValue() == Board.X && board[2, 2].getValue() == Board.B)
            {
                move.setLocation(new Point(2, 2));
                return move;
            }

            else if (board[2, 0].getValue() == Board.X && board[1, 1].getValue() == Board.X && board[0, 2].getValue() == Board.B)
            {
                move.setLocation(new Point(0, 2));
                return move;
            }

            // check
            if (board[2, 0].getValue() == Board.X && board[1, 1].getValue() == Board.X && board[0, 2].getValue() == Board.B)
            {
                move.setLocation(new Point(0, 2));
                return move;
            }
            else if (board[2, 2].getValue() == Board.X && board[1, 1].getValue() == Board.X && board[0, 0].getValue() == Board.B)
            {
                move.setLocation(new Point(0, 0));
                return move;
            }

            // check
            if (board[0, 0].getValue() == Board.X && board[1, 1].getValue() == Board.B && board[2, 2].getValue() == Board.X)
            {
                move.setLocation(new Point(1, 1));
                return move;
            }
            else if (board[0, 2].getValue() == Board.X && board[1, 1].getValue() == Board.B && board[2, 0].getValue() == Board.X)
            {
                move.setLocation(new Point(1, 1));
                return move;
            }

            //
            //
            // Place any move on board
            //
            //

            List<Holder> blankSpaces = new List<Holder>();
            foreach(Holder h in board)
            {
                if(h.getValue() == Board.B)
                {
                    blankSpaces.Add(h);
                }
            }

            move.setLocation(blankSpaces.ToArray()[0].getLocation());

            return move;
        }
    }
}
