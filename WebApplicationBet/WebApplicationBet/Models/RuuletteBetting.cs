using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBet.Models
{
    public class RuuletteBetting
    {
        public int id { get; set; }
        public string name { get; set; }
        public double money { get; set; }
        public int namber { get; set; }
        public List<PlayBet> Play{ get; set; }
    }
}
