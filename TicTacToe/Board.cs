using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Game_Logic;

namespace TicTacToe
{
    public class Board
    {
        public int movesMade = 0;
        public int Owins = 0;
        public int Xwins = 0;

        private int xPos;
        private int yPos;

        private Rectangle[,] slots = new Rectangle[3,3];
        private Holder[,] holders = new Holder[3, 3];

        public const int X = 0;
        public const int O = 1;
        public const int B = 2;

        public int playersTurn = X;

        public int getPlayerForTurn()
        {
            return playersTurn;
        }

        public int getOwins()
        {
            return Owins;
        }

        public int getXwins()
        {
            return Xwins;
        }

        public void initBoard()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    //slots[x, y] = new Rectangle(x * 167, y * 167, 167, 167);
                    holders[x, y] = new Holder();
                    holders[x, y].setValue(B);
                    holders[x, y].setLocation(new Point(x, y));
                }
            }
        }
        public void detectHit(Point location, PlayerSymbols playerChar)
        {
            //checks if board is clicked
            if (location.Y <= 500)
            {

                //x
                if (location.X < 167)
                {
                    xPos = 0;
                }
                else if (location.X > 167 && location.X < 334)
                {
                    xPos = 1;
                }
                else if (location.X > 334)
                {
                    xPos = 2;
                }
                // end x 

                //y
                if (location.Y < 167)
                {
                    yPos = 0;
                }
                else if (location.Y > 167 && location.Y < 334)
                {
                    yPos = 1;
                }
                else if (location.Y > 334 && location.Y < 501)
                {
                    yPos = 2;
                }
                //end y
                movesMade++;

                if (playerChar == PlayerSymbols.X)
                {
                    GFX.drawX(new Point(xPos, yPos));
                    holders[xPos, yPos].setValue(X);
                    if (detectRow())
                    {
                        MessageBox.Show("YOU HAVE WON, X!");
                        Xwins++;
                        reset();
                        GFX.setUpCanvas();
                    }

                    if (isBoardFull())
                    {
                        movesMade++;
                    }

                    if (Form1.getAiGame() && !detectRow() && !isBoardFull())
                    {
                        Holder aiMove = ComputerLogic.determineAndPlaceMark(holders);
                        GFX.drawO(aiMove.getLocation());
                        holders[aiMove.getLocation().X, aiMove.getLocation().Y].setValue(O);
                        if (detectRow())
                        {
                            MessageBox.Show("The computer has won! :(");
                            Owins++;
                            reset();
                            GFX.setUpCanvas();
                        }

                        movesMade++;

                        playersTurn = X;

                    }
                    else
                        playersTurn = O;
                }
                else
                {
                    GFX.drawO(new Point(xPos, yPos));
                    holders[xPos, yPos].setValue(O);
                    if (detectRow())
                    {
                        MessageBox.Show("YOU HAVE WON, O!");
                        Owins++;
                        reset();
                        GFX.setUpCanvas();
                    }
                    playersTurn = X;
                }
            }
            //MessageBox.Show(x.ToString() + ", " + y.ToString() + "\n\n" + location.ToString());
        }
        public bool detectRow()
        {
            bool isWon = false;

            for (int x = 0; x < 3; x++)
            {
                if (holders[x, 0].getValue() == X && holders[x, 1].getValue() == X && holders[x, 2].getValue() == X)
                {
                    return true;
                }
                if (holders[x, 0].getValue() == O && holders[x, 1].getValue() == O && holders[x, 2].getValue() == O)
                {
                    return true;
                }

                switch (x)
                {
                    case 0:
                        if (holders[x, 0].getValue() == X && holders[x+1, 1].getValue() == X && holders[x+2, 2].getValue() == X)
                        {
                            return true;
                        }
                        if (holders[x, 0].getValue() == O && holders[x + 1, 1].getValue() == O && holders[x + 2, 2].getValue() == O)
                        {
                            return true;
                        }
                        break;

                    case 2:
                        if (holders[x, 0].getValue() == X && holders[x-1, 1].getValue() == X && holders[x-2, 2].getValue() == X)
                        {
                            return true;
                        }
                        if (holders[x, 0].getValue() == O && holders[x - 1, 1].getValue() == O && holders[x - 2, 2].getValue() == O)
                        {
                            return true;
                        }
                        break;
                }
            }
            for (int y = 0; y < 3; y++)
            {
                if (holders[0, y].getValue() == X && holders[1, y].getValue() == X && holders[2, y].getValue() == X)
                {
                    return true;
                }
                if (holders[0, y].getValue() == O && holders[1, y].getValue() == O && holders[2, y].getValue() == O)
                {
                    return true;
                }
            }

            return isWon;
        }
        public void reset()
        {
            holders = new Holder[3, 3];
            initBoard();
        }

        public bool isBoardFull()
        {
            bool full = true;
            foreach (Holder h in holders)
            {
                if (h.getValue() == Board.B)
                {
                    full = false;
                }
            }
            return full;
        }

        public int XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public int YPos
        {
            get { return yPos; }
            set { yPos = value; }
        }
    }
}
