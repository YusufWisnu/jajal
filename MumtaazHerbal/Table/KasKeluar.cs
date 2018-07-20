using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MumtaazHerbal
{
    public class KasKeluar
    {
        public int Id { get; set; }

        [Index(IsUnique = true)]
        public string NoTransaksi { get; set; }

        public DateTime Tanggal { get; set; }

        public string Keterangan { get; set; }

        public int Total { get; set; }

        public IList<DetailKasKeluar> DetailKasKeluars { get; set; } 
    }

}
