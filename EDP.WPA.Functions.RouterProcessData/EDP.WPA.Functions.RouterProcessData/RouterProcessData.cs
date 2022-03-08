using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace EDP.WPA.Functions.RouterProcessData
{
    public class RouterProcessData
    {
        [FunctionName("RouterProcessData")]
        public void Run([QueueTrigger("myqueue-items", Connection = "")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
