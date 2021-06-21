using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ข้อ 2
             * จาก List<int> ที่กำหนดให้
             * จงหาจำนวนที่มีค่าสูงสุด 2 อันดับแรก โดยไม่ใช้คำสั่ง .Min() .Max() .Sort() .OrderBy() .OrderByDescending()
             * ตัวเลขที่ค่าเท่ากัน ให้นับเป็นคนละตัวกัน เช่น Top2Max([ 99 , 98 , 99 ]) ได้ [ 99 , 99 ]
            */
            #region Example data
            List<List<int>> listSampleNumber = new List<List<int>>()
            {
                new List<int>() { 96, 35 ,54, 11, 0, 99, 103, -99, 54, 54, 95},     // expected => [ 103 , 99 ]
                new List<int>() { 96, 108, 52, -0, 58, 103, -99, 52, 54, 54, 95},   // expected => [ 108 , 103 ]
                new List<int>() { 320, 2, 96, 108, 103, 1, -99, 52, 54, 54, 312},   // expected => [ 320 , 312 ]
                new List<int>() { 320, 58, 103 , 1 ,-99 , 500 , 54 , 54 , 51},      // expected => [ 500 , 320 ]
                new List<int>() { -1, 0, 0, 0, -1},    // expected => [ 0 , 0 ]
                new List<int>() { 0, -1, 0, -1, 0},    // expected => [ 0 , 0 ]
                new List<int>() { 0, 0, -1, -1, -1},    // expected => [ 0 , 0 ]
                new List<int>() { -1, 0, -1, -1, -1},   // expected => [ 0 , -1 ]
                new List<int>() { 0, -1, -1},   // expected => [ 0 , -1 ]
                new List<int>() { -1, -1, 0 },  // expected => [ 0 , -1 ]
                new List<int>() { 0 , 2 },      // expected => [ 2 , 0 ]
                new List<int>() { 2 , 0 },      // expected => [ 2 , 0 ]
                new List<int>() { 5 },          // expected => [ 5 ]
                new List<int>() { },            // expected => [  ]
                new List<int>() { int.MinValue , 0 , int.MinValue },                // expected => [  0 , -2147483648 ]
            };
            #endregion

            foreach (var sampleNumbers in listSampleNumber)
            {
                //Console.WriteLine(listSampleNumber);

                Console.Write("######################################\n");
                Console.Write("Top 2 Max of [ {0} ] \nis ", String.Join(" , ", sampleNumbers));
                var top2Max = GetTop2Max(sampleNumbers);
                Console.Write("[ {0} ]\n\n", String.Join(" , ", top2Max));
            }
            ///////////////////
            Console.ReadKey();
        }

        static List<int> GetTop2Max(List<int> number)
        {
            List<int> top2Max = new List<int>();
            //เขียนโค๊ดตรงนี้เลยจร้า
            int[] Num = number.ToArray();
            
            int Temp;
            for (int i = 0; i<Num.Length; i++)
            {
                for (int j = 0; j<Num.Length; j++)  //  Sort number from max to min in Num[]
                {
                    if (Num[i] > Num[j])
                    {
                        Temp = Num[i];
                        Num[i] = Num[j];
                        Num[j] = Temp;
                    }
                }
            }
            if (Num.Length > 1) //if length of Num[] > 1 : fill first value and second in Num[] to list top2Max
            {
                top2Max.Add(Num[0]);
                top2Max.Add(Num[1]);
            }
            else if (Num.Length == 1)
            {
                top2Max.Add(Num[0]);
            }
            else
                return top2Max;
            return top2Max;
        }

    }
}
