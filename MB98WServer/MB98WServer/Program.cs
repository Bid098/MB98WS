using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MB98WServer
{
    using TStartWebServer;
    using TWebServer;
    class Program
    {
        
        static void Main(string[] args)
        {
            TStartWebServer WebServer = new TStartWebServer();            
            

            string Command = null;
            while (Command != "quit")
            {
                Command = Console.ReadLine().ToLower().Replace(" ","");
                switch (Command)
                {
                    case ("start"): { WebServer.StartServer(); break; }
                    //case ("load"):
                    case ("changepath"): { break; }
                }
            }
            WebServer.StopServer();
        }
    }
}
