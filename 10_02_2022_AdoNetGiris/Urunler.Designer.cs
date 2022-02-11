
namespace _10_02_2022_AdoNetGiris
{
    partial class Urunler
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnurunekle = new System.Windows.Forms.Button();
            this.btnkategori = new System.Windows.Forms.Button();
            this.txt_urunadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudfiyat = new System.Windows.Forms.NumericUpDown();
            this.nudstok = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cntextsil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudstok)).BeginInit();
            this.cntextsil.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cntextsil;
            this.dataGridView1.Location = new System.Drawing.Point(52, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnurunekle
            // 
            this.btnurunekle.Location = new System.Drawing.Point(491, 68);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(90, 27);
            this.btnurunekle.TabIndex = 1;
            this.btnurunekle.Text = "Ürün Ekle";
            this.btnurunekle.UseVisualStyleBackColor = true;
            this.btnurunekle.Click += new System.EventHandler(this.btnurunekle_Click);
            // 
            // btnkategori
            // 
            this.btnkategori.Location = new System.Drawing.Point(587, 68);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(107, 27);
            this.btnkategori.TabIndex = 2;
            this.btnkategori.Text = "Katagoriler";
            this.btnkategori.UseVisualStyleBackColor = true;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // txt_urunadi
            // 
            this.txt_urunadi.Location = new System.Drawing.Point(43, 72);
            this.txt_urunadi.Multiline = true;
            this.txt_urunadi.Name = "txt_urunadi";
            this.txt_urunadi.Size = new System.Drawing.Size(111, 23);
            this.txt_urunadi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı";
            // 
            // nudfiyat
            // 
            this.nudfiyat.Location = new System.Drawing.Point(183, 73);
            this.nudfiyat.Name = "nudfiyat";
            this.nudfiyat.Size = new System.Drawing.Size(120, 22);
            this.nudfiyat.TabIndex = 5;
            // 
            // nudstok
            // 
            this.nudstok.Location = new System.Drawing.Point(349, 73);
            this.nudstok.Name = "nudstok";
            this.nudstok.Size = new System.Drawing.Size(120, 22);
            this.nudstok.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stok";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "SP ile Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cntextsil
            // 
            this.cntextsil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntextsil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cntextsil.Name = "cntextsil";
            this.cntextsil.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudstok);
            this.Controls.Add(this.nudfiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_urunadi);
            this.Controls.Add(this.btnkategori);
            this.Controls.Add(this.btnurunekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudstok)).EndInit();
            this.cntextsil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.TextBox txt_urunadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudfiyat;
        private System.Windows.Forms.NumericUpDown nudstok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cntextsil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}