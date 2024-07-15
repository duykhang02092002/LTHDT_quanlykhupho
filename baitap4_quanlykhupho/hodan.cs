using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai4_QLHD
{
    internal class HoDan
    {
        public int SoThanhVien { get; set; }
        public int SoNha { get; set; }
        public List<Nguoi> ThanhVien { get; set; }

        public HoDan(int soThanhVien, int soNha, List<Nguoi> thanhVien)
        {
            SoThanhVien = soThanhVien;
            SoNha = soNha;
            ThanhVien = thanhVien;
        }

        public bool CoNguoiMuonTho()
        {
            foreach (var nguoi in ThanhVien)
            {
                if (nguoi.TinhTuoi() == 80)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string result = $"Số nhà: {SoNha}, Số thành viên: {SoThanhVien}\n";
            foreach (var nguoi in ThanhVien)
            {
                result += nguoi + "\n";
            }
            return result;
        }
    }
}