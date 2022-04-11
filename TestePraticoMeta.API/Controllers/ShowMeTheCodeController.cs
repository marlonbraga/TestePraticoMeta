using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestePraticoMeta.Domain;

namespace TestePraticoMeta.API.Controllers
{
    [Route("showmethecode")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        // GET showmethecode
        [HttpGet]
        public async Task<IActionResult> GetLatest()
        {
            string githubRepository = Constants.GithubRepository;
            return new OkObjectResult(githubRepository);
        }
    }
}