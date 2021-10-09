using System;
using System.Collections.Generic;
using System.Text;

namespace SistemDaftarGajiDenganAntarmuka
{
    class TesAntarmukaPembayaran
    {
        static void Main()
        {
            // membuat List/Daftar<AntarmukaPembayaran> dan inisialisasi dengan 4 objek kelas yang mengimplementasikan AntarmukaPembayaran
            var objekPembayaran = new List<AntarmukaPembayaran>
            {
                new Faktur("01234", "kursi", 2, 375.00M),
                new Faktur("56789", "ban", 4, 79.95M),
                new PegawaiYangDigaji("John","Smith","111-11-1111", 800.00M),
                new PegawaiYangDigaji("Lisa","Barnes","888-88-8888", 1200.00M)
            };

            Console.WriteLine("Faktur dan pegawai diproses secara polimorfis:\n");

            // secara umum memproses tiap elemen di objekPembayaran
            foreach (var pembayaran in objekPembayaran)
                {
                    // output pembayaran dan jumlah pembayarannya yang sesuai
                    Console.WriteLine($"{pembayaran}");
                    Console.WriteLine($"Tanggal jatuh tempo pembayaran: {pembayaran.DapatkanJumlahPembayaran():C}\n");
                }

            Console.ReadLine();
        }
    }
}
