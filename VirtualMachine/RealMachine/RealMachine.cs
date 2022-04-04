using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMProject.RealMachine.Components;

namespace VMProject.RealMachine
{
    public class RealMachine
    {
        RmProcessor m_rmProcessor;
        RmUserMemory m_rmUserMemory;
        RmMemoryPaging m_rmMemoryPaging;
        Printer m_printer;
        HardDrive m_hardDrive;
        FlashMemory m_flashMemory;

        RealMachine()
        {
            m_rmProcessor = new RmProcessor();
            m_rmUserMemory = new RmUserMemory();
            m_rmMemoryPaging = new RmMemoryPaging();
            m_printer = new Printer();
            m_hardDrive = new HardDrive();
            m_flashMemory = new FlashMemory();
        }
    }
}
