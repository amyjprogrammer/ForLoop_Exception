using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "dog");//wrong value for rating
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            shrek.Rating = "PG-13";

            Console.WriteLine(shrek.Rating);//updated to PG-13, because that is a valid input

            Console.WriteLine(avengers.Rating); //sets it to NR instead
        }
    }
}
