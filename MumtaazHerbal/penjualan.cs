namespace MumtaazHerbal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("penjualan")]
    public partial class penjualan
    {
        public int id { get; set; }

        [StringLength(100)]
        public string no_trans { get; set; }

        public DateTime? tgl_trans { get; set; }

        public int jumlah { get; set; }

        public int total { get; set; }

        public int daftar_pelanggan_id { get; set; }

        public int items_id { get; set; }

        public int grup_pelanggan_id { get; set; }

        public virtual daftar_pelanggan daftar_pelanggan { get; set; }

        public virtual grup_pelanggan grup_pelanggan { get; set; }

        public virtual item item { get; set; }
    }
}
