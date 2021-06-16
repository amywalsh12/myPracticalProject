using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Letters.Controllers
{
  
        [ApiController]
        [Route("[controller]")]
        public class LettersController : ControllerBase
        {
            private static readonly char[] IDLetters = new[]
            {
            'A','B', 'C','D','E','F','G','H','I','J'
        };

            [HttpGet]
            public ActionResult<string> Get()
            {
                var random = new Random();
                var returnIndex = random.Next(0, 10);
                return IDLetters[returnIndex].ToString();
            }

        }
}
