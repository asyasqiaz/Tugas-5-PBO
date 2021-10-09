using System;
using System.Collections.Generic;
using System.Text;

namespace SistemDaftarGajiDenganAntarmuka
{
    class Faktur : AntarmukaPembayaran
    {
        public string NomorBagian { get; }
        public string DeskripsiBagian { get; }
        private int jumlah;
        private decimal hargaPerBarang;

        // 4 parameter konstruktor
        public Faktur(string nomorBagian, string deskripsiBagian, int jumlah, decimal hargaPerBarang)
        {
            NomorBagian = nomorBagian;
            DeskripsiBagian = deskripsiBagian;
            Jumlah = jumlah; // validasi jumlah
            HargaPerBarang = hargaPerBarang; // validate price per item
        }

        // properti untuk mendapatkan dan menetapkan nilai jumlah pada faktur
        public int Jumlah
        { 
            get { return jumlah; }
            set
            {
                if (value< 0) // validasi
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jumlah)} pasti >= 0");
                    }

                jumlah = value;
            }
        }

         // properti untuk mendapatkan dan menetapkan nilai harga per barang 
         public decimal HargaPerBarang
         {
            get { return hargaPerBarang; }
            set
            {
                if (value < 0) // validasi
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(HargaPerBarang)} pasti >= 0");
                }

                hargaPerBarang = value;
            }
         }

        // mengembalikan representasi string dari objek Faktur 
        public override string ToString() =>
        $"Faktur:\nNomor bagian: {NomorBagian} ({DeskripsiBagian})\n" +$"Jumlah: {Jumlah}\nHarga per barang: {HargaPerBarang:C}";

        // metode yang diperlukan untuk membayar dengan AntarmukaPembayaran
        public decimal DapatkanJumlahPembayaran() => Jumlah * HargaPerBarang;

    }
}
