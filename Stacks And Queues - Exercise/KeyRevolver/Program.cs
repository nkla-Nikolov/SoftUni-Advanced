using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int value = int.Parse(Console.ReadLine());
            int shotsFired = 0;
            int totalShotsFired = 0;

            while (locks.Count > 0 && bullets.Count > 0)
            {
                if (bullets.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    bullets.Pop();
                    locks.Dequeue();
                    shotsFired++;
                    totalShotsFired++;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                    shotsFired++;
                    totalShotsFired++;
                }

                if (shotsFired == sizeBarrel && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    shotsFired = 0;
                }
            }

            if (locks.Count == 0)
            {
                int moneyEarned = value - (priceBullet * totalShotsFired);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
                return;
            }
            if (bullets.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
