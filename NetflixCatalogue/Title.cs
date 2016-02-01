using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Title
    {
        private string name;
        private int? rating;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int? Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }
        public Title(string name, int? rating)
        {
            Name = name;
            Rating = rating;
        }
        public override string ToString()
        {
            return Name + ", " + Rating;
        }
        public Title()
        {
            Name = null;
            Rating = null;
        }
    }
}
