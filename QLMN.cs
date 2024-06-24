using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2ThucTap
{
    internal class QLMN
    {
        public void Bai1(int x)
        {
            
            int hangtram = x / 100; // 291/100 = 2 (hang tram)
            int hangchuc = (x / 10) % 10; // 291/10 = 29%10 = 9 (hang chuc)
            int hangdonvi = x % 10; // 291%10 = 1(hang don vi)

            int Solonnhat = hangtram;
            string viTri= "Hang tram";
            if(Solonnhat < hangchuc)
            {
                Solonnhat = hangchuc;
                viTri = "Hang chuc";
            }
            if (Solonnhat < hangdonvi)
            {
                Solonnhat = hangdonvi;
                viTri = "Hang don vi";
            }
            Console.WriteLine($"So lon nhat co gia tri {Solonnhat} nam ow vi tri {viTri}");
        }
        public void Bai2(int x)
        {
            int hangtram = x / 100;
            int hangchuc = (x/10) % 10;
            int hangdonvi = x%10;

            int[] mangso = { hangtram, hangchuc, hangdonvi };
            for (int i = 0; i < mangso.Length - 1; i++)
            {
                for(int j = i+1; j < mangso.Length; j++)
                {
                    if (mangso[i]> mangso[j])
                    {
                        int temp = mangso[i];
                        mangso[i] = mangso[j];
                        mangso[j] = temp;
                    }
                }
            }
            Console.WriteLine($" Chu so sau khi da sap xep: {mangso[0]}{mangso[1]}{mangso[2]}");
        }
        public bool NamNhuan(int x)
        {
            return((x % 4 == 0 && x % 100 != 0) || (x % 400 == 0));
        }
        public void Bai3(int thang,int nam) 
        {
            int soNgay = 0;
            switch(thang)
            {
                case 1: 
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10:
                case 12: 
                    soNgay = 31;
                    break;
                case 4: 
                case 6: 
                case 9: 
                case 11:
                    soNgay = 30;
                    break;
                case 2: 
                    if (NamNhuan(nam))
                    {
                        soNgay = 29;
                    }
                    else
                    {
                        soNgay = 28;
                    }
                    break;
            }
            Console.WriteLine($"So ngay co trong thang {thang} cua nam {nam} la {soNgay} ngay");
        }
        public string Bai4(int x)
        {
            string ketqua = "";

            while(x>0)
            {
                int phandu = x % 2;
                ketqua = phandu.ToString() + ketqua;
                x = x / 2;
            }
            return ketqua;
        }
        public int Bai5(int x)
        {
            if(x == 1 || x == 2)
            {
                return 1;
            }
            int f1 = 1;
            int f2 = 1;
            int fk = 0;
            for (int i = 2; i < x; i++)
            {
                fk = f2 + f1;
                f1 = f2;
                f2 = fk;
            }
            return fk;
        }
        public double Bai6(double x,int bac, double[] heso)
        {
            double giatri = 0;
            for(int i = 0; i <= bac; i++)
            {
                giatri += (heso[i] * Math.Pow(x, bac - i));
            }
            return giatri;
        }
    }
}
