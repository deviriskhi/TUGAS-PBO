﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interharance_KomisiPegawai_2
{
    public class KomisiTambahanPegawai
    {
        public string NamaDepan;
        public string NamaBelakang;
        public string NomorKTP;
        private decimal penjualanKotor;
        private decimal tingkatKomisi;
        private decimal gajiPokok;

        public KomisiTambahanPegawai(string namaDepan, string namaBelakang, string nomorKTP, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NomorKTP = nomorKTP;
            PenjualanKotor = penjualanKotor;
            TingkatKomisi = tingkatKomisi;
            GajiPokok = gajiPokok;
        }
        public void setNamaDepan(string namaDepan)
        {
            NamaDepan = namaDepan;
        }
        public string getNamaDepan()
        {
            return NamaDepan;
        }
        public void setNamaBelakang(string namaBelakang)
        {
            NamaBelakang = namaBelakang;
        }
        public string getNamaBelakang()
        {
            return NamaBelakang;
        }
        public void setNomorKTP(string nomorKTP)
        {
            NomorKTP = nomorKTP;
        }
        public string getNomorKTP()
        {
            return NomorKTP;
        }
        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                penjualanKotor = (value < 0) ? 0 : value;
            }
        }

        public decimal TingkatKomisi
        {
            get
            {
                return tingkatKomisi;
            }
            set
            {
                tingkatKomisi = (value > 0 && value < 1) ? value : 0;
            }
        }

        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                gajiPokok = (value < 0) ? 0 : value;
            }
        }

        public decimal Pendapatan()
        {
            return gajiPokok + (tingkatKomisi * penjualanKotor);
        }

        public override string ToString()
        {
            return string.Format("Nama Depan : {0} \nNama Belakang : {1} \nNomor KTP : {2} \nPenjualan Kotor : {3} \nTingkat Komisi : {4} \nGaji Pokok : {5}", NamaDepan, NamaBelakang, NomorKTP, penjualanKotor, tingkatKomisi, gajiPokok);
        }

        static void Main(string[] args)
        {

            KomisiTambahanPegawai pegawai = new KomisiTambahanPegawai("Bob", "Lewis", "333-33-333", 5000.00M, .04M, 300.00M);

            Console.WriteLine(" Informasi pegawai diperoleh dengan properti dan metode: \n");
            Console.WriteLine("Nama Depan adalah {0}", pegawai.NamaDepan);
            Console.WriteLine("Nama Belakang adalah {0}", pegawai.NamaBelakang);
            Console.WriteLine("Nomor KTP adalah {0}", pegawai.NomorKTP);
            Console.WriteLine("Penjualan Kotornya adalah {0:C}", pegawai.PenjualanKotor);
            Console.WriteLine("Tingkat Komisinya adalah {0:F2}", pegawai.TingkatKomisi);
            Console.WriteLine("Gaji Pokoknya adalah {0:C}", pegawai.GajiPokok);
            Console.WriteLine("Pendapatanya adalah {0:C}", pegawai.Pendapatan());

            pegawai.PenjualanKotor = 5000.00M;
            pegawai.TingkatKomisi = .04M;
            pegawai.GajiPokok = 1000.00M;
            Console.WriteLine("\n{0}:\n\n{1}", " Informasi pegawai yang diperbarui diperoleh dari ToString", pegawai);
            Console.WriteLine("Pendapatan Pegawai : {0:C}", pegawai.Pendapatan());
            Console.ReadLine();
        }
    }
}
