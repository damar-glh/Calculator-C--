namespace TugasTiga1
{
    partial class frmMahasiswa
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNim = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.lblIsiNim = new System.Windows.Forms.Label();
            this.lblIsiNama = new System.Windows.Forms.Label();
            this.lblIsiKelas = new System.Windows.Forms.Label();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 47);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(50, 16);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama :";
            this.lblNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(14, 22);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(49, 16);
            this.lblNim.TabIndex = 0;
            this.lblNim.Text = "NIM     :";
            this.lblNim.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(10, 75);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(50, 16);
            this.lblKelas.TabIndex = 0;
            this.lblKelas.Text = " Kelas :";
            this.lblKelas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIsiNim
            // 
            this.lblIsiNim.AutoSize = true;
            this.lblIsiNim.Location = new System.Drawing.Point(69, 22);
            this.lblIsiNim.Name = "lblIsiNim";
            this.lblIsiNim.Size = new System.Drawing.Size(69, 16);
            this.lblIsiNim.TabIndex = 1;
            this.lblIsiNim.Text = "22.11.5209";
            // 
            // lblIsiNama
            // 
            this.lblIsiNama.AutoSize = true;
            this.lblIsiNama.Location = new System.Drawing.Point(69, 47);
            this.lblIsiNama.Name = "lblIsiNama";
            this.lblIsiNama.Size = new System.Drawing.Size(82, 16);
            this.lblIsiNama.TabIndex = 1;
            this.lblIsiNama.Text = "Damar Galih";
            // 
            // lblIsiKelas
            // 
            this.lblIsiKelas.AutoSize = true;
            this.lblIsiKelas.Location = new System.Drawing.Point(69, 75);
            this.lblIsiKelas.Name = "lblIsiKelas";
            this.lblIsiKelas.Size = new System.Drawing.Size(52, 16);
            this.lblIsiKelas.TabIndex = 1;
            this.lblIsiKelas.Text = "S1-IF11";
            this.lblIsiKelas.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(17, 119);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(104, 23);
            this.btnTampil.TabIndex = 2;
            this.btnTampil.Text = "Tampilkan";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.Location = new System.Drawing.Point(127, 119);
            this.btnKosongkan.Name = "btnKosongkan";
            this.btnKosongkan.Size = new System.Drawing.Size(117, 23);
            this.btnKosongkan.TabIndex = 2;
            this.btnKosongkan.Text = "Kosongkan";
            this.btnKosongkan.UseVisualStyleBackColor = true;
            this.btnKosongkan.Click += new System.EventHandler(this.btnKosongkan_Click);
            // 
            // frmMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 281);
            this.Controls.Add(this.btnKosongkan);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.lblIsiKelas);
            this.Controls.Add(this.lblIsiNama);
            this.Controls.Add(this.lblIsiNim);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNim);
            this.Controls.Add(this.lblNama);
            this.Name = "frmMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tugas 3.1";
            this.Load += new System.EventHandler(this.frmMahasiswa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNim;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblIsiNim;
        private System.Windows.Forms.Label lblIsiNama;
        private System.Windows.Forms.Label lblIsiKelas;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnKosongkan;
    }
}

