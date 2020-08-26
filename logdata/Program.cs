using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logdata
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello");
            NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

             _logger.Fatal("FatalMessage");
        }
    }
}
