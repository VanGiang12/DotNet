using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruyCapDL_CodeFirst.Models
{
    public class Oders
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        // thuộc tính khóa ngoại
        public int CustomerId { get; set; }

        // thuộc tính điều hướng
        public virtual Customer customer { get; set; }
    }
}