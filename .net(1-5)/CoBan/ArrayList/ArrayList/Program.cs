﻿using System;
using System.Collections;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("\nChen mot vai phan tu vao ArrayList: ");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);
            Console.WriteLine("\nDung luong cua ArrayList:{0}", al.Capacity);
            Console.WriteLine("So phan tu trong ArrayList:{0}", al.Count);
            Console.WriteLine("\nHien thi cac phan tu trong ArrayList:");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nSap xep va hien thi ArrayList sau khi da sap xep: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }

}
