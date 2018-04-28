namespace MumtaazHerbal
{
    public class Item
    {
        public int Id { get; set; }

        public string NamaItem { get; set; }

        public string KodeItem { get; set; }

        public int Stok { get; set; }

        public string Satuan { get; set; }

        public int HargaGrosir { get; set; }

        public int HargaEceran { get; set; }

        public int HargaJual { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

    }
}
