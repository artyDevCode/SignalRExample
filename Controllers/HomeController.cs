using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRExample.Hubs;
using SignalRExample.Data;
using Newtonsoft.Json;

namespace SignalRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IHubContext<ChatHub> _hub;
        public HomeController(IHubContext<ChatHub> hub)
        {
            _hub = hub;
        }

        public IActionResult Get()
        {
            var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("transferchartdata", JsonConvert.SerializeObject(DataManager.GetData())));
            return Ok(new { Message = "Request Completed" });
        }
    }
}