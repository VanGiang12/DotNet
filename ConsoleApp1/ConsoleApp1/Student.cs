using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        string name;
        int age;
        string nativePlace;
        string id;

        public Student()
        {

        }
        public Student(string name, int age, string nativePlace, string id)
        {
            this.name = name;
            this.age = age;
            this.nativePlace = nativePlace;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string NativePlace { get => nativePlace; set => nativePlace = value; }
        public string Id { get => id; set => id = value; }

        public void display()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-30}", id, name, age, nativePlace);
        }

        public void input()
        {
            Console.Write("Nhập id: ");
            id = Console.ReadLine();
            Console.Write("Nhập tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Nhập quê quán: ");
            nativePlace = Console.ReadLine();
        }
    }
}
