using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationBet.Models;

namespace WebApplicationBet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayController : Controller
    {
    

        private readonly AplicationsDBContext context;

        public PlayController(AplicationsDBContext context)
        {
            this.context = context;
        }
        [HttpGet]
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
