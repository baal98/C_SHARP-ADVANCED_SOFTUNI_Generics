using System;
using System.Collections.Generic;
using System.Linq;

namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Threeuple<string, string, string> nameAddress = new Threeuple<string, string, string>("", "", "");
            Threeuple<string, int, bool> nameBeer = new Threeuple<string, int, bool>("", 0, true);
            Threeuple<string, double, string> nameBank = new Threeuple<string, double, string>("", 0, "");

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();

            nameAddress.ItemLeft = input1.Split(" ")[0] + " " + input1.Split(" ")[1];
            nameAddress.ItemMiddle = input1.Split(" ")[2];
            nameAddress.ItemRight = "";
            int ddd = input1.Split(" ").Length;
            for (int i = 3; i < input1.Split(" ").Length; i++)
            {
                nameAddress.ItemRight += input1.Split(" ")[i] + " ";
            }
            //nameAddress.ItemRight = string.Join(" ", input1.Skip(3));
            Console.WriteLine($"{nameAddress.ItemLeft} -> {nameAddress.ItemMiddle} -> {nameAddress.ItemRight}");

            nameBeer.ItemLeft = input2.Split(" ")[0];
            nameBeer.ItemMiddle = int.Parse(input2.Split(" ")[1]);
            string isDrunk = "";
            if (input2.Split(" ")[2] == "drunk")
            {
                nameBeer.ItemRight = true;
                isDrunk = "True";
            }
            else
            {
                nameBeer.ItemRight = false;
                isDrunk = "False";
            }
            Console.WriteLine($"{nameBeer.ItemLeft} -> {nameBeer.ItemMiddle} -> {isDrunk}");

            nameBank.ItemLeft = input3.Split(" ")[0];
            nameBank.ItemMiddle = double.Parse(input3.Split(" ")[1]);
            nameBank.ItemRight = input3.Split(" ")[2];
            Console.WriteLine($"{nameBank.ItemLeft} -> {nameBank.ItemMiddle} -> {nameBank.ItemRight}");
        }
    }
}