using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMProject.RealMachine.Components
{
    public class UserMemory
    {
        char[] m_array = new char[1024];

        public char Read(int block, int address)
        {
            return m_array[block * 16 + address];
        }

        public void Write(int block, int address, char val)
        {
            m_array[block * 16 + address] = val;
        }
    }
}
