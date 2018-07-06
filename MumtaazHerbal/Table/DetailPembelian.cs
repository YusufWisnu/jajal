namespace MumtaazHerbal
{
    public class DetailPembelian
    {
        public int Id { get; set; }

        public int JumlahBarang { get; set; }

        public int HargaBarang { get; set; }

        public int PembelianId { get; set; }

        public Pembelian Pembelian{ get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }
    }
}
