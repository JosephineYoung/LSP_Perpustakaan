namespace Perpustakaan_LSP
{
    partial class Form5
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
            this.dateTimePickerPengembalian = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPinjam = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxJudul = new System.Windows.Forms.TextBox();
            this.txtBoxNama = new System.Windows.Forms.TextBox();
            this.txtBoxIdPinjam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerPengembalian
            // 
            this.dateTimePickerPengembalian.Location = new System.Drawing.Point(225, 306);
            this.dateTimePickerPengembalian.Name = "dateTimePickerPengembalian";
            this.dateTimePickerPengembalian.Size = new System.Drawing.Size(162, 27);
            this.dateTimePickerPengembalian.TabIndex = 29;
            // 
            // dateTimePickerPinjam
            // 
            this.dateTimePickerPinjam.Location = new System.Drawing.Point(225, 273);
            this.dateTimePickerPinjam.Name = "dateTimePickerPinjam";
            this.dateTimePickerPinjam.Size = new System.Drawing.Size(162, 27);
            this.dateTimePickerPinjam.TabIndex = 28;
            this.dateTimePickerPinjam.ValueChanged += new System.EventHandler(this.dateTimePickerPinjam_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 27;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 26;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxJudul
            // 
            this.txtBoxJudul.Location = new System.Drawing.Point(225, 233);
            this.txtBoxJudul.Name = "txtBoxJudul";
            this.txtBoxJudul.Size = new System.Drawing.Size(243, 27);
            this.txtBoxJudul.TabIndex = 25;
            // 
            // txtBoxNama
            // 
            this.txtBoxNama.Location = new System.Drawing.Point(225, 194);
            this.txtBoxNama.Name = "txtBoxNama";
            this.txtBoxNama.Size = new System.Drawing.Size(243, 27);
            this.txtBoxNama.TabIndex = 24;
            // 
            // txtBoxIdPinjam
            // 
            this.txtBoxIdPinjam.Location = new System.Drawing.Point(225, 157);
            this.txtBoxIdPinjam.Name = "txtBoxIdPinjam";
            this.txtBoxIdPinjam.Size = new System.Drawing.Size(243, 27);
            this.txtBoxIdPinjam.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tanggal Pengembalian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tanggal Pinjam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Judul Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nama Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID Pinjam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data Peminjaman";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(487, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(527, 371);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1064, 547);
            this.Controls.Add(this.dateTimePickerPengembalian);
            this.Controls.Add(this.dateTimePickerPinjam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxJudul);
            this.Controls.Add(this.txtBoxNama);
            this.Controls.Add(this.txtBoxIdPinjam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Peminjaman";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerPengembalian;
        private System.Windows.Forms.DateTimePicker dateTimePickerPinjam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxJudul;
        private System.Windows.Forms.TextBox txtBoxNama;
        private System.Windows.Forms.TextBox txtBoxIdPinjam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}