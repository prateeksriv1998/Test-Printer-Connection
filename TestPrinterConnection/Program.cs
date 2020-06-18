using System;
using System.Net;
using System.Net.Sockets;

namespace TestPrinterConnection
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please Enter the IP Address:");
                string host = Console.ReadLine();
                Console.WriteLine("Please Enter the Port Number:");
                int port = Convert.ToInt32(Console.ReadLine());
                IPAddress[] IPs = Dns.GetHostAddresses(host);
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Console.WriteLine($"Establishing Connection to {host}");
                s.Connect(IPs, port);
                Console.WriteLine("Connection Established.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
