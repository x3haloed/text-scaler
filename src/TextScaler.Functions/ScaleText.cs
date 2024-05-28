using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace TextScaler.Functions
{
    public class ScaleText
    {
        private readonly ILogger<ScaleText> _logger;

        public ScaleText(ILogger<ScaleText> logger)
        {
            _logger = logger;
        }

        [Function("ScaleText")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
