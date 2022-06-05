using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == " PG" || value == " PG-13" || value == " G" || value == " R")
                {
                    rating = value;
                }
                else
                {
                    rating = "Not Rated";
                }
            }
        }
    }
}
