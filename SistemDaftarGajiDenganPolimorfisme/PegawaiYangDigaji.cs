using System;
using System.Collections.Generic;
using System.Text;

namespace SistemDaftarGajiDenganPolimorfisme
{
    class PegawaiYangDigaji : Pegawai
    {
        private decimal gajiMingguan;

        // 4 parameter konstruktor
        public PegawaiYangDigaji(string namaDepan, string namaBelakang, string nomorKTP, decimal gajiMingguan) : base(namaDepan, namaBelakang, nomorKTP)
        {
            GajiMingguan = gajiMingguan; // memvalidasi gaji
        }

        // properti yang mendapatkan dan menetapkan nilai gaji PegawaiYangDigaji
        public decimal GajiMingguan
        {
            get { return gajiMingguan; }
            set
            {
                if (value < 0) // validasi
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiMingguan)} pasti >= 0");
                }
                gajiMingguan = value;
            }
        }

        // menghitung penghasilan, timpa/override metode abstrak Penghasilan di Pegawai
        public override decimal Penghasilan() => gajiMingguan;

        // mengembalikan representasi string dari objek PegawaiYangDigaji
        public override string ToString() =>
            $"Pegawai yang digaji: {base.ToString()}\n" + $"Gaji mingguan: {GajiMingguan:C}";
    }
}
