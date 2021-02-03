using System;
using System.Collections.Generic;

namespace Arrayer
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] grid = new int[5,5];


      grid[3,2] = 1;

      for (int y = 0; y < grid.GetLength(1); y++)
      {
          for (int x = 0; x < grid.GetLength(0); x++)
          {
            if (x == 0 || y == 0)
            {
              grid[x, y] = 1;
            }



            if (grid[x, y] == 0)
            {
              Console.Write(" ");
            }
            else if (grid[x, y] == 1)
            {
              Console.Write("#");
            }
          }
          Console.WriteLine();
      }




      string[] enemyNames = { "Viktor", "Tina", "Simon", "Arvid" };
      // string[] enemyNames = new string[4];

      List<int> enemyHp = new List<int>() { 33, 23, 99, 87 };

      enemyHp.Add(66);
      enemyHp.Add(102);
      enemyHp.Add(255);


      //Console.WriteLine(enemyHp.Count);

      // int i = 0;
      // while (i < enemyHp.Count)
      // {
      //   Console.WriteLine(enemyHp[i]);
      //   i++;
      // }

      // for (int i = 0; i < enemyHp.Count; i++)
      // {
      //   enemyHp[i] -= 10;
      //   Console.WriteLine(enemyHp[i]);
      // }

      // foreach (int eHp in enemyHp)
      // {
      //   Console.WriteLine(eHp);
      // }





      // 66 102
      // 0  1



      // int[] enemyHp = new int[8];
      // int[] enemyHp = { 7, 3, 56, 99, 102 };

      // 0 0 0 0 0 0 0 0
      // 0 1 2 3 4 5 6 7

      // enemyHp[3] = 99;

      // Console.WriteLine(enemyHp[8]);

      Console.ReadLine();



      // int enemyHp1 = 100;
      // int enemyHp2 = 100;
      // int enemyHp3 = 100;

      // if (enemyHp1 == 0)
      // {
      //   Console.WriteLine("Fiende 1 är död");
      // }




    }
  }
}
