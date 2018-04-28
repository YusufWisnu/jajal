namespace MumtaazHerbal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class grup_pelanggan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public grup_pelanggan()
        {
            daftar_pelanggan = new HashSet<daftar_pelanggan>();
            penjualans = new HashSet<penjualan>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string kode_pelanggan { get; set; }

        [Required]
        [StringLength(20)]
        public string grup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<daftar_pelanggan> daftar_pelanggan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<penjualan> penjualans { get; set; }
    }
}
