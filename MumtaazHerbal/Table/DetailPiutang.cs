namespace MumtaazHerbal
{
    public class DetailPiutang
    {
        public int Id { get; set; }

        public int PiutangId { get; set; }

        public Piutang Piutang { get; set; }

        public int PenjualanId { get; set; }

        public Penjualan Penjualan { get; set; }

        public int JumlahBayar { get; set; }
    }
}
