using System;
using System.Collections.Generic;

namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyTuple<string, string> nameTown = new MyTuple<string, string>("", "");
            MyTuple<string, int> nameBeer = new MyTuple<string, int>("", 0);
            MyTuple<int, double> intDouble = new MyTuple<int, double>(0, 0);

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();

            nameTown.ItemLeft = input1.Split(" ")[0] + " " + input1.Split(" ")[1];
            nameTown.ItemRight = input1.Split(" ")[2];
            Console.WriteLine($"{nameTown.ItemLeft} -> {nameTown.ItemRight}");

            nameBeer.ItemLeft = input2.Split(" ")[0];
            nameBeer.ItemRight = int.Parse(input2.Split(" ")[1]);
            Console.WriteLine($"{nameBeer.ItemLeft} -> {nameBeer.ItemRight}");

            intDouble.ItemLeft = int.Parse(input3.Split(" ")[0]);
            intDouble.ItemRight = double.Parse(input3.Split(" ")[1]);
            Console.WriteLine($"{intDouble.ItemLeft} -> {intDouble.ItemRight}");
        }
    }
}
