using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace dotnet
{
    class Program
    {
        

        static async Task Demo() {
            Console.WriteLine("started");
            await Task.Delay(1500);
            Console.WriteLine("ended");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main started!");
            Demo().Wait();
            Console.WriteLine("Main ended!");
        }
    }
}
