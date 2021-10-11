using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interharance_KomisiPegawai_1
{
    public class KomisiPegawai : object
    {
        public string NamaDepan;
        public string NamaBelakang;
        public string NoKTP;
        private decimal penjualKotor;
        private decimal tarifKomisi;
        public KomisiPegawai(string namaDepan, string namaBelakang, string noKTP, decimal penjualKotor, decimal tarifKomisi)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NoKTP = noKTP;
            PenjualKotor = penjualKotor;
            TarifKomisi = tarifKomisi;
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
        public void setNoKTP(string noKTP)
        {
            NoKTP = noKTP;
        }
        public string getNoKTP()
        {
            return NoKTP;
        }
        public decimal PenjualKotor
        {
            get
            {
                return penjualKotor;
            }
            set
            {
                penjualKotor = (value < 0) ? 0 : value;
            }
        }
        public decimal TarifKomisi
        {
            get
            {
                return tarifKomisi;
            }
            set
            {
                tarifKomisi = (value > 0 && value < 1) ? value : 0;
            }
        }
        public decimal Pendapatan()
        {
            return TarifKomisi * PenjualKotor;
        }
        public override string ToString()
        {
            return string.Format("Nama Depan : {0}, \nNama Belakang : {1}, \nNo KTP : {2}, \nPenjual Kotor : {3}, \nTarif Komisi : {4}", NamaDepan, NamaBelakang, NoKTP, penjualKotor, tarifKomisi);
        }
        static void Main(string[] args)
        {
            KomisiPegawai pegawai = new KomisiPegawai("Sue", "Jones", "222-22-222", 10000.00M, .06M);

            Console.WriteLine("Informasi pegawai diperoleh dengan properti dan metode: \n");
            Console.WriteLine("Nama Depan adalah {0}", pegawai.NamaDepan);
            Console.WriteLine("Nama Belakang adalah {0}", pegawai.NamaBelakang);
            Console.WriteLine("No KTP adalah {0}", pegawai.NoKTP);
            Console.WriteLine("Penjual Kotor adalah {0:C}", pegawai.PenjualKotor);
            Console.WriteLine("Tarif Komisi adalah {0:F2}", pegawai.TarifKomisi);
            Console.WriteLine("Pendapatan adalah {0:C}", pegawai.Pendapatan());

            pegawai.PenjualKotor = 5000.00M;
            pegawai.TarifKomisi = .1M;
            Console.WriteLine("\n{0}:\n\n{1}", "Informasi terbaru pegawai yang diperoleh dari ToString", pegawai);
            Console.WriteLine("Pendapatan Pegawai : {0:C}", pegawai.Pendapatan());
            Console.ReadLine();
        }
    }
}
