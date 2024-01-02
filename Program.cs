using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int t = 0, b = 0;

            for (; ; )
            {
                Console.Write("Sayı giriniz:");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 83)
                {
                    Console.WriteLine("toplam:" + t);
                    break;

                }

                b = t + a;
                t = b;



            }

        }
    }
}
