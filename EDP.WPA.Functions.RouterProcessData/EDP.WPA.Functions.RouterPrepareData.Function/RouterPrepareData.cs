using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace EDP.WPA.Functions.RouterPrepareData.Function
{

    public class RouterPrepareData
    {
        private readonly ILogger _logger;
        
        public RouterPrepareData(ILogger logger)
        {
            _logger = logger;
        }

        [FunctionName("RouterPrepareData")]
        public void Run([QueueTrigger("%QueueName%", Connection = "Connection")]string myQueueItem, ILogger log)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
