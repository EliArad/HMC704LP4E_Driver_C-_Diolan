using Dln;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareLib
{
    public class Diolan
    {
        protected Device m_device;
        Connection m_connection;
        uint m_ID;
        uint m_SN;
        public Diolan()
        {
            // Connect to DLN server
            m_connection = Library.Connect("localhost", Connection.DefaultPort);

            // Open device
            if (Device.Count() == 0)
            {
                throw (new SystemException("No DLN-series adapters have been detected."));
            }
            m_device = Device.Open();
            m_ID = m_device.ID;
            m_SN = m_device.SN;
        }
        public Diolan(uint SN)
        { // Connect to DLN server
            m_connection = Library.Connect("localhost", Connection.DefaultPort);

            // Open device
            if (Device.Count() == 0)
            {
                throw (new SystemException("No DLN-series adapters have been detected."));
            }
            m_device = Device.OpenBySn(SN);
            m_ID = m_device.ID;
            m_SN = m_device.SN;
        }
      
        public uint SN
        {
            get
            {
                return m_SN;
            }
        }
        public uint ID
        {
            get
            {
                return m_ID;
            }
        }
        public void Close()
        {
            Library.Disconnect(m_connection);
        }
        public Device DiolanDevice
        {
            get
            {
                return m_device;
            }

        }

    }
}
