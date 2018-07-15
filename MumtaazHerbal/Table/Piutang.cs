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

        public int PelangganId { get; set; }

        public Pelanggan Pelanggan { get; set; }

        public IList<DetailPiutang> DetailPiutangs { get; set; }

    }
}
