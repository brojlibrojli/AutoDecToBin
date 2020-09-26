using System;

namespace ManualDecToBin
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert Integer: ");
            int value = 0;
            bool isNumber = int.TryParse(Console.ReadLine(), out value);
            while (!isNumber)
            {
                Console.WriteLine("It is no number");
                isNumber = int.TryParse(Console.ReadLine(), out value);
            }
            while (isNumber)
            {
                string binary = Convert.ToString(value, 2);
                Console.Write("Decimal to Binary: " + binary + "\n");
                isNumber = int.TryParse(Console.ReadLine(), out value);

            }
        }
    }
}