using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace My.Functions
{
    public static class PowFunction
    {
        [FunctionName("PowFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            Pow pow = new Pow();
            int a = Convert.ToInt32(req.Query["a"]);
            int b = Convert.ToInt32(req.Query["b"]);

            try{
                int powResult = pow.Calculate(a, b);
                return (ActionResult) new OkObjectResult($"Pow: {a} i {b} to {powResult}");
            } catch (Exception) {
                return new BadRequestObjectResult($"Bad parametr");
            }
        }
    }
}
