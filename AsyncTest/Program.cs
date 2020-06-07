using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AGetGWB();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public static async Task AGetGWB()
        {
            HttpClient hc = new HttpClient();
            await hc.GetAsync("http://geekswithblogs.net/Default.aspx");
            Console.WriteLine("Pobralem  zawartosc asynchronicznie");
        }

        public static void SGetGWB()
        {
            HttpClient hc = new HttpClient();
            hc.GetAsync("http://geekswithblogs.net/Default.aspx");
            Console.WriteLine("Pobralem zawartosc synchronicznie");
        }
    }
}
