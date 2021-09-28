using System;
using System.Collections.Generic;
using System.Linq;

namespace cd_c_puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            //RandomArray();
            //TossCoin();
            //TossMultipleCoins(10);
            Names();
        }

        private static int[] RandomArray()
        {
            // Random Array
            int[] array1 = new int[10];
            Random rand = new Random();
            int sum = 0; 
            for (int idx = 0; idx < array1.Length; idx++)
            {
                array1[idx] = rand.Next(5, 25);
                sum += array1[idx];
            }
            foreach (int item in array1)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Max is" + " - " + $"{array1.Max()}");
            System.Console.WriteLine("Min is" + " - " + $"{array1.Min()}");
            System.Console.WriteLine("Sum is" + " - " + $"{sum}");
            return array1;
        }
        private static int TossCoin()
        {
            System.Console.WriteLine("Tossing a Coin!");
            int heads = 0;
            int tails = 1;
            Random rando = new Random();
            int CoinToss = rando.Next(0, 2);
            if (CoinToss == heads)
            {
                System.Console.WriteLine("Heads");
            }
            if (CoinToss == tails)
            {
                System.Console.WriteLine("Tails");
            }
            return CoinToss;
        }

        private static double TossMultipleCoins(int num)
        {
            int headscounter = 0;
            int tailscounter = 0;
            int result = TossCoin();
            for (int t = 0; t < num; t++)
            {
                TossCoin();
                if (result == 0)
                {
                    headscounter++;
                }
                if (result == 1)
                {
                    tailscounter++;
                }
            }
            double TossRatio = (double)headscounter/num;
            System.Console.WriteLine($"Heads occurs: {TossRatio}");
            return TossRatio;
        }

        private static List<string> Names()
        {
            List<string> listNames = new List<string>();
            listNames.Add("Todd");
            listNames.Add("Tiffany");
            listNames.Add("Charlie");
            listNames.Add("Geneva");
            listNames.Add("Sydney");

            var rnd = new Random();
            var randomOrdered = listNames.OrderBy(item => rnd.Next());

            List<string> longNames = new List<string>();

            foreach (var value in randomOrdered)
            {
                System.Console.WriteLine(value);
                if (value.Length > 5)
                {
                    longNames.Add(value);
                }
                
            }
            foreach (var value in longNames)
            {
                System.Console.WriteLine(value);
            }

            return longNames;
        }


    }
}
