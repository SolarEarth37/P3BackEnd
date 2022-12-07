using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace loanSystem
{
    [Route("api")]
    [ApiController]
   public class CommunicationController : ControllerBase {

        [HttpPost("add/{user}")]
        public async Task<IActionResult> AddDevice(string user) {
            return await new Loan(DateTime.Today, DateTime.Today, ));

        }
    }
    
}


