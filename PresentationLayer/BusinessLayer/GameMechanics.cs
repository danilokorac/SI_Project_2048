using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{

    class GameMechanics
    {
        private int[,] GameBoard = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        private bool isMoved = true;

        private void randomGenerator()
        {
            int i, j, random;
            Random r = new Random();
            i = r.Next(4);
            j = r.Next(4);

            if (!isBoardFull() && isMoved)
            {

                while (GameBoard[i, j] != 0)
                {
                    i = r.Next(4);
                    j = r.Next(4);
                }
                random = r.Next(6);
                if (random == 5)
                    GameBoard[i, j] = 4;
                else
                    GameBoard[i, j] = 2;

                isMoved = false;
            }
        }

        private bool isBoardFull()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameBoard[i, j] == 0)
                        return false;
                }
            }
            return true;
        }

        public void moveLeft()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameBoard[i, j] != 0)
                    {
                        for(int k = j + 1; k < 4; k++)
                        {
                            if (GameBoard[i, j] == GameBoard[i, k])
                            {
                                GameBoard[i, j] += GameBoard[i, k];
                                GameBoard[i, k] = 0;
                                isMoved = true;
                                break;
                            }
                            else if (GameBoard[i, k] == 0)
                                continue;
                            else if (GameBoard[i, j] != GameBoard[i, k])
                                break;
                        }
                    }
                }
            }

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(GameBoard[i, j] != 0)
                    {
                        for(int k = j; k > 0; k--)
                        {
                            if (GameBoard[i, k - 1] == 0)
                            {
                                GameBoard[i, k - 1] = GameBoard[i, k];
                                GameBoard[i, k] = 0;
                                isMoved = true;
                            }
                        }
                    }
                }
            }

            randomGenerator();
        }

        public void moveRight()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (GameBoard[i, j] != 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (GameBoard[i, j] == GameBoard[i, k])
                            {
                                GameBoard[i, j] += GameBoard[i, k];
                                GameBoard[i, k] = 0;
                                isMoved = true;
                                break;
                            }
                            else if (GameBoard[i, k] == 0)
                                continue;
                            else if (GameBoard[i, j] != GameBoard[i, k])
                                break;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (GameBoard[i, j] != 0)
                    {
                        for (int k = j; k < 3; k++)
                        {
                            if (GameBoard[i, k + 1] == 0)
                            {
                                GameBoard[i, k + 1] = GameBoard[i, k];
                                GameBoard[i, k] = 0;
                                isMoved = true;
                            }
                        }
                    }
                }
            }

            randomGenerator();
        }

        public void moveUp()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameBoard[j, i] != 0)
                    {
                        for (int k = j + 1; k < 4; k++)
                        {
                            if (GameBoard[j, i] == GameBoard[k, i])
                            {
                                GameBoard[j, i] += GameBoard[k, i];
                                GameBoard[j, i] = 0;
                                isMoved = true;
                                break;
                            }
                            else if (GameBoard[k, i] == 0)
                                continue;
                            else if (GameBoard[j, i] != GameBoard[k, i])
                                break;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameBoard[j, i] != 0)
                    {
                        for (int k = j; k > 0; k--)
                        {
                            if (GameBoard[k - 1, i] == 0)
                            {
                                GameBoard[k - 1, i] = GameBoard[k,i];
                                GameBoard[k,i] = 0;
                                isMoved = true;
                            }
                        }
                    }
                }
            }

            randomGenerator();
        }
        public void moveDown()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (GameBoard[j, i] != 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (GameBoard[j, i] == GameBoard[k, i])
                            {
                                GameBoard[j, i] += GameBoard[k, i];
                                GameBoard[k, i] = 0;
                                isMoved = true;
                                break;
                            }
                            else if (GameBoard[k, i] == 0)
                                continue;
                            else if (GameBoard[j, i] != GameBoard[k, i])
                                break;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (GameBoard[j, i] != 0)
                    {
                        for (int k = j; k < 3; k++)
                        {
                            if (GameBoard[k + 1, i] == 0)
                            {
                                GameBoard[k + 1, i] = GameBoard[k, i];
                                GameBoard[k, i] = 0;
                                isMoved = true;
                            }
                        }
                    }
                }
            }

            randomGenerator();
        }
    }


}
