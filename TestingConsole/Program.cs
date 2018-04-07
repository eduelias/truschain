using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IdentityService.FileHandler;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FileContract fc = new FileContract();

            fc.AttachToEvent("0xc5a9c78645c73f7370177db6bae9e7abf267ee9d", "OnChange", (s, objects) =>
            {
                foreach (var o in objects)
                {
                    Console.WriteLine(s, o);
                }
            } );

            while (true)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
