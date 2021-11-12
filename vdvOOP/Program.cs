using System;
using System.Collections;
using System.Collections.Generic;
namespace vdvOOP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            VanDongVien vdv1 = new VanDongVien("thanhnguyen",18,"lol",69,165);
            vdv1.Xuat();
            int n;
            Console.WriteLine("Nhap vao so van dong vien: ");
            n = Int32.Parse(Console.ReadLine());

            ArrayList danhsach = new ArrayList(n);
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap ten van dong vien: ");
                string hoten = Convert.ToString(Console.ReadLine());

                Console.Write("Nhap tuoi van dong vien: ");
                int tuoi = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhap mon thi dau cua van dong vien: ");
                string monthidau = Convert.ToString(Console.ReadLine());

                Console.Write("Nhap can nang: ");
                double cannang = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhap chieu cao: ");
                double  chieucao = Convert.ToDouble(Console.ReadLine());
                danhsach.Add(new VanDongVien(hoten, tuoi,monthidau,cannang, chieucao));
                Console.WriteLine("");

            }
            foreach (var item in danhsach)
            {
                Console.WriteLine(item);
                if()
            }
            danhsach.Sort();
            Console.WriteLine("\n\ndanh sach in ra la: \n\n");
            foreach (VanDongVien item in danhsach)
            {
                item.Xuat();
            }
            /*ArrayList arlist = new ArrayList();
            arlist.Add(300);
            arlist.Add(200);
            arlist.Add(100);
            arlist.Add(400);
            foreach (var item in arlist)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("");
            arlist.Sort();
            foreach (var item in arlist)
            {
                Console.WriteLine(item);
            }*/


        }
    }
}
