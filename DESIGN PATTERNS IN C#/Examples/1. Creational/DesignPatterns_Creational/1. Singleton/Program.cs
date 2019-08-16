using _1.Singleton.clases.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Singleton
{
    class Program
    {
        private static bool stopping = false;

        static void Main()
        {
            IPrinter _print = PrintDocuments.PrinterLaserInstance;
            IPrinter _print2 = PrintDocuments.PrinterplotterInstance;

            string _res = _print.Print("Carlos Mario Moreno");
            Console.WriteLine(_res);
            
            string _res2 = _print2.Print("Carlos Mario Moreno");
            Console.WriteLine(_res2);

            Console.WriteLine($"{_print.GetHashCode()}");
            Console.WriteLine($"{_print2.GetHashCode()}");
            Console.ReadKey();
        }        
    }
}
