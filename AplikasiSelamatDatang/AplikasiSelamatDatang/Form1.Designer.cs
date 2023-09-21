namespace AplikasiSelamatDatang
{
    partial class frmSelamatDatang
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
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.btnKeterangan1 = new System.Windows.Forms.Button();
            this.btnKeterangan2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblKeterangan.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan.Location = new System.Drawing.Point(258, 37);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(349, 25);
            this.lblKeterangan.TabIndex = 0;
            this.lblKeterangan.Text = "Selamat Datang di pemrogrman C#";
            // 
            // btnKeterangan1
            // 
            this.btnKeterangan1.Location = new System.Drawing.Point(319, 96);
            this.btnKeterangan1.Name = "btnKeterangan1";
            this.btnKeterangan1.Size = new System.Drawing.Size(109, 23);
            this.btnKeterangan1.TabIndex = 1;
            this.btnKeterangan1.Text = "Keterangan 1";
            this.btnKeterangan1.UseVisualStyleBackColor = true;
            this.btnKeterangan1.Click += new System.EventHandler(this.btnKeterangan1_Click);
            // 
            // btnKeterangan2
            // 
            this.btnKeterangan2.Location = new System.Drawing.Point(450, 96);
            this.btnKeterangan2.Name = "btnKeterangan2";
            this.btnKeterangan2.Size = new System.Drawing.Size(125, 23);
            this.btnKeterangan2.TabIndex = 1;
            this.btnKeterangan2.Text = "Keterangan 2";
            this.btnKeterangan2.UseVisualStyleBackColor = true;
            this.btnKeterangan2.Click += new System.EventHandler(this.btnKeterangan2_Click);
            // 
            // frmSelamatDatang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 154);
            this.Controls.Add(this.btnKeterangan2);
            this.Controls.Add(this.btnKeterangan1);
            this.Controls.Add(this.lblKeterangan);
            this.Name = "frmSelamatDatang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Selamat Datang";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Button btnKeterangan1;
        private System.Windows.Forms.Button btnKeterangan2;
    }
}

