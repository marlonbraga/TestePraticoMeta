using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestePraticoMeta.Domain;

namespace TestePraticoMeta.Controllers
{
    [Route("calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        // GET calculajuros/5/4
        [HttpGet("{value}/{time}")]
        public async Task<IActionResult> GetByPathParameters(double value, int time)
        {
            Interest interest = new Interest();
            string result = interest.CalcInterest(value, time).ToString("0.00");
            return new OkObjectResult(result);
            //return new OkObjectResult("calculajuros/" + id);
        }

        // GET calculajuros?valorinicial=100&meses=5
        [HttpGet()]
        public async Task<IActionResult> GetByQueryParameters(double valorinicial, int meses)
        {
            double value = valorinicial;
            int time = meses;
            Interest interest = new Interest();
            string result = interest.CalcInterest(value, time).ToString("0.00");
            return new OkObjectResult(result);
            //return new OkObjectResult("calculajuros/" + id);
        }
    }
}
