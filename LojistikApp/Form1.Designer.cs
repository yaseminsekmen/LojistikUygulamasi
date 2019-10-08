namespace LojistikApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alıcıFirmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taşıyıcıFirmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üreticiFirmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sevkiyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmalarToolStripMenuItem,
            this.departmanlarToolStripMenuItem,
            this.personellerToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.sevkiyatToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firmalarToolStripMenuItem
            // 
            this.firmalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmalarToolStripMenuItem1,
            this.alıcıFirmalarToolStripMenuItem,
            this.taşıyıcıFirmalarToolStripMenuItem,
            this.üreticiFirmalarToolStripMenuItem});
            this.firmalarToolStripMenuItem.Name = "firmalarToolStripMenuItem";
            this.firmalarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.firmalarToolStripMenuItem.Text = "Firma";
            // 
            // firmalarToolStripMenuItem1
            // 
            this.firmalarToolStripMenuItem1.Name = "firmalarToolStripMenuItem1";
            this.firmalarToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.firmalarToolStripMenuItem1.Text = "Firmalar";
            this.firmalarToolStripMenuItem1.Click += new System.EventHandler(this.firmalarToolStripMenuItem1_Click);
            // 
            // alıcıFirmalarToolStripMenuItem
            // 
            this.alıcıFirmalarToolStripMenuItem.Name = "alıcıFirmalarToolStripMenuItem";
            this.alıcıFirmalarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.alıcıFirmalarToolStripMenuItem.Text = "Alıcı Firmalar";
            this.alıcıFirmalarToolStripMenuItem.Click += new System.EventHandler(this.alıcıFirmalarToolStripMenuItem_Click);
            // 
            // taşıyıcıFirmalarToolStripMenuItem
            // 
            this.taşıyıcıFirmalarToolStripMenuItem.Name = "taşıyıcıFirmalarToolStripMenuItem";
            this.taşıyıcıFirmalarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.taşıyıcıFirmalarToolStripMenuItem.Text = "Taşıyıcı Firmalar";
            this.taşıyıcıFirmalarToolStripMenuItem.Click += new System.EventHandler(this.taşıyıcıFirmalarToolStripMenuItem_Click);
            // 
            // üreticiFirmalarToolStripMenuItem
            // 
            this.üreticiFirmalarToolStripMenuItem.Name = "üreticiFirmalarToolStripMenuItem";
            this.üreticiFirmalarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.üreticiFirmalarToolStripMenuItem.Text = "Üretici Firmalar";
            this.üreticiFirmalarToolStripMenuItem.Click += new System.EventHandler(this.üreticiFirmalarToolStripMenuItem_Click);
            // 
            // departmanlarToolStripMenuItem
            // 
            this.departmanlarToolStripMenuItem.Name = "departmanlarToolStripMenuItem";
            this.departmanlarToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.departmanlarToolStripMenuItem.Text = "Departmanlar";
            this.departmanlarToolStripMenuItem.Click += new System.EventHandler(this.departmanlarToolStripMenuItem_Click);
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.personellerToolStripMenuItem.Text = "Personeller";
            this.personellerToolStripMenuItem.Click += new System.EventHandler(this.personellerToolStripMenuItem_Click);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // sevkiyatToolStripMenuItem
            // 
            this.sevkiyatToolStripMenuItem.Name = "sevkiyatToolStripMenuItem";
            this.sevkiyatToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.sevkiyatToolStripMenuItem.Text = "Sevkiyat";
            this.sevkiyatToolStripMenuItem.Click += new System.EventHandler(this.sevkiyatToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 452);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alıcıFirmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taşıyıcıFirmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üreticiFirmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sevkiyatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

