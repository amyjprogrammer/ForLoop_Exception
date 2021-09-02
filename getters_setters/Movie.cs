using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_setters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating; //makes it so this can only be accessed in the Movie class and can't be changed

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;  //changed to the method below so person can't put anything they want for rating
        }

        public string Rating 
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value =="NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            } 
        }

    }
}
