
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBet.Models
{
    public class AplicationsDBContext:DbContext
    {
        public AplicationsDBContext(DbContextOptions<AplicationsDBContext> options)
            :base(options)
            {
             
            }

        public DbSet<RuuletteBetting> Rulette { get; set; }
    }
}
