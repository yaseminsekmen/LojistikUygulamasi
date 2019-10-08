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
    public partial class Pers : Form
    {
        public Pers()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        private void Pers_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = baglanti.DepartmanSet.ToList();
            comboBox1.DisplayMember = "DepartmanAdi";
            comboBox1.ValueMember = "departman_id";
            comboBox1.Text="";
        }
        public void Temizle()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.PersonellerSet.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personeller ekle = new Personeller();
            ekle.PersonelAdSoyad = textBox2.Text;
            ekle.PersonelTel = maskedTextBox1.Text;
            ekle.Departman_departman_id = Convert.ToInt32(comboBox1.SelectedValue);
            baglanti.PersonellerSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.PersonellerSet.ToList();
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;
            Personeller sil = baglanti.PersonellerSet.SingleOrDefault(f => f.personel_id == id);
            baglanti.PersonellerSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.PersonellerSet.ToList();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Text = satir.Cells["PersonelAdSoyad"].Value.ToString();
            textBox2.Tag = satir.Cells["personel_id"].Value;
            maskedTextBox1.Text = satir.Cells["PersonelTel"].Value.ToString();
            comboBox1.Text = satir.Cells["Departman_departman_id"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;

            Personeller yenile = baglanti.PersonellerSet.SingleOrDefault(g => g.personel_id == id);
            yenile.PersonelAdSoyad = textBox2.Text;
            yenile.PersonelTel = maskedTextBox1.Text;
            yenile.Departman_departman_id = Convert.ToInt32(comboBox1.SelectedValue);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.PersonellerSet.ToList();
            Temizle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var arama = baglanti.PersonellerSet.Where(p => p.personel_id == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }
    }
}
