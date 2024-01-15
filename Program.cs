using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OneWayAttribute way of creating an array
            int[] luckyNumbers = { 4, 5, 8, 9, };
            Console.WriteLine(luckyNumbers[0]);
            //if you want to populate it later, the 5 is the size
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "John";
            friends[2] = "Peter";
            Console.WriteLine(friends[0]);

            Console.ReadLine();
        }
    }
}
