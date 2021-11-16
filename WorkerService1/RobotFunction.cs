using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService1
{
    public static class RobotFunction
    {
        [FunctionName(name:nameof(RobotFunction))]
        
        public static Task Run([ServiceBusTrigger( "TestQueue")] string input, ILogger log)
        {
            log.LogInformation("ServiceBusTrigger {message}", input);
            return Task.CompletedTask;
        }
    }
}
