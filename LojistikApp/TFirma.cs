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
    public partial class TFirma : Form
    {
        public TFirma()
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

        public void Temizle()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox1.Text = "";
            comboBox2.Text = "";
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            label1.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.TasiyiciFirmalarSet.ToList();
        }

        private void TFirma_Load(object sender, EventArgs e)
        {
           
            groupBox1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                int id = Convert.ToInt32(textBox1.Text);
                var arama = baglanti.TasiyiciFirmalarSet.Where(p => p.tasiyici_id == id);
                dataGridView1.DataSource = arama.ToList();
            }
            else
            {
                string tip = textBox1.Text;
                var tiparama = baglanti.TasiyiciFirmalarSet.Where(p => p.TFirmaAdi == tip);
                dataGridView1.DataSource = tiparama.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TasiyiciFirmalar ekle = new TasiyiciFirmalar();
            ekle.TFirmaAdi = textBox2.Text;
            ekle.TFirmaAdresi = textBox3.Text;
            ekle.TFirmaTel = maskedTextBox1.Text;
            ekle.TasimaSekli = comboBox2.SelectedItem.ToString();
            ekle.Firmalar_firma_id = 3;
            baglanti.TasiyiciFirmalarSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.TasiyiciFirmalarSet.ToList();
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;
            TasiyiciFirmalar sil = baglanti.TasiyiciFirmalarSet.SingleOrDefault(c => c.tasiyici_id == id);
            baglanti.TasiyiciFirmalarSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.TasiyiciFirmalarSet.ToList();
            Temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;

            TasiyiciFirmalar yenile = baglanti.TasiyiciFirmalarSet.SingleOrDefault(g => g.tasiyici_id == id);
            yenile.TFirmaAdi = textBox2.Text;
            yenile.TFirmaAdresi = textBox3.Text;
            yenile.TFirmaTel = maskedTextBox1.Text;
            yenile.TasimaSekli = comboBox2.SelectedItem.ToString();
            yenile.Firmalar_firma_id =3;
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.TasiyiciFirmalarSet.ToList();
            Temizle();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Text = satir.Cells["TFirmaAdi"].Value.ToString();
            textBox2.Tag = satir.Cells["tasiyici_id"].Value;
            textBox3.Text = satir.Cells["TFirmaAdresi"].Value.ToString();
            maskedTextBox1.Text = satir.Cells["TFirmaTel"].Value.ToString();
            comboBox2.Text= satir.Cells["TasimaSekli"].Value.ToString();
           
        }
    }
}
