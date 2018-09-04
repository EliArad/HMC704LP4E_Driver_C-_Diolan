using Dln;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


// the data sheet: http://www.analog.com/media/en/technical-documentation/data-sheets/hmc703.pdf

namespace HardwareLib
{
    public class HMCMode : AISPI
    {
         
        public HMCMode(Device dlnDevice) : base (dlnDevice)
        {
            //If a rising edge on SEN is detected first HMC Mode is selected.
            SENSet();
        }

        /*
         
        The Master (host) both asserts SEN (Serial Port Enable) and clears SDI to indicate a WRITE cycle,
        followed by a rising edge of SCK.
        b. The slave (synthesizer) reads SDI on the 1st rising edge of SCK after SEN. SDI low indicates a Write
        cycle (/WR).
        c. Host places the six address bits on the next six falling edges of SCK, MSB first.
        d. Slave shifts the address bits in the next six rising edges of SCK (2-7).
        e. Host places the 24 data bits on the next 24 falling edges of SCK, MSB first.
        f. Slave shifts the data bits on the next 24 rising edges of SCK (8-31).
        g. The data is registered into the chip on the 32nd rising edge of SCK.
        h. SEN is cleared after a minimum delay of t5. This completes the write cycle.         
         
        */

        public override void WriteRegister(SynthHMC704LP4E.HMC704LP4E_REGS reg, uint data)
        {

            byte address = (byte)((((byte)reg & 0x3F)));

            SCKClr();

            SENClr();
            SENSet();

            SDIClr();

            SCKSet();
            SDIClr();
            SCKClr();

            // write the address 
            for (int i = 0 ; i < 6 ; i++)
            {
                if ((address & 0x20) == 0x20)
                {
                    SDISet();
                } 
                else                 
                {
                    SDIClr();
                }
                SCKSet();
                SCKClr();
                address = (byte)(address << 1);
            }
             
            // Write 24 bits data , MSB first 
            for (int i = 0; i < 24; i++)
            {
                SCKClr();
                if ((data & 0x800000) == 0x800000)
                {
                    SDISet();
                }
                else
                {
                    SDIClr();
                }                                             
                SCKSet();
                data = (uint)(data << 1);
            }
            SCKClr();
            SCKSet();
            SCKClr();
            SENClr();
            
        }

        /*
         a. The Master (host) asserts both SEN (Serial Port Enable) and SDI to indicate a READ cycle, followed
        by a rising edge SCK. Note: The Lock Detect (LD) function is usually multiplexed onto the LD_SDO
        pin. It is suggested that LD only be considered valid when SEN is low. In fact LD will not toggle until
        the first active data bit toggles on LD_SDO, and will be restored immediately after the trailing edge
        of the LSB of serial data out as shown in Figure 42.
        b. The slave (synthesizer) reads SDI on the 1st rising edge of SCK after SEN. SDI high initiates the
        READ cycle (RD)
        c. Host places the six address bits on the next six falling edges of SCK, MSB first.
        d. Slave registers the address bits on the next six rising edges of SCK (2-7).
        e. Slave switches from Lock Detect and places the requested 24 data bits on SD_LDO on the next 24
        rising edges of SCK (8-31), MSB first .
        f. Host registers the data bits on the next 24 falling edges of SCK (8-31).
        g. Slave restores Lock Detect on the 32nd rising edge of SCK.
        h. SEN is cleared after a minimum delay of t6. This completes the cycle.
         
         */

        public override uint ReadRegister(SynthHMC704LP4E.HMC704LP4E_REGS reg)
        { 
           
            byte address = (byte)((((byte)reg & 0x3F)));

            SCKClr();

            SENClr();
            SENSet();
            
            SDISet();

            SCKSet();
            SDIClr();
            SCKClr();

            // write the address 
            for (int i = 0; i < 6; i++)
            {
                           
                if ((address & 0x20) == 0x20)
                {
                    SDISet();
                }
                else
                {
                    SDIClr();
                }
                SCKSet();
                SCKClr();
                address = (byte)(address << 1);
            }

            SCKSet();
            

            uint data = 0;
            uint x = 0;
            // read 24 bits data , MSB first 
            for (int i = 0; i < 24; i++)
            {

                SCKClr();
                x = ReadSD_LDO();
                //Console.Write(x);
                data |= x;
                data = data << 1;
                //Thread.Sleep(1);                
                SCKSet();

            }
            //Console.WriteLine();

            SCKClr();
            SCKSet();
            SCKClr();
            SENClr();

            return (data >> 1);
        }
    }
}
