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
      Console.WriteLine("Enter queen X: ");
      int queenX = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter queen Y: ");
      int queenY = int.Parse(Console.ReadLine());

      Queen queen = new Queen(queenX, queenY);
      queen.ShowBoard(anotherX, anotherY);

      Console.WriteLine("Enter another X: ");
      anotherX = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter another Y: ");
      anotherY = int.Parse(Console.ReadLine());

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