using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMProject.RealMachine.Components;

namespace VMProject.RealMachine
{
    public class MemoryPaging
    {
        UserMemory m_userMemory;
        int pagingBlock = 10;

        readonly Dictionary<int, int> m_memoryPagingDictionary = new Dictionary<int, int>()
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

        public MemoryPaging(UserMemory usermemory)
        {
            m_userMemory = usermemory;
        }

        public int MapPage(int page)
        {
            return (int)m_userMemory.Read(pagingBlock, page);
        }

        public void generatePaging()
        {
            m_memoryPagingDictionary
                .ToList()
                .ForEach(p =>
                    m_userMemory.Write(pagingBlock, p.Key, (char)p.Value)
                    );
        }
    }
}
