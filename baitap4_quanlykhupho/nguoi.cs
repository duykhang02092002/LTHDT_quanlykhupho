using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai4_QLHD
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NgheNghiep { get; set; }

        public Nguoi(string hoTen, DateTime ngaySinh, string ngheNghiep)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            NgheNghiep = ngheNghiep;
        }

        public int TinhTuoi()
        {
            int age = DateTime.Now.Year - NgaySinh.Year;
            if (DateTime.Now.DayOfYear < NgaySinh.DayOfYear)
                age -= 1;

            Console.WriteLine($"Ten: {HoTen}, Ngay sinh: {NgaySinh.ToShortDateString()}, Tuoi: {age}");
            return age;
        }

        public override string ToString()
        {
            return $"Ho va Ten: {HoTen}, Ngay Sinh: {NgaySinh.ToShortDateString()}, Nghe Nghiep: {NgheNghiep}";
        }
    }
}