using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestePraticoMeta.Domain;

namespace TestePraticoMeta.API.Controllers
{
    [Route("calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        /// <summary>
        /// GetByQueryParameters
        /// </summary>
        /// <returns> Calc of Interest</returns>
        /// <remarks>
        ///
        /// Sample request
        /// GET calculajuros?valorinicial=100&meses=5
        ///
        /// </remarks>
        // GET calculajuros?valorinicial=100&meses=5
        [HttpGet()]
        public async Task<IActionResult> GetByQueryParameters(double valorinicial, int meses)
        {
            double value = valorinicial;
            int time = meses;
            Interest interest = new Interest();
            string result = interest.CalcInterest(value, time).ToString("0.00");
            return new OkObjectResult(result);
        }
    }
}
