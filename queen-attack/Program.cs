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
      string queenLetter = "";
      string anotherLetter = "";
      string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };

      do
      {
        Console.Write("Enter queen letter coordinate: ");
        queenLetter = Console.ReadLine().ToUpper();
        Console.Write("Enter queen number coordinate: ");
        queenX = int.Parse(Console.ReadLine());
        queenY = Array.IndexOf(letters, queenLetter) + 1;
      } while (queenY == 0 || queenX < 1 || queenX > 8);

      Queen queen = new Queen(queenX, queenY);
      queen.ShowBoard(anotherX, anotherY);

      do
      {
        Console.Write("Enter another letter coordinate: ");
        anotherLetter = Console.ReadLine().ToUpper();
        Console.Write("Enter number coordinate: ");
        anotherX = int.Parse(Console.ReadLine());
        anotherY = Array.IndexOf(letters, anotherLetter) + 1;
      } while (anotherY == 0 || anotherX < 1 || anotherX > 8);

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