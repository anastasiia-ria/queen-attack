using System;

namespace Board.Location
{
  public class Queen
  {
    public int QueenX { get; set; }
    public int QueenY { get; set; }

    public Queen(int queenX, int queenY)
    {
      QueenX = queenX;
      QueenY = queenY;
    }
    public bool QueenAttack(int anotherX, int anotherY)
    {
      int difference = anotherX - QueenX;
      bool attack = false;
      if (anotherX == QueenX || anotherY == QueenY || QueenY + difference == anotherY || QueenY - difference == anotherY)
      {
        attack = true;
      }
      return attack;
    }

    public void color(bool black)
    {
      if (black)
      {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
      }
      else
      {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
      }
    }
    public void ShowBoard(int anotherX, int anotherY)
    {
      ConsoleColor currentForeground = Console.ForegroundColor;
      ConsoleColor currentBackground = Console.BackgroundColor;
      bool black = false;

      string[] letters = new string[] { "  ", "A", "B", "C", "D", "E", "F", "G", "H" };
      for (int i = 0; i < 9; i++)
      {
        for (int j = 0; j < 9; j++)
        {
          color(black);
          black = !black;
          string square = "  ";
          if (QueenX == i && QueenY == j)
          {
            square = "Q ";
          }
          else if (anotherX == i && anotherY == j && i != 0 && j != 0)
          {
            square = "A ";
          }

          if (i == 0)
          {
            if (j == 8)
            {
              current(currentBackground, currentForeground);
              Console.WriteLine(letters[j] + " ");
            }
            else
            {
              current(currentBackground, currentForeground);
              Console.Write(letters[j] + " ");
            }
          }
          else if (j == 0 && i > 0)
          {
            current(currentBackground, currentForeground);
            Console.Write(i + " ");
          }
          else if (j == 8)
          {
            Console.Write(square);
            current(currentBackground, currentForeground);
            Console.WriteLine();
          }
          else
          {
            Console.Write(square);
          }
        }
      }
    }
    public void current(ConsoleColor currentBackground, ConsoleColor currentForeground)
    {
      Console.BackgroundColor = currentBackground;
      Console.ForegroundColor = currentForeground;
    }
  }
}