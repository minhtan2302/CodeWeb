﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class HCNwithStatic
    {
        private int ChieuDai { get; set; }
        private int ChieuRong { get; set; }
        public HCN()
        {

        }
        public HCN(int ChieuDai, int ChieuRong)
        {
            this.ChieuDai = ChieuDai;
            this.ChieuRong = ChieuRong;
        }
        public static void CongThuc() // dùng với static nên không cần tạo new, nhưng ảnh hướng tới bộ nhớ "hạn chế dùng"
        {
            Console.WriteLine("Nhap du lieu cua HCN ");
            Console.Write("-Nhap Chieu Dai: ");
            ChieuDai = Convert.ToInt32(Console.ReadLine());
            Console.Write("-Nhap Chieu Rong: ");
            ChieuRong = Convert.ToInt32(Console.ReadLine());

        }
        public int ChuViHCN()
        {
            return (this.ChieuDai + this.ChieuRong) * 2;
        }
        public int DienTichHCN()
        {
            return (this.ChieuDai * this.ChieuRong);
        }
    }
}
