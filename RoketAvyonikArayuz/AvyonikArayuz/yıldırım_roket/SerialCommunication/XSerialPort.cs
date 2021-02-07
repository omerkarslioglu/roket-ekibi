using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roket_yer_bilgisayari.SerialCommunication
{
    class XSerialPort
    {

        public readonly SerialPort m_SerialPort;
        public static Action kickoffRead = null;
        byte[] buffer = new byte[1024];
        List<byte> RxBuffer = new List<byte>();

        private bool _isconnected;
        public bool IsConnected
        {
            get { return _isconnected; }
            set
            {
                _isconnected = value;
            }
        }


        private int _baudrate;

        public int BaudRate
        {
            get { return _baudrate; }
            set { _baudrate = value; }
        }



        private string _comport;

        public string ComPort
        {
            get { return _comport; }
            set { _comport = value; }
        }




        public void OpenPort(string comport, int baudrate)
        {

            if (IsOpen()) return;
            try
            {
                m_SerialPort.PortName = comport;
                m_SerialPort.BaudRate = baudrate;
                m_SerialPort.Open();
                IsConnected = true;
                ComPort = comport;
                BaudRate = baudrate;
            }
            catch
            {
                return;
            }

            kickoffRead = delegate
            {

                if (!m_SerialPort.IsOpen)
                {
                    return;
                }


                m_SerialPort.BaseStream.BeginRead(buffer, 0, buffer.Length, delegate (IAsyncResult ar)
                {
                    try
                    {
                        int actualLength = m_SerialPort.BaseStream.EndRead(ar);
                        byte[] received = new byte[actualLength];

                        Buffer.BlockCopy(buffer, 0, received, 0, actualLength);
                        raiseAppSerialDataEvent(received);
                    }
                    catch
                    {

                    }
                    kickoffRead();
                }, null);

            };
            kickoffRead();
        }


        bool check_queuke = false;

        async private void raiseAppSerialDataEvent(byte[] received)
        {
            
        }

        

        public void ClosePort()
        {
            if (!IsOpen()) return;
            m_SerialPort.DiscardInBuffer();
            m_SerialPort.DiscardOutBuffer();
            m_SerialPort.Dispose();
            m_SerialPort.Close();
            IsConnected = false;
        }

        public bool IsOpen()
        {
            return m_SerialPort.IsOpen;
        }


        public void Send(byte address, byte[] ndata)
        {
            if (!m_SerialPort.IsOpen) return;


           
        }



        public void Send_Terminal(byte[] data)
        {
            if (!m_SerialPort.IsOpen) return;
            m_SerialPort.Write(data, 0, data.Length);
        }
        
    }
}
