using System.Collections.Generic;

namespace Cities.Comparers
{
    public class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers { get; set; } = new List<IComparer<City>>();

        public int Compare(City x, City y)
        {
            int comparison = 0;
            int numComparisons = 0;
            int totalComparisons = Comparers.Count;

            while (comparison == 0 && numComparisons < totalComparisons)
            {
                comparison = Comparers[numComparisons].Compare(x, y);
                numComparisons++;
            }

            return comparison;
        }
    }
}
