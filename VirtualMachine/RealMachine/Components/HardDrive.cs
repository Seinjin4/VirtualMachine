using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMProject.RealMachine.Components
{
    public class HardDrive
    {
        char[] m_array = {};

        public char Read(int address)
        {
            return m_array[address];
        }

        public void Write(int address, char val)
        {
            m_array[address] = val;
        }
    }
}
