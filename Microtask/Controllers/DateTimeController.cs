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
        public string GetDate(string formatDay = "dd", string formatMonth = "MM", string formatYear = "yy")
        {
            return Date.ToString(string.Format("{0}.{1}.{2}", formatDay, formatMonth, formatYear));
        }

        [HttpGet("/time")]
        public string GetTime(string formatHour = "hh", string formatMinute = "mm", string formatSecond = "ss")
        {
            return Date.ToString(string.Format("{0}:{1}:{2}", formatHour, formatMinute, formatSecond));
        }
    }
}
