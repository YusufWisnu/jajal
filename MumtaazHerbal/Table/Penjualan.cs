
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

        public int TotalHarga { get; set; }

        public bool IsPending { get; set; }

        public string Keterangan { get; set; }

    }
}
