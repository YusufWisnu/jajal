namespace MumtaazHerbal
{
    public class DetailPenjualan
    {
        public int Id { get; set; }

        public int JumlahBarang { get; set; }

        public int PenjualanId { get; set; }

        public Penjualan Penjualan { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

    }
}
