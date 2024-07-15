using CS_Bai4_QLHD;

class Program
{
    static void Main(string[] args)
    {
        KhuPho khuPho = new KhuPho();

        Console.WriteLine("Nhap so luong ho dan: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin cho ho dan thu {i + 1}: ");
            khuPho.NhapHoDan();
        }

        Console.WriteLine("\nThong tin cac ho dan co nguoi mung thuong tho (80 tuoi): ");
        khuPho.HienThiThongTinHoDanMuonTho();
    }
}