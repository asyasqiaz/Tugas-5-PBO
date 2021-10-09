using System;
using System.Collections.Generic;
using System.Text;

namespace KomisiPegawaiTanpaInheritance
{
    public class GajiPokokTambahanKomisiPegawai
    {
        public string NamaAwal { get; }
        public string NamaAkhir { get; }
        public string NomorKTP { get; }
        private decimal penjualanKotor; // penjualan kotor mingguan
        private decimal tingkatKomisi; // persentase komisi
        private decimal gajiPokok; // gaji pokok mingguan

        // 6 parameter konstruktor
        public GajiPokokTambahanKomisiPegawai(string namaAwal, string namaAkhir, string nomorKTP, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok)
        {
            // panggilan implisit ke konstruktor objek terjadi di bagian ini
            NamaAwal = namaAwal;
            NamaAkhir = namaAkhir;
            NomorKTP = nomorKTP;
            PenjualanKotor = penjualanKotor;
            TingkatKomisi = tingkatKomisi;
            GajiPokok = gajiPokok;
        }

        // properti yang mendapatkan dan menetapkan penjualan kotor
        public decimal PenjualanKotor
        {
            get { return penjualanKotor; }
            set
            {
                if (value < 0) // validasi
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PenjualanKotor)} pasti >= 0");
                }
                penjualanKotor = value;
            }
        }

        // properti yang mendapatkan dan menetapkan tingkat komisi pegawai
        public decimal TingkatKomisi
        {
            get { return tingkatKomisi; }
            set
            {
                if (value <= 0 || value >= 1) // validasi
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(TingkatKomisi)} pasti > 0 and < 1");
                }
                tingkatKomisi = value;
            }
        }

        // properti yang mendapatkan dan menetapkan gaji pokok komisi pegawai
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
        public decimal Penghasilan()
        {
            return gajiPokok + (tingkatKomisi * penjualanKotor);
        }

        // mengembalikan representasi string dari objek KomisiPegawai
        public override string ToString()
        {
            return $"Pegawai dengan komisi gaji pokok : {NamaAwal} {NamaAkhir}\n" + $"Nomor KTP : {NomorKTP}\n" + $"Penjualan kotor : {penjualanKotor}\n" + $"Tingkat komisi : {tingkatKomisi:F2}\n" + $"Gaji pokok : {gajiPokok:C}";
        }
    }
}
