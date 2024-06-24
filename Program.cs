using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2ThucTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choie;
            do
            {
                Console.WriteLine("=========menu==========");
                Console.WriteLine("1. chuc nang mot");
                Console.WriteLine("2. chuc nang hai");
                Console.WriteLine("3. chuc nang ba");
                Console.WriteLine("4. chuc nang bon");
                Console.WriteLine("5. chuc nang nam");
                Console.WriteLine("6. chuc nang sau");
                Console.Write("Moi ban chon chuc nang: ");
                choie = int.Parse(Console.ReadLine());
                switch (choie)
                {
                    case 1:
                        Bai1();
                        break;
                    case 2:
                        Bai2();
                        break;
                    case 3:
                        Bai3();
                        break;
                    case 4:
                        Bai4();
                        break;
                    case 5:
                        Bai5();
                        break;
                    case 6:
                        Bai6();
                        break;
                    case 0:
                        Console.WriteLine("Ket thuc truong trinh");
                        break;
                    default:
                        Console.WriteLine("chuc nang khong hop le");
                        break;
                }
            }while (choie != 0);
        }
        static void Bai1()
        {
            QLMN qLMN = new QLMN();
            int number;
            do
            {
                Console.Write("Moi Ban nhap vao chu so ");
                number = int.Parse(Console.ReadLine());
                if(number < 100 || number > 999) 
                {
                    Console.WriteLine("Ban chi duoc nhap so co 3 chu so");
                }
            }while(number < 100 || number>999);
            qLMN.Bai1(number);
            
        }
        static void Bai2()
        {
            QLMN qLMN = new QLMN();
            int number;
            do
            {
                Console.Write("Moi Ban nhap vao chu so ");
                number = int.Parse(Console.ReadLine());
                if (number < 100 || number > 999)
                {
                    Console.WriteLine("Ban chi duoc nhap so co 3 chu so");
                }
            } while (number < 100 || number > 999);
            qLMN.Bai2(number);

        }
        static void Bai3()
        {
            QLMN qLMN = new QLMN();
            int number;
            int number2;
            do
            {
                Console.Write("Moi ban nhap vao thang: ");
                number = int.Parse(Console.ReadLine());
                Console.Write("Moi ban nhap vao nam: ");
                number2 = int.Parse(Console.ReadLine());
                if (number < 1 || number > 12)
                {
                    Console.WriteLine("Ban chi duoc nhap thang hop le");
                }
            } while (number < 1 || number > 12);
            qLMN.Bai3(number,number2);

        }
        static void Bai4()
        {
            QLMN qLMN = new QLMN();
            int number;
            do
            {
                Console.Write("Moi ban nhap vao so nguyen duong: ");
                number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Ban chi duoc nhap so nguyen duong");
                }
            } while (number < 0);
            string result = qLMN.Bai4(number);
            Console.WriteLine($"So nguyen {number} sau khi chuyen doi thanh so nhi phan la: {result}");

        }
        static void Bai5()
        {
            QLMN qLMN = new QLMN();
            int number;
            do
            {
                Console.Write("Moi ban nhap vao so thu hang trong day fibonacci: ");
                number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Ban chi duoc nhap so nguyen duong");
                }
            } while (number < 0);
            int result = qLMN.Bai5(number);
            Console.WriteLine($"gia tri tai so hang {number} la: {result}");

        }
        static void Bai6()
        {
            QLMN qLMN = new QLMN();
                Console.Write("Nhap bac cua da thuc: ");
                int bac = int.Parse(Console.ReadLine());

                double[] heSo = new double[bac + 1];
                for (int i = 0; i <= bac; i++)
                {
                    Console.Write($"Nhap he so a{i}: ");
                    heSo[i] = double.Parse(Console.ReadLine());
                }

                Console.Write("Nhap gia tri x: ");
                double x = double.Parse(Console.ReadLine());

                double giaTri = qLMN.Bai6(x, bac, heSo);
                Console.WriteLine($"Gia tri cua da thuc P(x) tai x = {x} la: {giaTri}");
        }
    }
}
