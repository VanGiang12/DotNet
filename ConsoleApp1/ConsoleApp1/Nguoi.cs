using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Nguoi
    {
        string name;
        string gender;
        int age;

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }

        public Nguoi(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
        public Nguoi() { }
        ~Nguoi() { }

        public void Nhap()
        {
            Console.Write("Nhập tên: ");
            Name = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            Gender = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            Age = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.Write("{0,-15}{1,-10}{2,-10}", Name, Gender, Age);
        }
    }
}
