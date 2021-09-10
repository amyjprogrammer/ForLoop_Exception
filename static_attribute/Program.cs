using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);  //shows one
            Song kashmir = new Song("Kashmir", "Led Zepplin", 150);
            Console.WriteLine(kashmir.getsongCount()); //shows two

            Console.WriteLine(Math.Sqrt(144));//static method (ones already built in)

            UsefulTools.SayHi("Amy");//using the class built in Usefull Tools

            Console.ReadLine();
        }
    }
}
