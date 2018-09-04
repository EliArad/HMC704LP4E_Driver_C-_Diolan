using Dln;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareLib
{
    public class DiolanIO
    {

        Device m_device;      
        int m_pinNum = -1;
        Dln.Gpio.Pin pin;         
        Diolan m_dln;

        public DiolanIO(Device device, int pinNum)
        {
            m_pinNum = pinNum;
            m_device = device;
            try
            {               
                int pinCount = m_device.Gpio.Pins.Count;
                pin = m_device.Gpio.Pins[m_pinNum];
                pin.Enabled = true;
            }
            catch (Exception err)
            {
                throw (new SystemException(err.Message));
            }
        }

        public DiolanIO(int pinNum)
        {
            m_pinNum = pinNum;

            m_dln = new Diolan();
            m_device = m_dln.DiolanDevice;

            try
            {
                int pinCount = m_device.Gpio.Pins.Count;
                pin = m_device.Gpio.Pins[m_pinNum];
                pin.Enabled = true;
            }
            catch (Exception err)
            {
                throw (new SystemException(err.Message));
            }
        }
 
        public void Output()
        {            
            pin.Direction = 1; // output
        }
        public void Input()
        {
            pin.Direction = 0;
        }

        public void PullDown()
        {
            pin.PulldownEnabled = true;
        }

        public void Enable(bool enable)
        {
           pin.Enabled = enable;
        }
        public void SetValue(int v)
        {
            if (pin.Direction == 1)
                pin.OutputValue = v;            
        }
        public void SetValue(ushort v)
        {
            if (pin.Direction == 1)
                pin.OutputValue = v;
        }
        public void SetValue(byte v)
        {
            if (pin.Direction == 1)
                pin.OutputValue = v;
        }
        public void SetValue(uint v)
        {
            if (pin.Direction == 1)
                pin.OutputValue = (int)v;
        }

        public void Set()
        {
            if (pin.Direction == 1)
            {
                pin.OutputValue = 1;
            }
        }

        public void Clear()
        {
            if (pin.Direction == 1)
            {
                pin.OutputValue = 0;
            }
        }

        public int GetValue()
        {
            if (pin.Value == 1)
            {
                return 1;
            } else
            {
                return 0;
            }


        }

        public bool Value
        {
            get
            {
                return pin.OutputValue == 1? true : false;
            }
            set
            {
                if (pin.Direction == 1)
                {
                    if(value == true)
                        pin.OutputValue = 1;
                    else
                        pin.OutputValue = 0;

                }
            }
        }
    }
}
