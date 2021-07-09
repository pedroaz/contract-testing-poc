using Market.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarketController : ControllerBase
    {

        /// <summary>
        /// Get all the available products
        /// </summary>
        /// <param name="marketId">The market id which the query should look at</param>
        /// <returns></returns>
        [HttpGet("Products")]
        public ActionResult Products([FromHeader] string marketId)
        {
            return Ok("List of all the products");
        }

        [HttpPost("Buy")]
        public ActionResult Buy([FromHeader] string marketId, [FromBody] BuyRequest buyRequest)
        {
            return Ok("Transaction was successfull");
        }
    }
}
