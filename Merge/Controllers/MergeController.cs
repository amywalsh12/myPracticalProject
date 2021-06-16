using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Merge.Controllers
{



    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        private IConfiguration Configuration;
        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           /* var numbersService = $"{Configuration["numbersServiceURL"]}/numbers";
           // var numbersService = $"https://localhost:44368/numbers";
            var serviceOneResponseCall = await new HttpClient().GetStringAsync(numbersService);
             var lettersService = $"{Configuration["lettersServiceURL"]}/letters";
           // var lettersService = $"https://localhost:44370/letters";
            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(lettersService);
            var mergedResponse = $"{serviceOneResponseCall}{serviceTwoResponseCall}";
            return Ok(mergedResponse);*/

            var numbersService = $"{Configuration["numbersServiceURL"]}/numbers";
            var serviceOneResponseCall = await new HttpClient().GetStringAsync(numbersService);
            var lettersService = $"{Configuration["lettersServiceURL"]}/letters";
            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(lettersService);
            var mergedResponse = $"{serviceOneResponseCall}{serviceTwoResponseCall}";
            return Ok(mergedResponse);
        }
    }
}

   
