using System;
using System.Collections.Generic;
using System.Text;

namespace SistemDaftarGajiDenganAntarmuka
{
    public abstract class Pegawai : AntarmukaPembayaran
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NomorKTP { get; }

        // 3 parameter konstruktor
        public Pegawai(string namaDepan, string namaBelakang, string nomorKTP)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NomorKTP = nomorKTP;
        }

        // mengembalikan representasi string dari objek pegawai, menggunakan properti
        public override string ToString() => $"{NamaDepan} {NamaBelakang}\n" + $"Nomor KTP: {NomorKTP}";

        // method abstrak ditimpa/di-override oleh kelas turunan
        public abstract decimal Penghasilan(); // di sini tidak ada implementasi

        // mengimplementasikan DapatkanJumlahPembayaran di sini memungkinkan seluruh pegawai untuk memperoleh pembayaran
        // hierarki kelas yang akan digunakan dalam aplikasi yang memproses AntarmukaPembayaran
        public decimal DapatkanJumlahPembayaran() => Penghasilan();

    }
}
