using System;
using System.Collections.Generic;
using System.Text;

namespace KomisiPegawai
{
    class TesKomisiPegawai
    {
        static void Main()
        {
            // memberi contoh objek KomisiPegawai
            var pegawai = new KomisiPegawai("Sue", "Jones", "222-22-2222", 10000.00M, .06M);

            Console.WriteLine("Program Membuat Kelas Komisi Pegawai");

            // menampilkan data KomisiPegawai
            Console.WriteLine("\nInformasi pegawai diperoleh dengan properti dan metode: \n");
            Console.WriteLine($"Nama awal : {pegawai.NamaAwal}");
            Console.WriteLine($"Nama akhir : {pegawai.NamaAkhir}");
            Console.WriteLine($"Nomor KTP : {pegawai.NomorKTP}");
            Console.WriteLine($"Penjualan kotor : {pegawai.PenjualanKotor:C}");
            Console.WriteLine($"Tingkat komisi : {pegawai.TingkatKomisi:F2}");
            Console.WriteLine($"Penghasilan yang diperoleh : {pegawai.Penghasilan():C}");

            pegawai.PenjualanKotor = 5000.00M; // menetapkan penjualan kotor
            pegawai.TingkatKomisi = .1M; // menetapkan tingkat komisi

            Console.WriteLine("\nInformasi pegawai yang diperbarui diperoleh oleh ToString:\n");
            Console.WriteLine(pegawai);
            Console.WriteLine($"Penghasilan yang diperoleh : {pegawai.Penghasilan():C}");

            Console.ReadLine();
        }
    }
}