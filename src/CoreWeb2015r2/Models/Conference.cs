using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb2015r2.Models
{
    public class Conference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal TicketPrice { get; set; }
        public List<Session> Sessions { get; set; }

    }
}
