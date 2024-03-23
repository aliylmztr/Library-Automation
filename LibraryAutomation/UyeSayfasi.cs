using LibraryAutomation.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapYazar(), kitap.getKitapDili(), kitap.getYayinEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaSayisi(), kitap.getBasimYil());
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            Kitap hedefKitap = null;
            int secilenKitapId = Convert.ToInt32(txt_ara.Text);

            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getKitapId() == secilenKitapId)
                {
                    hedefKitap = kitap;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYil());
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach (Kitap hedefKitap in kitaplarim)
            {
                dataGridView1.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYil());
            }
        }
    }
}
