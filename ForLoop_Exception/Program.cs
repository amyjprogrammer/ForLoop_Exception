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

            ExcHandling();

            //creating an object for Class Book
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book2.author);
            Console.WriteLine(book1.title);
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

        //Exception Handling
        static void ExcHandling()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }

            //this will show the error message and why it broke
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                Console.Write("Enter a number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1);
            }
            //handling the different exceptions
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }
}
