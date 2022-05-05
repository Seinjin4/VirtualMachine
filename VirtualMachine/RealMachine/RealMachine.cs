using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMProject.RealMachine.Components;

namespace VMProject.RealMachine
{
    enum Component
    {
        Processor,
        UserMemory,
        Printer,
        HardDrive,
        FlashMemory
    }

    public class RealMachine
    {
        Processor m_rmProcessor;
        UserMemory m_rmUserMemory;
        MemoryPaging m_rmMemoryPaging;
        Printer m_printer;
        HardDrive m_hardDrive;
        FlashMemory m_flashMemory;
        ChannelDevice m_channelDevice;

        RealMachine()
        {
            m_printer = new Printer();
            m_hardDrive = new HardDrive();
            m_flashMemory = new FlashMemory();
            m_rmUserMemory = new UserMemory();
            m_rmMemoryPaging = new MemoryPaging(m_rmUserMemory);
            m_channelDevice = new ChannelDevice(
                m_flashMemory,
                m_printer,
                m_hardDrive,
                m_rmUserMemory
                );
            m_rmProcessor = new Processor();
        }
    }
}
