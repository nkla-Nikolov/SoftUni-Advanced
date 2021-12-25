using System;
using System.Text;

namespace Tuples
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();

            string name = personInfo[0] + ' ' + personInfo[1];
            string town = personInfo[personInfo.Length - 1];

            string[] beerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string beerName = beerInfo[0];
            int beerCount = int.Parse(beerInfo[1]);

            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int integer = int.Parse(numbers[0]);
            double num = double.Parse(numbers[1]);


            MyTuple<string, string> personalInfo = new MyTuple<string, string>(name, town);
            MyTuple<string, int> personBeerInfo = new MyTuple<string, int>(beerName, beerCount);
            MyTuple<int, double> nums = new MyTuple<int, double>(integer, num);

            Console.WriteLine(personalInfo.GetItems());
            Console.WriteLine(personBeerInfo.GetItems());
            Console.WriteLine(nums.GetItems());
        }
    }
}
