using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMProject.RealMachine.Components
{
    enum ComponentIds
    {
        UserMemory = 1,
        SupervisorMemory = 2,
        HardDrive = 3,
        Input = 4,
        Output = 5
    }

    public class ChannelDevice
    {
        FlashMemory m_input;
        Printer m_output;
        HardDrive m_hardDrive;
        UserMemory m_userMemory;

        int SB; //block, from which we will copy
        int DB; //block, to which we will copy
        int ST; //object, from which we will copy
        int DT; //object, to which we will copy

        public ChannelDevice(
            FlashMemory flashMemory,
            Printer printer,
            HardDrive hardDrive,
            UserMemory userMemory
            )
        {
            m_input = flashMemory;
            m_output = printer;
            m_hardDrive = hardDrive;
            m_userMemory = userMemory;
        }

        public char Read()
        {
            throw new NotImplementedException();
        }
        public char Write()
        {
            throw new NotImplementedException();
        }
    }
}
