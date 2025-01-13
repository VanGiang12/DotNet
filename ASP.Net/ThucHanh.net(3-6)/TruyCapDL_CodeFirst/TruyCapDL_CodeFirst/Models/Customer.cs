using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TruyCapDL_CodeFirst.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [StringLength(30, MinimumLength =2)]
        public string Name { get; set; }
        // thuộc tính điều hướng
        public virtual ICollection<Oders> Oders { get; set; }
    }
}