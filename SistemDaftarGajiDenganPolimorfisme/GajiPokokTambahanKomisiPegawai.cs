using System;
using System.Collections.Generic;
using System.Text;

namespace SistemDaftarGajiDenganPolimorfisme
{
    class GajiPokokTambahanKomisiPegawai : KomisiPegawai
    {
        private decimal gajiPokok; // gaji pokok mingguan

        //6 parameter konstruktor     
        public GajiPokokTambahanKomisiPegawai(string namaDepan, string namaBelakang, string nomorKTP, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok): base(namaDepan, namaBelakang, nomorKTP, penjualanKotor, tingkatKomisi)
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
        public override string ToString() =>
            $"Pegawai dengan gaji pokok: {base.ToString()}\n" + $"Gaji pokok: {gajiPokok:C}";

    }
}
