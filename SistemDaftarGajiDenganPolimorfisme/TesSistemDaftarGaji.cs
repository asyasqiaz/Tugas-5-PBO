using System;
using System.Collections.Generic;
using System.Text;

namespace SistemDaftarGajiDenganPolimorfisme
{
    class TesSistemDaftarGaji
    {
        static void Main()
        {
            var pegawaiYangDigaji = new PegawaiYangDigaji("John", "Smith", "111-11-1111", 800.00M);
            var pegawaiPerJam = new PegawaiPerJam("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            var komisiPegawai = new KomisiPegawai("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            var gajiPokokTambahanKomisiPegawai = new GajiPokokTambahanKomisiPegawai("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Pegawai diproses secara individual:\n");
            Console.WriteLine($"{pegawaiYangDigaji}\nMemperoleh: " + $"{pegawaiYangDigaji.Penghasilan():C}\n");
            Console.WriteLine($"{pegawaiPerJam}\nMemperoleh: {pegawaiPerJam.Penghasilan():C}\n");
            Console.WriteLine($"{komisiPegawai}\nMemperoleh: " + $"{komisiPegawai.Penghasilan():C}\n");
            Console.WriteLine($"{gajiPokokTambahanKomisiPegawai}\nMemperoleh: " + $"{gajiPokokTambahanKomisiPegawai.Penghasilan():C}\n");

            // membuat List/Daftar <Pegawai> dan menginisialisasi dengan objek pegawai
            var kumpulanPegawai = new List<Pegawai>() { pegawaiYangDigaji, pegawaiPerJam, komisiPegawai, gajiPokokTambahanKomisiPegawai };

            Console.WriteLine("Pegawai diproses secara polimorfis:\n");

            // secara umum memproses tiap elemen dalam pegawai
            foreach (var pegawaiSaatIni in kumpulanPegawai)
            {
                Console.WriteLine(pegawaiSaatIni); // memanggl ToString

                // menentukan apakah elemen merupakan GajiPokokTambahanKmisiPegawai
                if (pegawaiSaatIni is GajiPokokTambahanKomisiPegawai)
                {
                    // menurunkan referensi pegawai ke referensi GajiPokokTambahanKomisiPegawai
                    var pegawai = (GajiPokokTambahanKomisiPegawai) pegawaiSaatIni;

                    pegawai.GajiPokok *= 1.10M;
                    Console.WriteLine("Gaji pokok baru dengan peningkatan 10%: " + $"{pegawai.GajiPokok:C}");
                }

                Console.WriteLine($"Penghasilan: {pegawaiSaatIni.Penghasilan():C}\n");
            }

            // mendapatkan tipe nama dari tiap objek di pegawai
            for (int j = 0; j < kumpulanPegawai.Count; j++)
            {
                Console.WriteLine($"Pegawai {j} adalah seorang {kumpulanPegawai[j].GetType()}");
            }


            Console.ReadLine();
        }
    }
}
