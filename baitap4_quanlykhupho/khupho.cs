using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai4_QLHD
{
    internal class KhuPho
    {
        public List<HoDan> HoDans { get; set; }

        public KhuPho()
        {
            HoDans = new List<HoDan>();
        }

        public void NhapHoDan()
        {
            Console.WriteLine("Nhap so luong thanh vien trong ho: ");
            int soThanhVien = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so nha: ");
            int soNha = int.Parse(Console.ReadLine());

            List<Nguoi> thanhVien = new List<Nguoi>();
            for (int i = 0; i < soThanhVien; i++)
            {
                Console.WriteLine($"Nhap thong tin thanh vien thu {i + 1}: ");
                Console.WriteLine("Nhap ho va ten: ");
                string hoTen = Console.ReadLine();

                DateTime ngaySinh;
                Console.WriteLine("Nhap ngay sinh (dd/MM/yyyy): ");
                while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaySinh))
                {
                    Console.WriteLine("Ngay sinh khong hop le. Vui long nhap lai (dd/MM/yyyy): ");
                }

                Console.WriteLine("Nhap nghe nghiep: ");
                string ngheNghiep = Console.ReadLine();

                thanhVien.Add(new Nguoi(hoTen, ngaySinh, ngheNghiep));
            }

            HoDans.Add(new HoDan(soThanhVien, soNha, thanhVien));
        }

        public void HienThiThongTinHoDanMuonTho()
        {
            foreach (var hoDan in HoDans)
            {
                if (hoDan.CoNguoiMuonTho())
                {
                    Console.WriteLine(hoDan);
                }
            }
        }
    }
}