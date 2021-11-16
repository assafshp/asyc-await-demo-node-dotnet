using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace dotnet
{
    class Program
    {
        static async Task Demo() {
            Console.WriteLine("Demo started");
            Task.Delay(3000);
            Console.WriteLine("Demo ended");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main started!");
            Demo().Wait();
            Console.WriteLine("Main ended!");
        }
    }
}
