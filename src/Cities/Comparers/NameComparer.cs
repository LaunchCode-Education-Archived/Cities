using System.Collections.Generic;

namespace Cities.Comparers
{
    public class NameComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
