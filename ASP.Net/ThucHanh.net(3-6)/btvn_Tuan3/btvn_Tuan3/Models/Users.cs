using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace btvn_Tuan3.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public enum EAddress { HàNội, NamĐịnh, HảiDương, HàGiang }
}