using System.Collections.Generic;

namespace Cities.Comparers
{
    public class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return y.Population - x.Population;
        }
    }
}
