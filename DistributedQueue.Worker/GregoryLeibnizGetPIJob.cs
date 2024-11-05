using System;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedQueue.Common
{
    internal class GregoryLeibnizGetPIJob : IComputePiJob
    {
        public Task ComputePyAsync(string name, int iterrations, CancellationToken token)
        {

            var startTime = DateTime.Now;

            var iterrationsToCheck = 1000000;
            var iterrationCurrent = 0;
            string[] strings = {
                    "жим штанги лежа",
                    "жим ногами",
                    "приседания со штангой",
                    "сгибания на бицепс",
                    "разведения в кроссовере",
                    "отжимания",
                    "подтягивания"
                };
            for (int i = 0; i < iterrations; i++)
            {
                Console.WriteLine($"{DateTime.Now}: Compute task: {name} делает {strings[i%10]}");
                Thread.Sleep(1000);
            }


            Console.WriteLine($"Nane potoka: {name}, Iterrations: {iterrations}");

            return Task.CompletedTask;
        }
    }
}
