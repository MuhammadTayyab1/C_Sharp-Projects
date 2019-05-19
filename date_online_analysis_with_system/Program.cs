using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Specialized;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Globalization;
using System.Net.Sockets;

namespace ConsoleApplication331
{
    class Program
    {
        static void Main(string[] args)
        {
            // initilizing variables
            string online;
            string offline;

            // Request for online date
            var client = new TcpClient("time.nist.gov", 13);
            using (var streamReader = new StreamReader(client.GetStream()))
            {
                var response = streamReader.ReadToEnd();
                var utcDateTimeString = response.Substring(7, 8);

                online = utcDateTimeString;
            }

            // Offline date of computer
            offline = DateTime.Now.ToString("dd/MM/yyyy");

            // Online date
            Console.WriteLine(online);

            // Offline date
            Console.WriteLine(offline);

            // Break string for days
            string setonlineday = online.Substring(0, 2);
            string setofflineday = offline.Substring(0, 2);

            // Break string for Months
            string setonlinemonth = online.Substring(3, 2);
            string setofflinemonth = offline.Substring(2, 2);

            // Break string for Years
            string setonlineyear = online.Substring(6, 2);
            string setofflineyear = offline.Substring(6, 2);

            // Comparing online date with system date 
            if(setonlineday==setofflineday && setonlinemonth==setofflinemonth && setonlineyear==setofflineyear)
            {
                Console.WriteLine("Continue");
            }
            else
            {
                Console.WriteLine("Date is not correct");
            }

        }
       
        
    }
}