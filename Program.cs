using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //תוכנית הקולטת מספר ובודקת אם הוא ראשוני או לא
            Console.WriteLine("ente a number");
           int x = Convert.ToInt32(Console.ReadLine());
            int m = 2;
            while (x%m!=0&&m<x)
            {
                m++;

            }
            if (m<x)
            {
                Console.Write(x);
                Console.WriteLine("lo rishoni");
            }
            else
            { 
                Console.Write(x);
            Console.WriteLine(" rishoni");
            }

        }
    }
}
