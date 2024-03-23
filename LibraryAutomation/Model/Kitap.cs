namespace LibraryAutomation.Model
{
    public class Kitap
    {
        public int kitapId;
        public string kitapIsim;
        public string kitapYazar;
        public string kitapDili;
        public string yayinEvi;
        public string tur;
        public int adet;
        public int sayfaSayisi;
        public int basimYil;

        public Kitap()
        {

        }

        public Kitap(int kitapId, string kitapIsim, string kitapYazar, string kitapDili, string yayinEvi, string tur, int adet, int sayfaSayisi, int basimYil)
        {
            this.kitapId = kitapId;
            this.kitapIsim = kitapIsim;
            this.kitapYazar = kitapYazar;
            this.kitapDili = kitapDili;
            this.yayinEvi = yayinEvi;
            this.tur = tur;
            this.adet = adet;
            this.sayfaSayisi = sayfaSayisi;
            this.basimYil = basimYil;
        }

        public int getKitapId()
        {
            return this.kitapId;
        }

        public string getKitapIsim()
        {
            return this.kitapIsim;
        }

        public string getKitapYazar()
        {
            return this.kitapYazar;
        }

        public string getKitapDili()
        {
            return this.kitapDili;
        }

        public string getYayinEvi()
        {
            return this.yayinEvi;
        }

        public string getTur()
        {
            return this.tur;
        }

        public int getAdet()
        {
            return this.adet;
        }

        public int getSayfaSayisi()
        {
            return this.sayfaSayisi;
        }

        public int getBasimYil()
        {
            return this.basimYil;
        }
    }
}
