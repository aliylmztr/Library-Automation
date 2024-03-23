using LibraryAutomation.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public AdminSayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach(Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarihi(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());
            }

            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapYazar(), kitap.getKitapDili(), kitap.getYayinEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaSayisi(), kitap.getBasimYil());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyisim.Text, maskedTextBox1.Text, txt_kullaniciAdi.Text, txt_sifre.Text, txt_yetki.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        public void textleriDoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string olusturmaTarihi = maskedTextBox1.Text;
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, olusturmaTarihi, kullaniciAdi, sifre, yetki);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBox_uyeIslemleri.Controls.Count; i++)
            {
                if(groupBox_uyeIslemleri.Controls[i] is TextBox || groupBox_uyeIslemleri.Controls[i] is MaskedTextBox)
                {
                    groupBox_uyeIslemleri.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapId.Text, txt_kitapIsim.Text, txt_kitapYazar.Text, txt_kitapDili.Text, txt_yayinEvi.Text, txt_tur.Text, txt_adet.Text, txt_sayfaSayisi.Text, txt_basimYil.Text);
        }

        private void btn_kitapSil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitapGuncelle_Click(object sender, EventArgs e)
        {
            string kitapId = txt_kitapId.Text;
            string kitapIsim = txt_kitapIsim.Text;
            string kitapYazar = txt_kitapYazar.Text;
            string kitapDili = txt_kitapDili.Text;
            string yayinEvi = txt_yayinEvi.Text;
            string tur = txt_tur.Text;
            string adet = txt_adet.Text;
            string sayfaSayisi = txt_sayfaSayisi.Text;
            string basimYil = txt_basimYil.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapId, kitapIsim, kitapYazar, kitapDili, yayinEvi, tur, adet, sayfaSayisi, basimYil);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapIsim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapYazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_kitapDili.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinEvi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_tur.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfaSayisi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basimYil.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kitapTemizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBox_kitapIslemleri.Controls.Count; i++)
            {
                if(groupBox_kitapIslemleri.Controls[i] is TextBox)
                {
                    groupBox_kitapIslemleri.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_kisiAra_Click(object sender, EventArgs e)
        {
            Kisi hedefKisi = null;
            int secilenKisiId = Convert.ToInt32(txt_kisiAra.Text);

            foreach(Kisi kisi in kisilerim)
            {
                if(kisi.getId() == secilenKisiId)
                {
                    hedefKisi = kisi;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarihi(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());

        }

        private void btn_kisiYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach(Kisi hedefKisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarihi(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
            }
        }

        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
            Kitap hedefKitap = null;
            int secilenKitapId = Convert.ToInt32(txt_kitapAra.Text);

            foreach(Kitap kitap in kitaplarim)
            {
                if(kitap.getKitapId() == secilenKitapId)
                {
                    hedefKitap = kitap;
                    break;
                }
            }

            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYil()); 

        }

        private void btn_kitapYenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach(Kitap hedefKitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYil());
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }        
    }
}
