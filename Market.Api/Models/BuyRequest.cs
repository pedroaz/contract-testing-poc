using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Api.Models
{
    public class BuyRequest
    {
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
