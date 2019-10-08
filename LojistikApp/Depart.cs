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
    public partial class Depart : Form
    {
        public Depart()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        private void Depart_Load(object sender, EventArgs e)
        {
           comboBox1.DataSource = baglanti.FirmalarSet.ToList();
            comboBox1.DisplayMember = "firma_id";
            comboBox1.ValueMember = "firma_id";
           
        }
        public void Temizle()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox2.Text);
            var arama = baglanti.DepartmanSet.Where(p => p.departman_id == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["DepartmanAdi"].Value.ToString();
            textBox1.Tag = satir.Cells["departman_id"].Value;
            comboBox1.Text = satir.Cells["Firmalar_firma_id"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.DepartmanSet.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Departman ekle = new Departman();
            ekle.DepartmanAdi = textBox1.Text.ToString();
            ekle.Firmalar_firma_id= Convert.ToInt32(comboBox1.SelectedValue);
            baglanti.DepartmanSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.DepartmanSet.ToList();
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)textBox1.Tag;
            Departman sil = baglanti.DepartmanSet.SingleOrDefault(f => f.departman_id == id);
            baglanti.DepartmanSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.DepartmanSet.ToList();
            Temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = (int)textBox1.Tag;
            Departman guncel = baglanti.DepartmanSet.SingleOrDefault(f => f.departman_id == id);
            guncel.DepartmanAdi = textBox1.Text.ToString();
            guncel.Firmalar_firma_id= Convert.ToInt32(comboBox1.SelectedValue);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.DepartmanSet.ToList();
            Temizle();
        }
    }
}
