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
    public class BetController : Controller
    {
        private readonly AplicationsDBContext context;

        public BetController(AplicationsDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<RuuletteBetting> Get()
        {
            return context.Rulette.ToList();
        }
        [HttpGet("{id}", Name ="Bet")]
        public IActionResult GetById(int id)
        {
            var rul = context.Rulette.FirstOrDefault(x => x.id == id);
            if (rul == null)
            {
                return NotFound();
            }
            return Ok(rul);
        }
        [HttpPost]
        public IActionResult Post([FromBody] RuuletteBetting Rul)
        {
            if (ModelState.IsValid)
            {
                context.Rulette.Add(Rul);
                context.SaveChanges();
                return new CreatedAtRouteResult("Bet", new {id  = Rul.id}, Rul);
            }
            return BadRequest(ModelState); 
        }
        [HttpPut("{Id}")]
        public IActionResult Put([FromBody] RuuletteBetting Rul, int id)
        {
            if (Rul.id != id)
            {
              
                return BadRequest();
            }
            context.Entry(Rul).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            var rul = context.Rulette.FirstOrDefault(x => x.id == id);
            if (rul == null)
            {

                return NotFound();
            }
            context.Rulette.Remove(rul);
            context.SaveChanges();
            return Ok(rul);
        }
    }
}
