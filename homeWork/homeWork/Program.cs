using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Console.Write("Eded Daxil Edin:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //getNumberCount(number);
            #endregion
            #region 2
            //Console.Write("Eded Daxil Edin : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //getComplexSimple(number);
            #endregion
            #region 3
            //Console.Write("Eded Daxil Edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //getsSeason(num);
            #endregion 


            Console.ReadKey();
       
        }

        #region 1.Istifadeci eded daxil edir. Daxil olunan ededin nece reqemnen ibaret olmasini tapmaq.
        static void getNumberCount(int num)
        {
            int count = 0;

            while (true)
            {

                int qaliq = num % 10;
                num = (num - qaliq) / 10;
                count++;
                if (num == 0)
                    break;
            }
            Console.Write(count);
        }
        #endregion
        #region 2.Istifadeci eded daxil edir. Ededin sade ve ya murekkeb oldugunu tapmaq

        static void getComplexSimple(int num)
        {
            int count = 0;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    count++;
            }

            if (count != 0)
                Console.WriteLine("Complex");
            else
                Console.WriteLine("Simple");

        }
        #endregion
        #region 3.Men ayin nomresini daxil edecem hansi fesilde oldugumuzu tapin. Nezere alin bir ilde 12 ay var.
        static void getsSeason(int num)
        {

            switch (num)
            {
                case 1:
                    Console.WriteLine("Qış");
                    break;
                case 2:
                    Console.WriteLine("Qış");
                    break;
                case 3:
                    Console.WriteLine("Yaz");
                    break;
                case 4:
                    Console.WriteLine("Yaz");
                    break;
                case 5:
                    Console.WriteLine("Yaz");
                    break;
                case 6:
                    Console.WriteLine("Yay");
                    break;
                case 7:
                    Console.WriteLine("Yay");
                    break;
                case 8:
                    Console.WriteLine("Yay");
                    break;
                case 9:
                    Console.WriteLine("Payız");
                    break;
                case 10:
                    Console.WriteLine("Payız");
                    break;
                case 11:
                    Console.WriteLine("Payız");
                    break;
                case 12:
                    Console.WriteLine("Qış");
                    break;
                default:
                
                    throw new ArgumentException("Yanlis Eded Daxil Etmisiz");
                  
            }

        }
        #endregion




    }
}
