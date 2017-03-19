using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // show yesterday,today, tomorrow days
            DateTime yesterday = DateTime.Now.AddDays(-1);
            DateTime today = DateTime.Today;
            DateTime tomorrow = DateTime.Now.AddDays(1);


            string today1 = today.ToString("dddd");
            string dtomorrow1 = tomorrow.ToString("dddd");
            string yesterday1 = yesterday.ToString("dddd");

            
            Console.WriteLine("*********************");
            Console.WriteLine(yesterday1 + "\n");
            Console.WriteLine(today1 + "\n");
            Console.WriteLine(dtomorrow1 + "\n");
            Console.ReadKey();
        }
    }
}
