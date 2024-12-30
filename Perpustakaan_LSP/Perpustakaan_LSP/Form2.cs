using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Perpustakaan_LSP
{
    public partial class Form2 : Form
    {
        // Connection String untuk database MySQL
        private string connectionString = "server=127.0.0.1;uid=root;pwd=;database=dbd_LPSlibrary";

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ambil input dari TextBox
            string KBuku = txtBoxKBuku.Text.Trim();
            string KKategori = txtBoxKKategori.Text.Trim();
            string KPenerbit = txtBoxKPenerbit.Text.Trim();
            string KPenulis = txtBoxPenulis.Text.Trim();
            string JBuku = txtBoxKJudul.Text.Trim();

            // Validasi input kosong
            if (string.IsNullOrWhiteSpace(KBuku) || string.IsNullOrWhiteSpace(JBuku))
            {
                MessageBox.Show("Kode Buku dan Judul Buku harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query untuk menambahkan data
            string query = "INSERT INTO BUKU (KODE_BUKU, JUDUL_BUKU, KATEGORI, KODE_PENERBIT, PENULIS, DELETE_BUKU) " +
                           "VALUES (@KodeBuku, @JudulBuku, @Kategori, @KodePenerbit, @Penulis, 0)";

            try
            {
                // Koneksi ke database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Eksekusi query
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Tambahkan parameter ke query
                        command.Parameters.AddWithValue("@KodeBuku", KBuku);
                        command.Parameters.AddWithValue("@JudulBuku", JBuku);
                        command.Parameters.AddWithValue("@Kategori", KKategori);
                        command.Parameters.AddWithValue("@KodePenerbit", KPenerbit);
                        command.Parameters.AddWithValue("@Penulis", KPenulis);

                        // Eksekusi query
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Bersihkan form
            ClearForm();
        }

        // Method untuk membersihkan input form
        private void ClearForm()
        {
            txtBoxKBuku.Clear();
            txtBoxKKategori.Clear();
            txtBoxKPenerbit.Clear();
            txtBoxPenulis.Clear();
            txtBoxKJudul.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
