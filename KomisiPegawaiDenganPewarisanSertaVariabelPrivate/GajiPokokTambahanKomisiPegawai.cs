using System;
using System.Collections.Generic;
using System.Text;

namespace KomisiPegawaiDenganPewarisan
{
    public class GajiPokokTambahanKomisiPegawai : KomisiPegawai
    {
        

        private decimal gajiPokok; // gaji pokok mingguan

        // konstruktor kelas turunan 6 parameter
        // dengan memanggil ke konstruktor kelas induk CommissionEmployee

        public GajiPokokTambahanKomisiPegawai(string namaAwal, string namaAkhir, string nomorKTP, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok) : base(namaAwal, namaAkhir, nomorKTP, penjualanKotor, tingkatKomisi)
        {
            GajiPokok = gajiPokok; // memvalidasi gaji pokok
        }

        // properti untuk mendapatkan dan menetapkan nilai
        // gaji pokok kelas GajiPokokTambahanKomisiPegawai
        public decimal GajiPokok
        {
            get { return gajiPokok; }
            set
            {
                if (value < 0) // validasi
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiPokok)} pasti >= 0");
                }
                gajiPokok = value;
            }
        }

        // perhitungan penghasilan
        public override decimal Penghasilan() => GajiPokok + base.Penghasilan();

        // mengembalikan representasi string dari objek KomisiPegawai
        // tidak dibolehkan mengakses anggota private kelas induk 
        public override string ToString() =>
            $"Penghasilan pokok {base.ToString()}\nGaji pokok: {GajiPokok:C}";

    }
}
