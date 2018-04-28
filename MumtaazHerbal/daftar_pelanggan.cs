namespace MumtaazHerbal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class daftar_pelanggan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public daftar_pelanggan()
        {
            penjualans = new HashSet<penjualan>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string nama { get; set; }

        [StringLength(255)]
        public string alamat { get; set; }

        public int? no_hp { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public int grup_pelanggan_id { get; set; }

        public virtual grup_pelanggan grup_pelanggan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<penjualan> penjualans { get; set; }
    }
}
