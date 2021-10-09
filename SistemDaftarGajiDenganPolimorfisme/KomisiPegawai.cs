using System;
using System.Collections.Generic;
using System.Text;

namespace SistemDaftarGajiDenganPolimorfisme
{
    class KomisiPegawai : Pegawai
    {
        private decimal penjualanKotor; // penjualan kotor mingguan
        private decimal tingkatKomisi; // persentase komisi

        // 5 parameter konstruktor
        public KomisiPegawai(string namaDepan, string namaBelakang, string nomorKTP, decimal penjualanKotor, decimal tingkatKomisi) : base(namaDepan, namaBelakang, nomorKTP)
        {
            // panggilan implisit ke konstruktor objek terjadi di bagian ini
            PenjualanKotor = penjualanKotor; // validasi penjualan kotor mingguan
            TingkatKomisi = tingkatKomisi; // validasi persentase komisi
        }

        // properti yang mendapatkan dan menetapkan komisi penjualan kotor pegawai
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
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(TingkatKomisi)} pasti > 0 dan < 1");
                }
                tingkatKomisi = value;
            }
        }

        // perhitungan penghasilan komisi pegawai
        public override decimal Penghasilan() => tingkatKomisi * penjualanKotor;

        // mengembalikan representasi string dari objek KomisiPegawai
        public override string ToString() =>
            $"Pegawai dengan komisi: {base.ToString()}\n" + $"Penjualan kotor : {penjualanKotor}\n" + $"Tingkat komisi : {tingkatKomisi:F2}";

    }
}
