using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    class TVShow : Title
    {
        /*contains list of episodes
Overrides parent class's Rating to return an avera ge rating of Episode ratings.
Overrides ToString() method to return a string of the name of the show and number of episode.*/

        public int? NumberOfEpisodes;
        public TVShow(string n, int r, int? e)
        {
            Name = n;
            Rating = r;
            NumberOfEpisodes = e;
        }     
        public override string ToString()
        {
            return Name + ", " + NumberOfEpisodes + " episodes.";
        }
        
        /* need help with this?   public int? EpisodeRating;
        public int? AverageEpisodeRating;
        List<int> EpisodeList;
        public void GetEpisodeRating(int? r)
        {
            EpisodeRating = r;
        }

        public void CalculateAverageEpisodeRating()
        {

        }*/

    }
}
