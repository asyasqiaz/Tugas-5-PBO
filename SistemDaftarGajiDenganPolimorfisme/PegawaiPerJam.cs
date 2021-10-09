using System;
using System.Collections.Generic;
using System.Text;

namespace SistemDaftarGajiDenganPolimorfisme
{
    class PegawaiPerJam : Pegawai
    {
        private decimal gaji; // gaji per jam
        private decimal jam; // jam kerja selama satu minggu

        // 5 parameter konstruktor
        public PegawaiPerJam(string namaDepan, string namaBelakang, string nomorKTP, decimal gajiPerJam, decimal jamKerja) : base(namaDepan, namaBelakang, nomorKTP)
        {
            Gaji = gajiPerJam; // memvalidasi gaji per jam
            Jam = jamKerja; // memvalidasi jam kerja
        }

        // properti yang mendapatkan dan menetapkan nilai gaji per jam pegawai
        public decimal Gaji
        {
            get { return gaji; }
            set
            {
                if (value < 0) // validasi
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Gaji)} pasti >= 0");
                }
                gaji = value;
            }
        }

        // properti yang mendapatkan dan menetapkan nilai jam kerja PegawaiPerJam
        public decimal Jam
        {
            get { return jam; }
            set
            {
                if (value < 0) // validasi
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jam)} pasti >= 0 dan <= 168");
                }
                jam = value;
            }
        }

        // menghitung penghasilan, timpa/override metode abstrak Penghasilan Pegawai
        public override decimal Penghasilan()
        {
            if (jam <= 40) // tidak ada lembur
            {
                return Gaji * Jam;
            }
            else
            {
                return (40 * Gaji) + ((Jam - 40) * Gaji * 1.5M);
            }
        }

        // mengembalikan representasi string dari objek PegawaiPerJam
        public override string ToString() =>
            $"Pegawai per jam: {base.ToString()}\n" + $"Gaji per jam: {Gaji:C}\nJam kerja: {Jam:F2}";

    }
}
