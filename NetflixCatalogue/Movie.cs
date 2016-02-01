using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Movie : Title
    {
        Genre genre = new Genre();

        public int Duration;  
        public Movie(string n, int r, int d)
        {
            Name = n;
            Rating = r;
            Duration = d;
        }
        public override string ToString()
        {
            return Name + ", " + Duration + " minutes.";
        }

  
    }
}
