using Dln;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HardwareLib
{
    public abstract class AISPI
    {


        const int SCK = 0;
        const int SDI = 1;
        const int SEN = 2;
        const int SD_LDO = 3;
        const int CEN = 4;

        DiolanIO [] m_io = new DiolanIO[5];

        
        public abstract void WriteRegister(SynthHMC704LP4E.HMC704LP4E_REGS reg, uint data);
        public abstract uint ReadRegister(SynthHMC704LP4E.HMC704LP4E_REGS reg);
        
        public AISPI (Device dlnDevice)
        {

            m_io[SCK] = new DiolanIO(dlnDevice, 0);
            m_io[SDI] = new DiolanIO(dlnDevice, 1);
            m_io[SD_LDO] = new DiolanIO(dlnDevice, 2);
            m_io[SEN] = new DiolanIO(dlnDevice, 3);
            m_io[CEN] = new DiolanIO(dlnDevice, 4);

            m_io[SCK].Output();
            m_io[SDI].Output();
            m_io[SEN].Output();
            m_io[CEN].Output();

            m_io[SCK].Clear();
            m_io[SDI].Clear();           
            m_io[CEN].Set();
            m_io[CEN].Clear();
            m_io[SEN].Clear();


            m_io[SD_LDO].Input();

        }

        protected void SCKSet()
        {
            m_io[SCK].Value = true;
        }

        protected void SENSet()
        {
            m_io[SEN].Value = true;
        }

        protected void SENClr()
        {
            m_io[SEN].Value = false;
        }

        protected void SDIVal(byte val)
        {
            if (val == 0)
                m_io[SDI].Value = false;
            else
                m_io[SDI].Value = true;
        }
        protected byte ReadSD_LDO()
        {           
            return (byte)(m_io[SD_LDO].GetValue());
        }

        protected void SCKClr()
        {
            m_io[SCK].Value = false;
        }

        protected void SDIClr()
        {
            m_io[SDI].Value = false;
        }

        protected void SDISet()
        {
            m_io[SDI].Value = true;
        }
        
    }
}
