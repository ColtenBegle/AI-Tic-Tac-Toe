﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.UI;

namespace TicTacToe.Game_Logic.AI
{
    public class AIPlayer : Player
    {
        private enum Scores
        {
            X = -10,
            O = 10,
            tie = 0
        }
        private const string _username = "AI";
        public delegate bool CheckState();
        private CheckState _checkState;
        public delegate bool IsFull();
        private IsFull _isFull;

        public AIPlayer(PlayerSymbols symbol, bool isTurn, Func<bool> checkState, Func<bool> isFull) : base(_username, symbol, isTurn)
        {
            _checkState = new CheckState(checkState);
            _isFull = new IsFull(isFull);
        }

        public void MakeMove(int gridSize, Button[,] cells)
        {
            double bestScore = double.NegativeInfinity;
            Tuple<int, int> bestMove = new Tuple<int, int>(-1, -1);
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    if (cells[x, y].Text == "")
                    {
                        cells[x, y].Text = Symbol.ToString();
                        double score = minimax(cells, gridSize, 0, false);
                        cells[x, y].Text = "";
                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove = new Tuple<int, int>(x, y);
                        }
                    }
                }
            }
            if (bestMove.Item1 != -1 && bestMove.Item2 != -1)
                cells[bestMove.Item1, bestMove.Item2].Text = Symbol.ToString();
        }

        private double minimax(Button[,] cells, int gridSize, int depth, bool isMaximizing)
        {
            bool state = _checkState();
            double score = 0.0;

            if (state == true)
            {
                if (isMaximizing == false)
                {
                    score = (double)Scores.O;
                    Console.WriteLine("WINNING BOARD");
                    PrintBoard(cells, gridSize);
                    Console.WriteLine("\n\n");
                    return score;
                }
                else
                {
                    score = (double)Scores.X;
                    return score;
                }
            }
            else if (_isFull())
            {
                score = (double)Scores.tie;
                return score;
            }
            if (isMaximizing)
            {
                double bestScore = double.NegativeInfinity;
                for (int x = 0; x < gridSize; x++)
                {
                    for (int y = 0; y < gridSize; y++)
                    {
                        if (cells[x, y].Text == "")
                        {
                            cells[x, y].Text = Symbol.ToString();
                            score = minimax(cells, gridSize, depth + 1, false);
                            cells[x, y].Text = "";
                            bestScore = Math.Max(score, bestScore);
                        }
                    }
                }
                return bestScore;
            }
            else
            {
                PlayerSymbols opponentSymbol;
                if (Symbol == PlayerSymbols.O)
                    opponentSymbol = PlayerSymbols.X;
                else
                    opponentSymbol = PlayerSymbols.O;
                double bestScore = double.PositiveInfinity;
                for (int x = 0; x < gridSize; x++)
                {
                    for (int y = 0; y < gridSize; y++)
                    {
                        if (cells[x, y].Text == "")
                        {
                            cells[x, y].Text = opponentSymbol.ToString();
                            score = minimax(cells, gridSize, depth + 1, true);
                            cells[x, y].Text = "";
                            bestScore = Math.Min(score, bestScore);
                        }
                    }
                }
                return bestScore;
            }
        }

        private void PrintBoard(Button[,] cells, int gridSize)
        {
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    if (cells[x, y].Text == "")
                    {
                        Console.Write("| |");
                    }
                    else
                        Console.Write("|" + cells[x, y].Text + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
