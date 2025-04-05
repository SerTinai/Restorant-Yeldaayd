namespace Restoran
{
    public class Restoran
    {
        public string restoranAdi;
        public int sandalyeSayisi;

        public Restoran()
        {
            sandalyeSayisi = 16; // Varsayılan sandalye sayısı
        }

        public string MesajYazdir()
        {
            return "Bu restoranın adı: " + restoranAdi + " ve sandalye sayısı: " + sandalyeSayisi;
        }
    }
}
