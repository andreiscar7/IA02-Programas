using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBet.Models
{
    public class PlayBet
    {
        public int id { get; set; }
        public string namber { get; set; }
        public double money { get; set; }
        public RuuletteBetting Rullete { get; set; }
       
        
        
    }
}
