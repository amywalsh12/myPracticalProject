using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Numbers.Controllers
{
   
        [ApiController]
        [Route("[controller]")]
        public class NumbersController : ControllerBase
        {
            private static readonly int[] Numbers = new[]
            {
            1,2,3,4,5,6,7,8,9,0
        };

            [HttpGet]
            public ActionResult<string> Get()
            {

            /* var rnd = new Random();
             var returnIndex = rnd.Next(0, 9);
             return Numbers[returnIndex].ToString(); */

            Random rnd = new Random();
            int myRandomNo = rnd.Next(10000000, 99999999); // creates a 8 digit random no.
            return myRandomNo.ToString();




        }

        }
   
    }

