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
    public partial class Sevk : Form
    {
        public Sevk()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        private void Sevk_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = baglanti.FirmalarSet.ToList();
            comboBox1.DisplayMember = "FirmaTipi";
            comboBox1.ValueMember = "firma_id";


            comboBox2.DataSource = baglanti.UrunlerSet.ToList();
            comboBox2.DisplayMember = "UrunAdi";
            comboBox2.ValueMember = "urun_id";

            comboBox1.Text = "";
            comboBox2.Text = "";
            groupBox1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                button6.Visible = true;
            }
            else
            {
                label1.Visible = true;
                textBox1.Visible = true;
                button6.Visible = true;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int id = Convert.ToInt32(textBox1.Text);
                var arama = baglanti.SevkiyatSet.Where(p => p.sevkiyat_id == id);
                dataGridView1.DataSource = arama.ToList();
            }
            else
            {
                string tip = textBox1.Text;
                var tiparama = baglanti.SevkiyatSet.Where(p => p.SevkAdi == tip);
                dataGridView1.DataSource = tiparama.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.SevkiyatSet.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Text = satir.Cells["SevkAdi"].Value.ToString();
            textBox2.Tag = satir.Cells["sevkiyat_id"].Value;
            textBox3.Text = satir.Cells["Ulke"].Value.ToString();
            comboBox2.Text = satir.Cells["Urunler_urun_id"].Value.ToString();
            comboBox1.Text = satir.Cells["Firmalar_firma_id"].Value.ToString();


        }
        public void Temizle()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sevkiyat ekle = new Sevkiyat();
            ekle.SevkAdi = textBox2.Text;
            ekle.Ulke = textBox3.Text;
            ekle.Urunler_urun_id = Convert.ToInt32(comboBox2.SelectedValue);
            ekle.Firmalar_firma_id = Convert.ToInt32(comboBox1.SelectedValue);
            baglanti.SevkiyatSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.SevkiyatSet.ToList();
            Temizle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            label1.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;

            Sevkiyat yenile = baglanti.SevkiyatSet.SingleOrDefault(g => g.sevkiyat_id == id);
            yenile.SevkAdi = textBox2.Text;
            yenile.Ulke = textBox3.Text;
            yenile.Urunler_urun_id = Convert.ToInt32(comboBox2.SelectedValue);
            yenile.Firmalar_firma_id = Convert.ToInt32(comboBox1.SelectedValue);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.SevkiyatSet.ToList();
            Temizle();
        }
    }
}
