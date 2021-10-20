using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = "); int n = Convert.ToInt32(Console.ReadLine());
            var listOfNumbers = new List<int>();
            
            for(int i = 0; i < n; i++)
            {
                int number = i, reversed = 0;
                int currentNumber = number;
                while (number > 0)
                {
                    reversed *= 10;
                    reversed += number % 10;
                    number /= 10;
                }
                if (currentNumber == reversed)
                    listOfNumbers.Add(currentNumber);
            }
            foreach(var item in listOfNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
