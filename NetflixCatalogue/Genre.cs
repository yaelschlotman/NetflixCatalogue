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
        /*Contains list of titles.
        Implement custom iterator to iterate over those Titles.        
        */
        List<Title> TitleList = new List<Title>();



        public Genre(List<Title> TitleList)
        {
            this.TitleList = TitleList;
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // Overload plus (+) operator to take in two Genres and return the aggregated Genre.
        public static Genre operator + (Genre GenreOne, Genre GenreTwo )
        {
            Genre AggregatedGenre = new Genre(GenreOne.TitleList);
            return AggregatedGenre;
        }
        //Overload plus (+) operator to take in a Genre and a Title to return the aggregated Genre.
        public static Genre operator + (Genre AggregatedGenre, Title Name)
        {
            Genre TitleGenre = new Genre(AggregatedGenre.TitleList);
            return TitleGenre ;
        }

    }
}

