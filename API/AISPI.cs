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
        protected bool m_configured = false;
        DiolanIO [] m_io = new DiolanIO[5];

        Device m_dlnDevice;
        public abstract void WriteRegister(SynthHMC704LP4E.HMC704LP4E_REGS reg, uint data);
        public abstract uint ReadRegister(SynthHMC704LP4E.HMC704LP4E_REGS reg);
        
        public AISPI (Device dlnDevice)
        {

            m_dlnDevice = dlnDevice;

        }

        public void ConfigurePins(int SCK_Io, int SDI_Io, int SD_LDO_Io, int SEN_Io , int CEN_Io)
        {

            m_io[SCK] = new DiolanIO(m_dlnDevice, SCK_Io);
            m_io[SDI] = new DiolanIO(m_dlnDevice, SDI_Io);
            m_io[SD_LDO] = new DiolanIO(m_dlnDevice, SD_LDO_Io);
            m_io[SEN] = new DiolanIO(m_dlnDevice, SEN_Io);
            m_io[CEN] = new DiolanIO(m_dlnDevice, CEN_Io);

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
            m_configured = true;
        }

        public enum HMC704_CHIP_NUMBER
        {
            HMC704_CHIP1,
            HMC704_CHIP2,
            HMC704_CHIP3
        }
        public void ConfigurePins(HMC704_CHIP_NUMBER  chipNum)
        {
            if (chipNum == HMC704_CHIP_NUMBER.HMC704_CHIP1)
            {
                m_io[SCK] = new DiolanIO(m_dlnDevice, 7);
                m_io[SDI] = new DiolanIO(m_dlnDevice, 8);
                m_io[SD_LDO] = new DiolanIO(m_dlnDevice, 2);
                m_io[SEN] = new DiolanIO(m_dlnDevice, 3);
                m_io[CEN] = new DiolanIO(m_dlnDevice, 4);
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
                m_configured = true;
            }

            if (chipNum == HMC704_CHIP_NUMBER.HMC704_CHIP2)
            {


            }

            if (chipNum == HMC704_CHIP_NUMBER.HMC704_CHIP3)
            {


            }
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
