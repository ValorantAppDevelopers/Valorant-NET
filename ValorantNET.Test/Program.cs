using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ValorantNET.Test
{
    class Program
    {
        private static ValorantClient ValorantClient = new ValorantClient();

        static void Main(string[] args)
        {
            //GetStats();
            GetMatches();
            Console.ReadKey();
        }

        private static void GetStats()
        {
            var task = new Task(async () =>
            {
                var result = await ValorantClient.GetStatsAsync("Teo230", "EUW");
                if (result != null)
                    ShowProp(result);
            });
            task.Start();
        }

        private static void GetMatches()
        {
            var task = new Task(async () =>
            {
                var result = await ValorantClient.GetMatchesAsync("Teo230", "EUW");
                if(result != null)
                    ShowProp(result);
            });
            task.Start();
        }

        private static void ShowProp(object obj)
        {
            foreach (var p in obj.GetType().GetProperties().Where(p => !p.GetGetMethod().GetParameters().Any()))
            {
                Console.WriteLine(p.GetValue(obj, null));
            }
        }
    }
}
