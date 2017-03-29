using System.Collections.Generic;

namespace Cities.Comparers
{
    public class AreaComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            double difference = y.Area - x.Area;

            if (difference < 0)
            {
                return -1;
            }
            else if (difference > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
           
        }
    }
}
