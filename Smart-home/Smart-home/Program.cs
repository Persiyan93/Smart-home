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
            byte[] p = { 10, 11, 12, 13 };
            Console.WriteLine(p);
            serialPort = new SerialPort("COM3", 9600);
            serialPort.ReadTimeout = 1500;
            serialPort.WriteTimeout = 1500;
            serialPort.Open();
            serialPort.Write(p, 0, 2);
            while (true)
            {
                Read();
            }
        }
        public static void Read()
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










