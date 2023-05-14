using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong
{
   public class Xe
    {
        private string bienSo;
        private string tenXe;
        private int trongTai;
        private DateTime ngayDangKiem;
        private int tieuChuan;

        public Xe(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuan)
        {
            this.bienSo = bienSo;
            this.tenXe = tenXe;
            this.trongTai = trongTai;
            this.ngayDangKiem = ngayDangKiem;
            this.tieuChuan = tieuChuan;
        }
        public Xe ()
        {

        }
         public string BienSo { get => bienSo; set => bienSo = value; }
        public string TenXe { get => tenXe; set => tenXe = value; }
        public int TrongTai { get => trongTai; set => trongTai = value; }
        public DateTime NgayDangKiem { get => ngayDangKiem; set => ngayDangKiem = value; }
        public int TieuChuan { get => tieuChuan; set => tieuChuan = value; }
        public void Nhap()
        {
            Console.Write("Nhap Bien So:");
            BienSo = Console.ReadLine();
            Console.Write("Ten xe:");
            TenXe = Console.ReadLine();
            Console.Write("Trong tai:");
            TrongTai = int.Parse(Console.ReadLine());
            Console.Write("Ngay Dang Kiem:");
            NgayDangKiem = DateTime.Parse(Console.ReadLine());
            Console.Write("Tieu Chuan:");
            TieuChuan = int.Parse(Console.ReadLine());
        }
         public void Xuat()
        {
            Console.WriteLine("Bien So Xe la:{0}", BienSo);
            Console.WriteLine("Ten xe:{0}", TenXe);
            Console.WriteLine("Trong tai:{0}", TrongTai);
            Console.WriteLine("Ngay Dang Kiem:{0}", NgayDangKiem);
            Console.WriteLine("Tieu Chuan:{0}", TieuChuan);
        }
    }
}
