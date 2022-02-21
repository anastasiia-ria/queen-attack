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
  }
}