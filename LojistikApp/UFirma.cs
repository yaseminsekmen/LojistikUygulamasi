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
    public partial class UFirma : Form
    {
        public UFirma()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        public void Temizle()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox1.Text = "";
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.UreticiFirmalarSet.ToList();
        }

        private void UFirma_Load(object sender, EventArgs e)
        {
           
            groupBox1.Visible = false;
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

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            label1.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                int id = Convert.ToInt32(textBox1.Text);
                var arama = baglanti.UreticiFirmalarSet.Where(p => p.uretici_id == id);
                dataGridView1.DataSource = arama.ToList();
            }
            else
            {
                string tip = textBox1.Text;
                var tiparama = baglanti.UreticiFirmalarSet.Where(p => p.UFirmaAdi == tip);
                dataGridView1.DataSource = tiparama.ToList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Text = satir.Cells["UFirmaAdi"].Value.ToString();
            textBox2.Tag = satir.Cells["uretici_id"].Value;
            textBox3.Text = satir.Cells["UFirmaAdres"].Value.ToString();
            maskedTextBox1.Text = satir.Cells["UFirmaTel"].Value.ToString();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;
            UreticiFirmalar sil = baglanti.UreticiFirmalarSet.SingleOrDefault(c => c.uretici_id == id);
            baglanti.UreticiFirmalarSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.UreticiFirmalarSet.ToList();
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UreticiFirmalar ekle = new UreticiFirmalar();
            ekle.UFirmaAdi = textBox2.Text;
            ekle.UFirmaAdres = textBox3.Text;
            ekle.UFirmaTel = maskedTextBox1.Text;
            ekle.Firmalar_firma_id = 1;
            baglanti.UreticiFirmalarSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.UreticiFirmalarSet.ToList();
            Temizle();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;

            UreticiFirmalar yenile = baglanti.UreticiFirmalarSet.SingleOrDefault(g => g.uretici_id == id);
            yenile.UFirmaAdi = textBox2.Text;
            yenile.UFirmaAdres = textBox3.Text;
            yenile.UFirmaTel = maskedTextBox1.Text;
            yenile.Firmalar_firma_id = 1;
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.UreticiFirmalarSet.ToList();
            Temizle();
        }
    }
}
