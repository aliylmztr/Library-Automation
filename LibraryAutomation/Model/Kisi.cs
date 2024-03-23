using System;

namespace LibraryAutomation.Model
{
    public class Kisi
    {
        public int id;
        public string isim, soyisim, kullaniciAdi, sifre, yetki;
        public DateTime olusturmaTarihi;
        public Kisi()
        {

        }

        public Kisi(int id, string isim, string soyisim, DateTime olusturmaTarihi, string kullaniciAdi, string sifre, string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmaTarihi = olusturmaTarihi;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getIsim()
        {
            return this.isim;
        }

        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public string getSoyisim()
        {
            return this.soyisim;
        }

        public void setSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }

        public DateTime getOlusturmaTarihi()
        {
            return this.olusturmaTarihi;
        }

        public void setOlusturmaTarihi(DateTime olusturmaTarihi)
        {
            this.olusturmaTarihi = olusturmaTarihi;
        }

        public string getKullaniciAdi()
        {
            return this.kullaniciAdi;
        }

        public void setKullaniciAdi(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }

        public string getSifre()
        {
            return this.sifre;
        }

        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }

        public string getYetki()
        {
            return this.yetki;
        }

        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }

        public override string ToString()
        {
            return "İsim - Soyisim: " + this.isim + " " + this.soyisim;
        }
    }
}
