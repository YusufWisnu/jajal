
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MumtaazHerbal
{
    public class Pembelian
    {
        public int Id { get; set; }

        [Index(IsUnique = true)]
        public string NoTransaksi { get; set; }

        public DateTime Tanggal { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public IList<DetailPembelian> DetailPembelians{ get; set; }

        public int TotalHarga { get; set; }

    }

}
