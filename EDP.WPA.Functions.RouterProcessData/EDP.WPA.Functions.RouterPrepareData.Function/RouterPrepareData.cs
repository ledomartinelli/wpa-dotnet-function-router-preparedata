using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace EDP.WPA.Functions.RouterPrepareData.Function
{
    public class RouterPrepareData
    {
        [FunctionName("RouterPrepareData")]
        public void Run([QueueTrigger("myqueue-items", Connection = "Connection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
