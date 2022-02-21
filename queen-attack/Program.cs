using System;
using System.Collections.Generic;
using Board.Location;

namespace Board
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter queen X: ");
      int queenX = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter queen Y: ");
      int queenY = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter another X: ");
      int anotherX = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter another Y: ");
      int anotherY = int.Parse(Console.ReadLine());

      Queen queen = new Queen(queenX, queenY);

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