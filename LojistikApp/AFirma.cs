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
    public partial class AFirma : Form
    {
        public AFirma()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Text = satir.Cells["AFirmaAdi"].Value.ToString();
            textBox2.Tag = satir.Cells["alici_id"].Value;
            textBox3.Text = satir.Cells["AFirmaAdres"].Value.ToString();
            maskedTextBox1.Text = satir.Cells["AfirmaTel"].Value.ToString();
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.AliciFirmalarSet.ToList();
        }

        private void AFirma_Load(object sender, EventArgs e)
        {
           
            groupBox1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AliciFirmalar ekle = new AliciFirmalar();
            ekle.AFirmaAdi = textBox2.Text;
            ekle.AFirmaAdres = textBox3.Text;
            ekle.AFirmaTel = maskedTextBox1.Text;
            ekle.Firmalar_firma_id = 2;
            baglanti.AliciFirmalarSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.AliciFirmalarSet.ToList();
            Temizle();

        }

        public void Temizle()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox1.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;
            AliciFirmalar sil = baglanti.AliciFirmalarSet.SingleOrDefault(c => c.alici_id == id);
            baglanti.AliciFirmalarSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.AliciFirmalarSet.ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = (int)textBox2.Tag;
          
           AliciFirmalar yenile = baglanti.AliciFirmalarSet.SingleOrDefault(g => g.alici_id == id);
            yenile.AFirmaAdi = textBox2.Text;
            yenile.AFirmaAdres = textBox3.Text;
            yenile.AFirmaTel = maskedTextBox1.Text;
            yenile.Firmalar_firma_id =2;
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.AliciFirmalarSet.ToList();
            Temizle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            label1.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
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
                var arama = baglanti.AliciFirmalarSet.Where(p => p.alici_id == id);
                dataGridView1.DataSource = arama.ToList();
            }
            else
            {
                string tip = textBox1.Text;
                var tiparama = baglanti.AliciFirmalarSet.Where(p => p.AFirmaAdi == tip);
                dataGridView1.DataSource = tiparama.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
