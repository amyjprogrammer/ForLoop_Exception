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

            Console.WriteLine(GetPow(3, 3));
            Console.WriteLine(GetPow(4, 3));

            //2d Array
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };

            Console.WriteLine(numberGrid[2, 1]); //the third one down and the second one (6)
            Console.WriteLine(numberGrid[0,0]);//1, because it is the first one down and first number
        }
        //Exponent Method
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}
