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
    public partial class AddPeminjamForm : Form
    {
        // Connection String untuk database MySQL
        private string connectionString = "server=127.0.0.1;uid=root;pwd=;database=dbd_LPSlibrary";

        public AddPeminjamForm()
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
            string Nim = txtNama.Text.Trim();
            string Nama = txtNim.Text.Trim();
            string Kelamin = txtGender.Text.Trim();
            string Nomor = txtNo.Text.Trim();
            string Alamat = txtAlamat.Text.Trim();
            string Email = txtEmail.Text.Trim();

            // Validasi input
            if (string.IsNullOrWhiteSpace(Nim) || string.IsNullOrWhiteSpace(Nama) || string.IsNullOrWhiteSpace(Kelamin) ||
                string.IsNullOrWhiteSpace(Nomor) || string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Semua field wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query untuk menambahkan data ke tabel MAHASISWA
            string query = "INSERT INTO MAHASISWA (NIM_MAHASISWA, NAMA_MAHASISWA, JENIS_KELAMIN_MAHASISWA, TELEPON_MAHASISWA, ALAMAT_MAHASISWA, EMAIL_MAHASISWA, DELETE_MAHASISWA) " +
                           "VALUES (@NIM, @Nama, @Gender, @Telepon, @Alamat, @Email, '0')";

            try
            {
                // Koneksi ke database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Eksekusi query
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Menambahkan parameter ke query
                        command.Parameters.AddWithValue("@NIM", Nim);
                        command.Parameters.AddWithValue("@Nama", Nama);
                        command.Parameters.AddWithValue("@Gender", Kelamin);
                        command.Parameters.AddWithValue("@Telepon", Nomor);
                        command.Parameters.AddWithValue("@Alamat", Alamat);
                        command.Parameters.AddWithValue("@Email", Email);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Bersihkan form setelah data tersimpan
            ClearForm();
        }

        // Method untuk membersihkan input form
        private void ClearForm()
        {
            txtNama.Clear();
            txtNim.Clear();
            txtGender.Clear();
            txtNo.Clear();
            txtAlamat.Clear();
            txtEmail.Clear();
        }
    }
}
