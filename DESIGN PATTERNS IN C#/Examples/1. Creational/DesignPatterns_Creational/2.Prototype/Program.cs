using _2.Prototype.Example1;
using _2.Prototype.Example2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            int program = 2;

            switch (program)
            {
                case 1:
                    ProgramCarros.Execute();
                    break;
                case 2:
                    ProgramPersona.Execute();
                    break;
            }
            

            Console.ReadKey();
        }
    }
}
