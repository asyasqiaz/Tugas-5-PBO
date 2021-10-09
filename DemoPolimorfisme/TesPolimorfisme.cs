using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPolimorfisme
{
    class TesPolimorfisme
    {
        static void Main()
        {
            // menetapkan referensi kelas induk ke variabel kelas induk
            var komisiPegawai = new KomisiPegawai("Sue", "Jones", "222-22-2222", 10000.00M, .06M);
            // menetapkan referensi kelas turunan ke variabel kelas turunan
            var gajiPokokTambahanKomisiPegawai = new GajiPokokTambahanKomisiPegawai("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            // memanggil ToString dan Penghasilan ke objek kelas induk
            // menggunakan variabel kelas induk
            Console.WriteLine("Memanggil metode ToString dan Penghasilan Komisi Pegawai " + "dengan referensi kelas induk ke objek kelas induk\n");
            Console.WriteLine(komisiPegawai.ToString());
            Console.WriteLine($"Penghasilan: {komisiPegawai.Penghasilan()}\n");

            // memanggil ToString dan Penghasilan ke objek kelas turunan
            // menggunakan variabel kelas turunan
            Console.WriteLine("Memanggil metode ToString Gaji Pokok Tambahan Komisi Pegawai dan " + "metode Penghasilan dengan referensi kelas turunan ke " +"objek kelas turunan\n");
            Console.WriteLine(gajiPokokTambahanKomisiPegawai.ToString());
            Console.WriteLine($"Penghasilan: {gajiPokokTambahanKomisiPegawai.Penghasilan()}\n");

            // memanggil ToString dan Penghasilan ke objek kelas turunan
            // menggunakan variabel kelas induk
            KomisiPegawai komisiPegawai2 = gajiPokokTambahanKomisiPegawai;
            Console.WriteLine("Memanggil metode ToString Gaji Pokok Tambahan Komisi Pegawai dan Penghasilan " + " dengan referensi kelas induk ke objek kelas turunan\n");
            Console.WriteLine(komisiPegawai2.ToString());
            Console.WriteLine($"Penghasilan: {gajiPokokTambahanKomisiPegawai.Penghasilan()}\n");

            Console.ReadLine();
        }
    }
}
