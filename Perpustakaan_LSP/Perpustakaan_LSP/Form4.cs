using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Perpustakaan_LSP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=dbd_LPSlibrary");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtmahasiswa = new DataTable();

        private void Form4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadData();
        }
        private void LoadData()
        {
            dtmahasiswa.Clear();
            sqlQuery = "SELECT * FROM mahasiswa";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtmahasiswa);
            dataGridView1.DataSource = dtmahasiswa;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Filter data hanya berdasarkan NIM_MAHASISWA
            DataView dataView = dtmahasiswa.DefaultView;
            dataView.RowFilter = $"NIM_MAHASISWA LIKE '{txtSearch.Text}%'";
            dataGridView1.DataSource = dataView.ToTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = "UPDATE mahasiswa SET " +
                           "NAMA_MAHASISWA = @Nama, " +
                           "JENIS_KELAMIN_MAHASISWA = @Gender, " +
                           "TELEPON_MAHASISWA = @No, " +
                           "ALAMAT_MAHASISWA = @Alamat, " +
                           "EMAIL_MAHASISWA = @Email " +
                           "WHERE NIM_MAHASISWA = @Nim";

                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Nim", txtNim.Text);
                sqlCommand.Parameters.AddWithValue("@Nama", txtNama.Text);
                sqlCommand.Parameters.AddWithValue("@Gender", txtGender.Text);
                sqlCommand.Parameters.AddWithValue("@No", txtNo.Text);
                sqlCommand.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diperbarui.");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = "DELETE FROM mahasiswa WHERE NIM_MAHASISWA = @Nim";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Nim", txtNim.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus.");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void ClearFields()
        {
            txtNim.Clear();
            txtNama.Clear();
            txtGender.Clear();
            txtNo.Clear();
            txtAlamat.Clear();
            txtEmail.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtNim.Text = row.Cells["NIM_MAHASISWA"].Value.ToString();
                txtNama.Text = row.Cells["NAMA_MAHASISWA"].Value.ToString();
                txtGender.Text = row.Cells["JENIS_KELAMIN_MAHASISWA"].Value.ToString();
                txtNo.Text = row.Cells["TELEPON_MAHASISWA"].Value.ToString();
                txtAlamat.Text = row.Cells["ALAMAT_MAHASISWA"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL_MAHASISWA"].Value.ToString();
            }
        }
    }
}
