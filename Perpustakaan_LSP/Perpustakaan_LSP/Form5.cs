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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=dbd_LPSlibrary");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtPeminjaman = new DataTable();

        private void Form5_Load(object sender, EventArgs e)
        {
            // Maksimalkan form
            this.WindowState = FormWindowState.Maximized;

            // Load data ke DataGridView
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dtPeminjaman.Clear();
                sqlQuery = "SELECT * FROM peminjaman";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPeminjaman);

                dataGridView1.DataSource = dtPeminjaman;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Input data ke database
                sqlQuery = $"INSERT INTO peminjaman (nama_mahasiswa, judul_buku, tanggal_pinjam, tanggal_pengembalian) " +
                           $"VALUES ('{txtBoxNama.Text}', '{txtBoxJudul.Text}', '{dateTimePickerPinjam.Value:yyyy-MM-dd}', '{dateTimePickerPengembalian.Value:yyyy-MM-dd}')";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);

                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

                // Bersihkan form
                txtBoxIdPinjam.Clear();
                txtBoxNama.Clear();
                txtBoxJudul.Clear();
                dateTimePickerPinjam.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                {
                    sqlConnect.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerPinjam_ValueChanged(object sender, EventArgs e)
        {
            // Tanggal pengembalian otomatis +7 hari
            dateTimePickerPengembalian.Value = dateTimePickerPinjam.Value.AddDays(7);
        }
    }
}
