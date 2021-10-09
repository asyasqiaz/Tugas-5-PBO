﻿using System;
using System.Collections.Generic;
using System.Text;

    public class KomisiPegawai : object
    {
        public string NamaAwal { get; }
        public string NamaAkhir { get; }
        public string NomorKTP { get; }
        private decimal penjualanKotor; // penjualan kotor mingguan
        private decimal tingkatKomisi; // persentase komisi

        // 5 parameter konstruktor
        public KomisiPegawai(string namaAwal, string namaAkhir, string nomorKTP, decimal penjualanKotor, decimal tingkatKomisi)
        {
            // panggilan implisit ke konstruktor objek terjadi di bagian ini
            NamaAwal = namaAwal;
            NamaAkhir = namaAkhir;
            NomorKTP = nomorKTP;
            PenjualanKotor = penjualanKotor; // validasi penjualan kotor
            TingkatKomisi = tingkatKomisi; // validasi tingkat komisi
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
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(TingkatKomisi)} pasti > 0 and < 1");
                }
                tingkatKomisi = value;
            }
        }

        // perhitungan penghasilan komisi pegawai
        public virtual decimal Penghasilan()
        {
            return TingkatKomisi * PenjualanKotor;
        }

        // mengembalikan representasi string dari objek KomisiPegawai
        public override string ToString()
        {
            return $"Pegawai dengan komisi : {NamaAwal} {NamaAkhir}\n" + $"Nomor KTP : {NomorKTP}\n" + $"Penjualan kotor : {PenjualanKotor}\n" + $"Tingkat komisi : {TingkatKomisi:F2}";
        }
    
}
