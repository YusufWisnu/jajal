
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MumtaazHerbal
{

    public class Penjualan
    {
        public int Id { get; set; }

        [Index(IsUnique = true)]
        public string NoTransaksi { get; set; }

        public DateTime Tanggal { get; set; }

        public int PelangganId { get; set; }

        public Pelanggan Pelanggan { get; set; }

        public IList<DetailPenjualan> DetailPenjualans { get; set; }

        //total modal
        public int SubTotal { get; set; }

        public int TotalHarga { get; set; }

        public int BayarTunai { get; set; }

        public int BayarKredit { get; set; }

        public int JumlahItem { get; set; }

        public bool IsPending { get; set; }

        public string Keterangan { get; set; }

        /* -----------JIKA PELANGGAN ADA HUTANG-------------*/

        public int Sisa { get; set; }

        public DateTime? TanggalJT { get; set; }

        public IList<DetailPiutang> DetailPiutangs { get; set; }

        //public int? PiutangId { get; set; }

        //public Piutang Piutang { get; set; }

    }


}
