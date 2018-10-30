using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTestUpperVsLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = File.ReadAllText(@"C:\Users\bridget.u\Desktop\test.txt");
            string contents2 = File.ReadAllText(@"C:\Users\bridget.u\Desktop\test.txt");
            int i = 0;

            while (i < 6)
            {
                contents = contents + contents;
                contents2 = contents;
                i++;
            }

            DateTime lStart, lEnd, uStart, uEnd;
            lStart = DateTime.Now;
            Console.WriteLine(lStart.ToLongTimeString());
            contents.ToLower();
            lEnd = DateTime.Now;
            Console.WriteLine(lEnd.ToLongTimeString());

            uStart = DateTime.Now;
            Console.WriteLine(uStart.ToLongTimeString());
            contents2.ToUpper();
            uEnd = DateTime.Now;
            Console.WriteLine(uEnd.ToLongTimeString());

            Console.WriteLine("Time taken for ToLower(): "+ (lEnd-lStart).TotalMilliseconds );
            Console.WriteLine("Time taken for ToUpper(): " + (uEnd - uStart).TotalMilliseconds);
            Console.ReadLine();
        }
    }
}
