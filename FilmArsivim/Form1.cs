using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmArsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source=IBRAHIMYEGEN;Initial Catalog=FilmArsiv;Integrated Security=True
        SqlConnection conn = new SqlConnection(@"Data Source=IBRAHIMYEGEN;Initial Catalog=FilmArsiv;Integrated Security=True");

        void Filmler()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from tblFilmler", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Filmler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into tblFilmler (AD ,KATEGORİ ,LINK) VALUES(@p1,@p2,@p3) ", conn);
            komut.Parameters.AddWithValue("@p1", txtFilmAD.Text);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text);
            komut.Parameters.AddWithValue("@p3", txtLink.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Film Eklendi ");
            Filmler();
        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IBRAHIM YEGEN TARAFINDAN HAZIRLANDI ");
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            webBrowser1.Navigate(link);
          //  webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void btnTamekran_Click(object sender, EventArgs e)
        {
            grpBoxEkran.Dock = DockStyle.Fill;

        }
    }
}
