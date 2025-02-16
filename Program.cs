using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Viết CT nhập vào 1 list
//1. in ra có bao nhiêu số nhỏ hơn 5
//2. in ra vị trí index của số đó

namespace Csharp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào số phần tử của danh sách: ");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Mời nhập vào phần tử thứ {0} của danh sách", i+1);
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Danh sách bạn vừa nhập là: ");
            foreach (double d in list)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();
            foreach (double d in list)
            {
                if (d < 5)
                    dem++; 
            }
            Console.WriteLine("Trong danh sách bạn nhập có {0} số nhỏ hơn 5", dem);
            Console.Write("Vị trí index các phần tử đó là: ");
            for (int i = 0; i <list.Count; i++)
            {
                if (list[i] < 5)
                    Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
