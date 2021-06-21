using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ข้อ 1
             * รับพารามิเตอร์เป็น int ชื่อ N
             * หาจำนวนเฉพาะที่มีค่าระหว่าง 1 - N
             * เก็บค่าใส่ตัวแปร primeNumber
             * 
             * https://th.wikipedia.org/wiki/%E0%B8%88%E0%B8%B3%E0%B8%99%E0%B8%A7%E0%B8%99%E0%B9%80%E0%B8%89%E0%B8%9E%E0%B8%B2%E0%B8%B0
             * จำนวนเฉพาะ คือ จำนวนเต็มบวกที่ไม่มีเลขจำนวนเต็มบวกใดๆหารมันลงตัวยกเว้น 1 และ ตัวมันเอง
             * ยกตัวอย่างเช่น 2 3 5 7 11 13 17 19 23 29 ...
             * 
             * vorapol@bangkoklife.com
             * zip ส่้ง mail
             * 
            */
            int N = 1000;
            var primeNumber = GetPrimeNumber(N);
            Console.WriteLine("Prime number between 1-{0} is \n[ {1} ]\n", N, String.Join(" ", primeNumber));

            Console.ReadKey();
        }

        static List<int> GetPrimeNumber(int n)
        {
            List<int> primeNumber = new List<int>();

            //เขียนโค๊ดตรงนี้เลยจร้า

            /*
            for (int i = 0; i < n; i++)
            {

                if((i == 1 || i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                    && (i != 2 && i != 3 && i != 5 && i != 7))
                {
                    continue;
                }
                //Console.WriteLine(i);
                primeNumber.Add(i);
            }
            */
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for(j = 2; j <= i; j++) // เอา 2 ถึง n หาร เพื่อหา Prime
                {
                    if (i % j == 0) //ถ้าหารลงดัวให้เบรคเพื่อไปตรวจสอบเงื่อนไข
                    {
                        break;
                    }
                }
                if (i == j) //ถ้าหารแล้วลงตัวแต่เป็นตัวมันเอง ค่านั้นคือ Prime
                {
                    primeNumber.Add(i);
                }
            }


                return primeNumber;
        }
    }
}
