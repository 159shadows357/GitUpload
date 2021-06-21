using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ข้อ 3
             * จากข้อมูลที่กำหนดให้ จงหาผู้เล่นที่เงื่อนไขดังนี้ 
             *  IsActive เป็น true 
             *  Club.code เป็น MANU หรือ MANC 
             *  EntryDate เลขเดือน หรือ เลขวันที่ เป็นเลขคี่
             *  FirstName หรือ LastName ประกอบด้วยตัวอักษร y 
             *  แต่ตัวอักษร y ไม่ใช่ตัวอักษรตัวสุดท้ายของ FirstName และ LastName
            */
            #region Mockup data
            List<Player> players = new List<Player>()
            {
                new Player() {
                    PlayerId = "1",
                    FirstName = "Jordan",
                    LastName = "Pickford",
                    IsActive = true,
                    EntryDate = new DateTime(1999,5,23),
                    Club = new Club() { Name = "Everton" , Code = "EFC"}
                },
                new Player() {
                    PlayerId = "2",
                    FirstName = "Phil",
                    LastName = "Jones",
                    IsActive = true,
                    EntryDate = new DateTime(1980,4,12) ,
                    Club = new Club() { Name = "Manchester United" , Code = "MANU"}
                },
                new Player() {
                    PlayerId = "3",
                    FirstName = "Ashley",
                    LastName = "Young",
                    IsActive = true,
                    EntryDate = new DateTime(1983,12,31) ,
                    Club = new Club() { Name = "Manchester United" , Code = "MANU"}
                },
                new Player() {
                    PlayerId = "4",
                    FirstName = "Kevin",
                    LastName = "Tripier",
                    IsActive = false,
                    EntryDate = new DateTime(1956,6,6) ,
                    Club = new Club() { Name = "Leicester City" , Code = "LEI"}
                },
                new Player() {
                    PlayerId = "5",
                    FirstName = "Harry",
                    LastName = "Maguire",
                    IsActive = false,
                    EntryDate = new DateTime(1989,11,22) ,
                    Club = new Club() { Name = "Leicester City" , Code = "LEI"}
                },
                new Player() {
                    PlayerId = "6",
                    FirstName = "Jordan",
                    LastName = "Henderson",
                    IsActive = true,
                    EntryDate = new DateTime(1982,7,15),
                    Club = new Club() { Name = "Liverpool" , Code = "LIV"}
                },
                new Player() {
                    PlayerId = "7",
                    FirstName = "Dele ",
                    LastName = "Alli",
                    IsActive = true,
                    EntryDate = new DateTime(1995,5,14) ,
                    Club = new Club() { Name = "Tottenham Hotspur" , Code="TOT"}
                },
                new Player() {
                    PlayerId = "8",
                    FirstName = "Rahim",
                    LastName = "Sterling",
                    IsActive = false,
                    EntryDate = new DateTime(1992,6,12) ,
                    Club = new Club() { Name = "Manchester City" , Code = "MANC"}
                },
                new Player() {
                    PlayerId = "9",
                    FirstName ="Jese",
                    LastName = "Lingard",
                    IsActive = true,
                    EntryDate = new DateTime(1995,7,23) ,
                    Club = new Club() { Name = "Manchester United" , Code = "MANU"}
                },
                new Player() {
                    PlayerId = "10",
                    FirstName ="Jamie",
                    LastName ="Vardy",
                    IsActive =true,
                    EntryDate =new DateTime(1988,11,25),
                    Club = new Club() { Name = "Leicester City" , Code = "LEI"}
                },
                new Player() {
                    PlayerId = "11",
                    FirstName ="Marcus",
                    LastName ="Rashford",
                    IsActive =false,
                    EntryDate =new DateTime(1986,2,1) ,
                    Club = new Club() { Name = "Manchester United" , Code = "MANU"}
                },
                new Player() {
                    PlayerId = "12",
                    FirstName = "Kyle",
                    LastName = "Walker",
                    IsActive = true,
                    EntryDate = new DateTime(1999,8,5) ,
                    Club = new Club() { Name = "Manchester City" , Code = "MANC"}
                },
                new Player() {
                    PlayerId = "13",
                    FirstName = "Gary",
                    LastName = "Cahill",
                    IsActive = true,
                    EntryDate = new DateTime(1982,8,8) ,
                    Club = new Club() { Name = "Chelsea" , Code = "CHE"}
                },
            };
            #endregion

            var result = players;

            //เขียนโค๊ดตรงนี้เลยจร้า
            Console.WriteLine("Result is ");
            foreach (var i in result)
            {
                bool ChkPrint = false;
                if (i.IsActive == true && (i.Club.Code == "MANC" || i.Club.Code == "MANU") && (i.EntryDate.Value.Day % 2 != 0 || i.EntryDate.Value.Month % 2 != 0))//ใส่วงเล็บให้ชัด***
                {
                    if (i.FirstName[i.FirstName.Length - 1] == 'y' || i.LastName[i.LastName.Length - 1] == 'y') // find last charector 'y' of firstname and lastname
                    {
                        continue;
                    }
                    for (int count = 0; count < i.FirstName.Length - 1; count++) // chack 'y' in firstname
                    {
                        if (i.FirstName[count] == 'y')
                        {
                            ShowResult(i);
                            ChkPrint = true;
                            break;
                        }
                    }
                    if (ChkPrint) continue; // if alreddy 'y' in firstname goto show result
                    for (int count = 0; count < i.LastName.Length - 1; count++) // chack 'y' in lastname
                    {
                        if (i.LastName[count] == 'y')
                        {
                            ShowResult(i);
                            break;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
        static void ShowResult(Player i)
        {
            Console.WriteLine("{0} {1} {2}\n{3} {4} {5}\n{6}\n",
            i.PlayerId, i.FirstName, i.LastName,
            i.IsActive, i.Club.Name, i.Club.Code,
            i.EntryDate.Value.ToShortDateString());
        }
    }
}