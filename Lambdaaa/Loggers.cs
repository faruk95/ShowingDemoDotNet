using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdaaa
{
    public static class Loggers
    {
       const string sy = "information";
       static public void log(string name,  string ssy=sy, int id = 2) 
        {
            Console.WriteLine("INFO  name : {0} ID :{1} System :\t {2}\n",name,id,ssy);
        }
    }
}
