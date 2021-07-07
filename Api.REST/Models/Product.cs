using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.REST.Models
{
    public class Product
    {
        public virtual int id { get; set; }
        public virtual string product_name { get; set; }
        public virtual string product_type { get; set; }
        public virtual int state_id { get; set; }
    }
}
