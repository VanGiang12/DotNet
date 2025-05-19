using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tet.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}