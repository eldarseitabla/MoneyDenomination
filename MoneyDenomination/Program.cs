using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a simple program to enter an amount of money and work different denominations of notes/coins e.g.

// 125.25

// Total €50s is 2
// Total €20s is 1
// Total €10s is 0
// Total €5s is 1
// etc etc
namespace MoneyDenomination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            int[] notes = new int[] { 50, 20, 10, 5, 2, 1 };
            int[] cents = new int[] { 50, 20, 10, 5, 2, 1 };

            int euro = (int)amount;
            int cent = (int)((amount - euro) * 100);

            foreach (var note in notes)
            {
                int noteCount = euro / note;
                euro %= note;
                if (noteCount > 0)
                {
                    Console.WriteLine($"Total \u00A3{note}s is {noteCount}");
                }
            }

            foreach (var centCoin in cents)
            {
                int coinCount = cent / centCoin;
                cent %= centCoin;
                if (coinCount > 0)
                {
                    Console.WriteLine($"Total \u00A3" +
                        $"0.{centCoin}s is {coinCount}");
                }
            }

            Console.ReadLine();
        }
    }

}
