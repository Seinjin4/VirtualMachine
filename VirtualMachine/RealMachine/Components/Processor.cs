using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMProject.RealMachine.Components
{
    public class Processor
    {
        MemoryPaging m_memoryPaging;
        UserMemory m_userMemory;
        ChannelDevice m_channelDevice;

        int PRT; //command reader
        int STK; //stack head
        int ST; //status flags
        int MODE; //processor mode
        int PI; // p interupts
        int SI; // s interupts
        int TI; // timer

        public Processor(
            MemoryPaging memoryPaging,
            UserMemory userMemory,
            ChannelDevice channelDevice)
        {
            m_memoryPaging = memoryPaging;
            m_userMemory = userMemory;
            m_channelDevice = channelDevice;
        }
    }
}
