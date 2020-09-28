using System;
using System.Net.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main2()
        {
            // Making breakfast

            // Make Tea
            // - Turn on burner (2s)
            // - Place kettle on burner (3s)
            // - Pour Water (5s)
            // - Let it boil (5min)
            // - Grind Masalas (1min)
            // - Put Sugar and masalas (10s)
            // - Pour Milk (5s)
            // - Let it boil (3min)

            // Fry egg
            // - Turn on burner (2s)
            // - Put pan and oil it (30s)
            // - Crack eggs and whisk it (3min)
            // - Fry (3min)

            HttpClient client = new HttpClient();
            Stopwatch stopwatch = Stopwatch.StartNew();
            var google = client.GetStringAsync("www.google.com").Result;
            var microsoft = client.GetStringAsync("www.microsoft.com").Result;
            var yahoo = client.GetStringAsync("www.yahoo.com").Result;
            var git = client.GetStringAsync("www.github.com/MBM-SecA/Sushan.ghimire").Result;
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            var g = await client.GetStringAsync("www.google.com");
            var m = await client.GetStringAsync("www.microsoft.com");
            var y = await client.GetStringAsync("www.yahoo.com");
            var gi =await client.GetStringAsync("www.github.com/MBM-SecA/Sushan.ghimire");
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

        }
    }
}