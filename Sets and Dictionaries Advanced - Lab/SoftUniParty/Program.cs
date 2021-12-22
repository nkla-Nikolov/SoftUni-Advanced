using System;
using System.Collections.Generic;
using System.Data;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string guests = Console.ReadLine();

            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();

            while (guests != "PARTY")
            {
                if (char.IsDigit(guests[0]))
                {
                    vip.Add(guests);
                }
                else
                {
                    regular.Add(guests);
                }
                
                guests = Console.ReadLine();
            }

            guests = Console.ReadLine();

            while (guests != "END")
            {
                if (vip.Contains(guests))
                {
                    vip.Remove(guests);
                }
                else
                {
                    regular.Remove(guests);
                }
                
                
                guests = Console.ReadLine();
            }

            Console.WriteLine(vip.Count + regular.Count);

            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
