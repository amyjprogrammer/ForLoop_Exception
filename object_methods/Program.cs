using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student1 = new Students("Jim", "Business", 2.8);
            Students student2 = new Students("Pam", "Art", 3.8);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }
    }
}
