using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojistikApp
{
    public partial class Ur : Form
    {
        public Ur()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        private void button7_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.UrunlerSet.ToList();
        }
        public void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunler ekle = new Urunler();
            ekle.UrunAdi = textBox2.Text;
            ekle.StokMiktari = Convert.ToInt32(textBox3.Text);
            ekle.UrunTipi = textBox4.Text;
            baglanti.UrunlerSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.UrunlerSet.ToList();
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;
            Urunler sil = baglanti.UrunlerSet.SingleOrDefault(f => f.urun_id == id);
            baglanti.UrunlerSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.UrunlerSet.ToList();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Text = satir.Cells["UrunAdi"].Value.ToString();
            textBox2.Tag = satir.Cells["urun_id"].Value;
            textBox3.Text = satir.Cells["StokMiktari"].Value.ToString();
            textBox4.Text = satir.Cells["UrunTipi"].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;

            Urunler yenile = baglanti.UrunlerSet.SingleOrDefault(g => g.urun_id == id);
            yenile.UrunAdi = textBox2.Text;
            yenile.StokMiktari = Convert.ToInt32(textBox3.Text);
            yenile.UrunTipi = textBox4.Text;
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.UrunlerSet.ToList();
            Temizle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var arama = baglanti.UrunlerSet.Where(p => p.urun_id == id);
            dataGridView1.DataSource = arama.ToList();
        }
    }
}
