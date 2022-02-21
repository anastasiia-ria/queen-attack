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

    public void ShowBoard(int anotherX, int anotherY)
    {
      for (int i = 0; i < 8; i++)
      {
        for (int j = 0; j < 8; j++)
        {
          string square = "_";
          if (QueenX - 1 == i && QueenY - 1 == j)
          {
            square = "Q";
          }
          else if (anotherX - 1 == i && anotherY - 1 == j)
          {
            square = "A";
          }

          if (j == 0)
          {
            Console.Write("|" + square + "|");
          }
          else if (j == 7)
          {
            Console.WriteLine(square + "|");
          }
          else
          {
            Console.Write(square + "|");
          }
        }
      }
    }
  }
}