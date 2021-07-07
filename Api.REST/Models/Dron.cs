using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.REST.Models
{
    public class Dron
    {
        public virtual int id { get; set; }
        public virtual decimal latitud { get; set; }
        public virtual decimal longitud { get; set; }
        public virtual int state_id { get; set; }
    }
}
