using System;

namespace ForLoop_Exception
{
    class Program
    {
        //for loop 
        static void Main(string[] args)
        {
            for(int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int[] luckyNumbers = { 4, 8, 10, 13, 24 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }
    }
}
