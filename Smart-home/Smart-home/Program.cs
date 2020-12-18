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
            serialPort.ReadTimeout = 3000 ;
            serialPort.WriteTimeout = 3000;
           
            string temp=null;
           
            serialPort.Open();
            serialPort.WriteLine(temp);
            while (true)
            {
                string job = Console.ReadLine();
                switch (job)
                {
                    case "read":
                        Read();
                        break;
                    case "send":
                        Send();
                        break;

                    default:
                        break;
                }
               
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
        public static void Send()
        {
            string comand;
            while ((comand=Console.ReadLine())!="exit")
            {
                string temp = null;
                switch (comand)
                {
                    case "off":
                        temp = "0";
                        break;
                    case "on":
                        temp = "1";
                        break;
                    default:
                        break;
                }
                Console.WriteLine(temp);
                serialPort.WriteLine(temp);
                Read();

            }
          
            
            
        }
    }

}










