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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=dbd_LPSlibrary");
        MySqlCommand sqlCommand = new MySqlCommand();
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtbuku = new DataTable();

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tambahkanBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            sqlQuery = "select JUDUL_BUKU from BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtbuku);
            dataGridView1.DataSource = dtbuku;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = dtbuku.DefaultView;
            dataView.RowFilter = string.Format("JUDUL_BUKU like '" + textBox1.Text + "%'");
            dataGridView1.DataSource = dataView.ToTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void tambahkanPeminjamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void infoPeminjamToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void masukkanPeminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tambahkanBukuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Untuk show form 1 tambahkan buku ngarah ke form 2 add buku
            Form2 addbooks = new Form2();
            addbooks.Show();
        }

        private void tambahkanMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Untuk show form 1 tambahkan buku ngarah ke add mahasiswa
            AddPeminjamForm tmbh = new AddPeminjamForm();
            tmbh.Show();
        }

        private void detailMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 view = new Form4();
            view.Show();
        }

        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 borrow = new Form5();
            borrow.Show();
        }
    }
}
