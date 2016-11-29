using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb2015r2.Models
{
    public class Session
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public virtual Conference Conference { get; set; }

    }
}
