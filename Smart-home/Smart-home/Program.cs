using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace Smart_home
{
    public class Program
    {
        static SerialPort serialPort;
        static void Main(string[] args)

        {
            serialPort = new SerialPort();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace test
{
    class Program
    {
        static SerialPort serialPort;
        static void Main(string[] args)
        {
            serialPort = new SerialPort("COM3", 9600);
            serialPort.ReadTimeout = 1500;
            serialPort.WriteTimeout = 1500;
            serialPort.Open();

            while (true)
            {
                Read();
            }

        }
        static void Read()
        {
            try
            {
                string message = serialPort.ReadLine();
                Console.WriteLine(message);

            }
            catch (Exception)
            {
                serialPort.Close();
                Console.Write("exception");
                return;
            }

        }
    }
}





