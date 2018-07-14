using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MumtaazHerbal
{
    public class Piutang
    {
        public int Id { get; set; }

        [Index(IsUnique = true)]
        public string NoTransaksi { get; set; }

        public DateTime Tanggal { get; set; }

        public int Total { get; set; }

        //public int Penjualan_Id { get; set; }

        //public Penjualan Penjualan { get; set; }

        public IList<Penjualan> Penjualans { get; set; }

    }
}
