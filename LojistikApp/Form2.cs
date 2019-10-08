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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Model1Container baglanti = new Model1Container();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["FirmaTipi"].Value.ToString();
            textBox1.Tag = satir.Cells["firma_id"].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Firmalar ekle = new Firmalar();
            ekle.FirmaTipi = textBox1.Text.ToString();
            baglanti.FirmalarSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.FirmalarSet.ToList();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.FirmalarSet.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)textBox1.Tag;
            Firmalar sil = baglanti.FirmalarSet.SingleOrDefault(f=>f.firma_id == id);
            baglanti.FirmalarSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.FirmalarSet.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = (int)textBox1.Tag;
            Firmalar guncel = baglanti.FirmalarSet.SingleOrDefault(f => f.firma_id == id);
            guncel.FirmaTipi = textBox1.Text.ToString();
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.FirmalarSet.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox2.Text);
            var arama = baglanti.FirmalarSet.Where(p => p.firma_id== id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }
    }
}
