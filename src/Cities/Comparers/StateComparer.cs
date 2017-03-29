using System.Collections.Generic;

namespace Cities.Comparers
{
    public class StateComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return string.Compare(x.State, y.State);
        }
    }
}
