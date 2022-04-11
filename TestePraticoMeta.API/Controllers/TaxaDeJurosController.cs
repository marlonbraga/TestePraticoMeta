using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestePraticoMeta.Domain;

namespace TestePraticoMeta.API.Controllers
{
    [Route("taxadejuros")]
    [ApiController]
    public class TaxaDeJurosController : ControllerBase
    {
        // GET taxadejuros
        [HttpGet]
        public async Task<IActionResult> GetLatest()
        {
            Interest interest = new Interest();
            string result = interest.GetInterestRate().ToString();
            return new OkObjectResult(result);
        }
    }
}
