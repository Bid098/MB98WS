using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TClientRequest
{
    class TClientRequest
    {
        public string GetHour()
        {
            string Now=null;
            if (DateTime.Now.Hour.ToString().Length == 1)
            {
                Now += "0" + DateTime.Now.Hour.ToString() + ":";
            }
            else
            {
                Now += DateTime.Now.Hour.ToString() + ":";
            }

            if (DateTime.Now.Minute.ToString().Length == 1)
            {
                Now += "0" + DateTime.Now.Minute.ToString() + ":";
            }
            else
            {
                Now += DateTime.Now.Minute.ToString() + ":";
            }

            if (DateTime.Now.Second.ToString().Length == 1)
            {
                Now += "0" + DateTime.Now.Second.ToString();
            }
            else
            {
                Now += DateTime.Now.Second.ToString();
            }

            return Now;
        }

        
    }
}
