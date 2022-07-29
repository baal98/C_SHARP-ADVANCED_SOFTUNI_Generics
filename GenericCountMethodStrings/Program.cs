using System;

namespace GenericCountMethodStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                box.Add(Console.ReadLine());
            }
            
            string element = Console.ReadLine();

            Console.WriteLine(box.Count(element));

        }
    }
}
