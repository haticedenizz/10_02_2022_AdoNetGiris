
namespace _10_02_2022_AdoNetGiris
{
    partial class Kategori
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
            this.dgwkategori = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kategoriadi = new System.Windows.Forms.TextBox();
            this.txt_tanimi = new System.Windows.Forms.TextBox();
            this.btn_KategoriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkategori)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwkategori
            // 
            this.dgwkategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwkategori.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwkategori.Location = new System.Drawing.Point(58, 151);
            this.dgwkategori.Name = "dgwkategori";
            this.dgwkategori.RowHeadersWidth = 51;
            this.dgwkategori.RowTemplate.Height = 24;
            this.dgwkategori.Size = new System.Drawing.Size(418, 350);
            this.dgwkategori.TabIndex = 0;
            this.dgwkategori.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwkategori_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanımı";
            // 
            // txt_kategoriadi
            // 
            this.txt_kategoriadi.Location = new System.Drawing.Point(58, 71);
            this.txt_kategoriadi.Multiline = true;
            this.txt_kategoriadi.Name = "txt_kategoriadi";
            this.txt_kategoriadi.Size = new System.Drawing.Size(100, 31);
            this.txt_kategoriadi.TabIndex = 3;
            // 
            // txt_tanimi
            // 
            this.txt_tanimi.Location = new System.Drawing.Point(228, 71);
            this.txt_tanimi.Multiline = true;
            this.txt_tanimi.Name = "txt_tanimi";
            this.txt_tanimi.Size = new System.Drawing.Size(100, 31);
            this.txt_tanimi.TabIndex = 4;
            // 
            // btn_KategoriEkle
            // 
            this.btn_KategoriEkle.Location = new System.Drawing.Point(392, 70);
            this.btn_KategoriEkle.Name = "btn_KategoriEkle";
            this.btn_KategoriEkle.Size = new System.Drawing.Size(140, 32);
            this.btn_KategoriEkle.TabIndex = 5;
            this.btn_KategoriEkle.Text = "Kategori Ekle";
            this.btn_KategoriEkle.UseVisualStyleBackColor = true;
            this.btn_KategoriEkle.Click += new System.EventHandler(this.btn_KategoriEkle_Click);
            // 
            // Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 539);
            this.Controls.Add(this.btn_KategoriEkle);
            this.Controls.Add(this.txt_tanimi);
            this.Controls.Add(this.txt_kategoriadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwkategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Kategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.Kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwkategori)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwkategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kategoriadi;
        private System.Windows.Forms.TextBox txt_tanimi;
        private System.Windows.Forms.Button btn_KategoriEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}