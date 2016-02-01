using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Genre : IEnumerable
    {
        List<Title> TitleList = new List<Title>();
        List<Genre> GenreList = new List<Genre>();
        public Genre()
        {
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }        
        public static Genre operator +(Genre GenreOne, Genre GenreTwo)
        {
            Genre AggregatedGenre = new Genre();
            return AggregatedGenre;
        }        
        public static Genre operator +(Genre AggregatedGenre, Title Name)
        {
            Genre TitleGenre = new Genre();
            return TitleGenre;
        }
       
        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void PrintTitles()
        {
            foreach (Title title in TitleList)
            {
                Console.WriteLine(title);
                Console.ReadKey();
            }
        }

    }
}

