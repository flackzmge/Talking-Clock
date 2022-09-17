using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Talking_Clock;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace My_Talking_ClockAPI.Controllers
{
    [Route("api/[controller]")]
    public class Talking_ClockController : Controller
    {
        //No parameter call. Use current time
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult (Talking_Clock.Program.GetTalkingTimeNow());
        }

        //Single parameter call
        [HttpGet("{timeString}")]
        public IActionResult Get(string timeString)
        {
            return new JsonResult(Talking_Clock.Program.GetTalkingTime(timeString));
        }

        
    }
}

