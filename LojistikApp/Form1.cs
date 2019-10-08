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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firmalarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
            git.Show();
            this.Hide();
        }

        private void alıcıFirmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AFirma git = new AFirma();
            git.Show();
            this.Hide();
        }

        private void taşıyıcıFirmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TFirma git = new TFirma();
            git.Show();
            this.Hide();
        }

        private void üreticiFirmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UFirma git = new UFirma();
            git.Show();
            this.Hide();
        }

        private void departmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Depart git = new Depart();
            git.Show();
            this.Hide();
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pers git = new Pers();
            git.Show();
            this.Hide();

        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ur git = new Ur();
            git.Show();
            this.Hide();

        }

        private void sevkiyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sevk git = new Sevk();
            git.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
