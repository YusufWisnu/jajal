using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MumtaazHerbal
{

    public class Supplier
    {
        public int Id { get; set; }

        [Index(IsUnique =true)]
        public string KodeSupplier { get; set; }

        public string NamaSupplier { get; set; }

        public string Alamat { get; set; }

        public string NoHP { get; set; }

        public string Email { get; set; }

        public IList<Item> Items { get; set; }

        public IList<Pembelian>  Pembelians{ get; set; }

    }

}
