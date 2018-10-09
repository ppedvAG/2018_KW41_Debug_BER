using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HalloDebugger
{
    class Program
    {
        static string text = "Start";
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Debugger");
            Trace.AutoFlush = true;
            ///    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
            ///    Trace.Listeners.Add(new EventLogTraceListener("Application"));

            Trace.WriteLine("Trace #1 PRG gestartet!!!");

#if DEBUG
            Console.WriteLine("DEBUG Version");
#endif

#if WURST
            Console.WriteLine("WURST Version");
#endif
#if KÄSE
            Console.WriteLine("KÄSE Version");
#endif



            text = "Main";
            HalloWelt();



            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        private static void HalloWelt()
        {
        
            for (int i = 0; i < 1000; i++)
            {
                text = $"HalloWelt {i}";

                Trace.WriteLine(text);

          //      if (i == 55)
          //          MachFehler();



                Console.WriteLine(text);
                Thread.Sleep(600);
            }
        }

        private static void MachFehler()
        {
            throw new NotImplementedException();
        }
    }
}
