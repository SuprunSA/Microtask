using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microtask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateTimeController : ControllerBase
    {
        public DateTime Date = DateTime.Now;

        [HttpGet("/date")]
        public string GetDate(string formatDate = "dd.MM.yy")
        {
            return Date.ToString(formatDate);
        }

        [HttpGet("/time")]
        public string GetTime(string formatTime = "dd:MM:ss")
        {
            return Date.ToString(formatTime);
        }
    }
}
