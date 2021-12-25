using System;
using System.Text;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personalInfo = Console.ReadLine().Split();
            string names = personalInfo[0] + ' ' + personalInfo[1];
            string adress = personalInfo[2];
            StringBuilder sb = new StringBuilder();

            for (int i = 3; i < personalInfo.Length; i++)
            {
                sb.Append(personalInfo[i]);
                sb.Append(' ');
            }

            string town = sb.ToString();
            string[] beerInfo = Console.ReadLine().Split();
            string beerName = beerInfo[0];
            int litersOfBeer = int.Parse(beerInfo[1]);
            bool drunkOrNot = beerInfo[2] == "drunk";

            string[] bankInfo = Console.ReadLine().Split();
            string name = bankInfo[0];
            double accountBalance = double.Parse(bankInfo[1]);
            string bankName = bankInfo[2];

            MyThreeuple<string, string, string> person = new MyThreeuple<string, string, string>(names, adress, town);
            MyThreeuple<string, int, bool>
                beer = new MyThreeuple<string, int, bool>(beerName, litersOfBeer, drunkOrNot);
            MyThreeuple<string, double, string> bank =
                new MyThreeuple<string, double, string>(name, accountBalance, bankName);

            Console.WriteLine(person);
            Console.WriteLine(beer);
            Console.WriteLine(bank);
        }
    }
}
