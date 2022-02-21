using System;
using System.Collections.Generic;
using Board.Location;

namespace Board
{
  public class Program
  {
    public static void Main()
    {
      int anotherX = 0;
      int anotherY = 0;
      int queenX = 0;
      int queenY = 0;

      do
      {
        Console.Write("Enter queen X: ");
        queenX = int.Parse(Console.ReadLine());
        Console.Write("Enter queen Y: ");
        queenY = int.Parse(Console.ReadLine());
      } while (queenX < 1 || queenX > 8 || queenY < 1 || queenY > 8);

      Queen queen = new Queen(queenX, queenY);
      queen.ShowBoard(anotherX, anotherY);

      do
      {
        Console.Write("Enter another X: ");
        anotherX = int.Parse(Console.ReadLine());
        Console.Write("Enter another Y: ");
        anotherY = int.Parse(Console.ReadLine());
      } while (anotherX < 1 || anotherX > 8 || anotherY < 1 || anotherY > 8);

      queen.ShowBoard(anotherX, anotherY);

      bool attack = queen.QueenAttack(anotherX, anotherY);
      if (attack)
      {
        Console.WriteLine("Queen attacks!");
      }
      else
      {
        Console.WriteLine("Queen does not attack!");
      }
    }
  }
}