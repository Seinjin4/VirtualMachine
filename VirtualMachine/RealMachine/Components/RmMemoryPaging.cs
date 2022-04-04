using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMProject.RealMachine
{
    public class RmMemoryPaging
    {
        Dictionary<int, int> m_memoryPaging = new Dictionary<int, int>()
        {
            {0, 1},
            {1, 5},
            {2, 9},
            {3, 13},
            {4, 17},
            {5, 21},
            {6, 25},
            {7, 29},
            {8, 33},
            {9, 37},
            {10, 41},
            {11, 45},
            {12, 49},
            {13, 53},
            {14, 57},
            {15, 61}
        };

        public int MapPage(int page)
        {
            return m_memoryPaging.ElementAt(page).Value;
        };
    }
}
