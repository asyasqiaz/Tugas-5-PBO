using System;
using System.Collections.Generic;
using System.Text;

namespace KomisiPegawaiTanpaInheritance
{
    class TesGajiPokokTambahanKomisiPegawai
    {
        static void Main()
        {
            // memberi contoh objek GajiPokokTambahanKomisiPegawai
            var pegawai = new GajiPokokTambahanKomisiPegawai("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Program Membuat dan Menggunakan Kelas Gaji Pokok Tambahan Komisi Pegawai Tanpa Menggunakan Pewarisan (Inheritance)");

            // menampilkan data GajiPokokTambahanKomisiPegawai
            Console.WriteLine("\nInformasi pegawai diperoleh dengan properti dan metode: \n");
            Console.WriteLine($"Nama awal : {pegawai.NamaAwal}");
            Console.WriteLine($"Nama akhir : {pegawai.NamaAkhir}");
            Console.WriteLine($"Nomor KTP : {pegawai.NomorKTP}");
            Console.WriteLine($"Penjualan kotor : {pegawai.PenjualanKotor:C}");
            Console.WriteLine($"Tingkat komisi : {pegawai.TingkatKomisi:F2}");
            Console.WriteLine($"Penghasilan yang diperoleh : {pegawai.Penghasilan():C}");
            Console.WriteLine($"Gaji pokok : {pegawai.GajiPokok:C}");

            pegawai.GajiPokok = 1000.00M; // menetapkan gaji pokok

            Console.WriteLine("\nInformasi pegawai yang diperbarui diperoleh oleh ToString:\n");
            Console.WriteLine(pegawai);
            Console.WriteLine($"Penghasilan yang diperoleh : {pegawai.Penghasilan():C}");

            Console.ReadLine();
        }
    }
}
