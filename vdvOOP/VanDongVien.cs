using System;
using System.Collections.Generic;
using System.Text;

namespace vdvOOP
{
    class VanDongVien
    {
        private string v1;
        private int v2;

        public VanDongVien(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        ~VanDongVien() { }
        public string hoten { get; set; }
        public int tuoi { get; set; }
        public string monthidau { get; set; }
        public double cannang { get; set; }
        public double chieucao { get; set; }
        public VanDongVien()
        {
            hoten = "thanhnguyen";
            tuoi = 21;
            monthidau = "lol";
            cannang = 69;
            chieucao = 165;
        }
        public VanDongVien(string ht , int t , string mtd , double cn , double cc)
        {
            hoten = ht;
            tuoi = t;
            monthidau = mtd;
            cannang = cn;
            chieucao = cc;
        }
        public void Xuat()
        {
            Console.WriteLine("Van dong vien co: ");
            Console.WriteLine("Ten la {0}",hoten);
            Console.WriteLine("Tuoi la {0}",tuoi);
            Console.WriteLine("Thi dau bo mon {0}",monthidau);
            Console.WriteLine("Can nang : {0}",cannang);
            Console.WriteLine("Chieu cao : {0}",chieucao);
            Console.WriteLine("");
        }
        public int Sosanh2(VanDongVien vdv1) {
            VanDongVien temp;
            if (chieucao > vdv1.chieucao)
                return 1;
            else if (chieucao < vdv1.chieucao)
                return 0;
            else if (cannang > vdv1.cannang)
                return 1;
            else
                return 0;
        }
        public void swap(int n)
        {
            for(int i =0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    VanDongVien i;
                    if()
                }
            }
        }
        



    }
}
