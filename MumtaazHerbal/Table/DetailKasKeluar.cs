namespace MumtaazHerbal
{
    public class DetailKasKeluar
    {
        public int Id { get; set; }

        public int KaskeluarId { get; set; }

        public string Keterangan { get; set; }

        public KasKeluar KasKeluar { get; set; }

        public int Total { get; set; }
    }

}
