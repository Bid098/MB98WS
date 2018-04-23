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
        TWebServer ws = new TWebServer(SendResponse, "http://" + "172.16.100.52" + ":8080/");

        public void StartServer()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("WebServer host in: " + "172.16.100.52" + " port 8080");
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
                case ("GetConfiguration"): { return ""; }
                default:
                    {
                        string lines = System.IO.File.ReadAllText(@"C:\Users\Marco Bidogia\Documents\C#\Corso C#\OBJ JS\OBJ.html");
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
