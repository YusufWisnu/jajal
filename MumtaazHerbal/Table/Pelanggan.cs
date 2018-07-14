using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MumtaazHerbal
{
    public class Pelanggan
    {
        public int Id { get; set; }

        public string Nama { get; set; }

        [Index(IsUnique = true)]
        public string KodePelanggan { get; set; }

        public string NoHp { get; set; }

        public string Alamat { get; set; }

        public string Email { get; set; }

        public IList<Penjualan> Penjualans { get; set; }
    }
}
