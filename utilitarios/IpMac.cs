using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace utilitarios
{
    public class IpMac
    {
        public string GetIP()
        {
            string IP4Address = String.Empty;

            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily == AddressFamily.InterNetwork)
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }

            return IP4Address;
        }
        public string GetMACAddress2()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String macAddress = String.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (macAddress == String.Empty)
                {
                    macAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return macAddress;
        }
    }
    
}
