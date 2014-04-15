using System;

class KukataDance
{
    static void Main()
    {
        int inputRows = int.Parse(Console.ReadLine());

        string[] inputMoves = new string[inputRows]; //Rows of input

        for (int i = 0; i < inputRows; i++)
        {
            inputMoves[i] = Console.ReadLine();
        }

        //Dance floor
        string[,] dancing = 
        { 
            {"RED", "BLUE", "RED"},
            {"BLUE", "GREEN", "BLUE"},
            {"RED", "BLUE", "RED"}
        };
        
        int currentRow = 1;
        int currentCol = 1;

        bool left = false;
        bool right = false;
        bool up = true;
        bool down = false;

        int direction = 0;

        for (int i = 0; i < inputMoves.Length; i++)
        {
            for (int j = 0; j < inputMoves[i].Length; j++)
            {
                if (inputMoves[i][j].ToString() == "W")
                {
                    if (up)
                    {
                        if (currentRow == 0)
                        {
                            currentRow += 2;
                        }
                        else
                        {
                            currentRow--;
                        }
                    }
                    else if (down)
                    {
                        if (currentRow == 2)
                        {
                            currentRow -= 2;
                        }
                        else
                        {
                            currentRow++;
                        }
                    }
                    else if (left)
                    {
                        if (currentCol == 0)
                        {
                            currentCol += 2;
                        }
                        else
                        {
                            currentCol--;
                        }
                    }
                    else if (right)
                    {
                        if (currentCol == 2)
                        {
                            currentCol -= 2;
                        }
                        else
                        {
                            currentCol++;
                        }
                    }
                }

                else if (inputMoves[i][j].ToString() == "L")
                {
                    direction++;
                    if (direction == 4)
                    {
                        direction = 0;
                    }
                }

                else if (inputMoves[i][j].ToString() == "R")
                {
                    direction--;
                    if (direction == -4)
                    {
                        direction = 0;
                    }
                }

                if (direction == 0)
                {
                    up = true;
                    left = false;
                    down = false;
                    right = false;
                }
                else if (direction == 1 || direction == -3)
                {
                    left = true;
                    up = false;
                    down = false;
                    right = false;
                }
                else if (direction == 2 || direction == -2)
                {
                    down = true;
                    up = false;
                    left = false;
                    right = false;
                }
                else if (direction == 3 || direction == -1)
                {
                    right = true;
                    up = false;
                    left = false;
                    down = false;
                }

                //Print position
                if (j == inputMoves[i].Length - 1)
                {
                    Console.WriteLine(dancing[currentRow, currentCol]);

                   currentRow = 1;
                   currentCol = 1;

                   direction = 0;
                   left = false;
                   right = false;
                   up = true;
                   down = false;
                }
            }
        }
    }
}
