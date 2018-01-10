using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TStartWebServer
{
    using System.Net;
    using TWebServer;
    using TClientRequest;
    
    class TStartWebServer
    {
        TWebServer ws = new TWebServer(SendResponse, "http://" + Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString() + ":8080/");

        public void StartServer()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("WebServer host in: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString() + " port 8080");
            Console.ResetColor();
            ws.Run();
        }

        public static string SendResponse(HttpListenerRequest request)
        {
            TClientRequest ClientRequest = new TClientRequest();
            if (request.RawUrl.Replace("/", "")!="")
                Console.WriteLine(request.RawUrl.Replace("/",""));
            switch (request.RawUrl.Replace("/", ""))
            {
                case ("GetHour"): { return ClientRequest.GetHour(); }
                
                default:
                    {
                        string lines = System.IO.File.ReadAllText(@"C:\ProgramData\test\Site.html");
                        return lines;
                    }
                    
            }
               
            //return "<HTML><body><span>Server Not Found</span></body></HTML>";
        }

        public void StopServer()
        {
            ws.Stop();
        }
    }
}
