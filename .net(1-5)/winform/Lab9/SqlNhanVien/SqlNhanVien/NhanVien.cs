using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlNhanVien
{
    internal class NhanVien
    {
        private string _ma;
        private string _name;
        private string _sex;
        private DateTime _date;
        private string _address;
        private string _phonenumber;


        public NhanVien() { }

        public NhanVien(string ma, string name, string sex, DateTime date, string address, string phonenumber)
        {
            Ma = ma;
            Name = name;
            Sex = sex;
            Date = date;
            Address = address;
            Phonenumber = phonenumber;
        }

        public string Ma { get => _ma; set => _ma = value; }
        public string Name { get => _name; set => _name = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phonenumber { get => _phonenumber; set => _phonenumber = value; }
    }
}
