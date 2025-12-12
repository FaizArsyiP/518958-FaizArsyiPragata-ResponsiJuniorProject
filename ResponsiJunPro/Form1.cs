using Npgsql;
using System.Data;

namespace ResponsiJunPro
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Username=postgres;Password=informatika;Database=responsi";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public Form1()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            LoadData();
            LoadProyek();
            LoadStatus();
        }
        private void LoadStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "Full time", "Freelance" });
            cmbStatus.SelectedIndex = 0;
        }
        private void LoadData()
        {
            conn.Open();
            DGV.DataSource = null;
            sql = "SELECT * FROM dev_load()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            DGV.DataSource = dt;
            conn.Close();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "SELECT * FROM dev_insert(@nama, @proyek, @status, @fitur, @bug)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@proyek", cmbProyek.Text);
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
            cmd.Parameters.AddWithValue("@fitur", int.Parse(txtFitur.Text));
            cmd.Parameters.AddWithValue("@bug", int.Parse(txtBug.Text));

            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data Berhasil Ditambahkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                LoadData();
                txtNama.Text = txtFitur.Text = txtBug.Text = null;
            }
        }


        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = DGV.Rows[e.RowIndex];
            txtNama.Text = r.Cells[1].Value.ToString();
            cmbStatus.Text = r.Cells[2].Value.ToString();
            cmbProyek.Text = r.Cells[3].Value.ToString();
            txtFitur.Text = r.Cells[4].Value.ToString();
            txtBug.Text = r.Cells[5].Value.ToString();
        }

        private void LoadProyek()
        {
            conn.Open();
            cmbProyek.Items.Clear();
            sql = "SELECT nama_proyek FROM proyek";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cmbProyek.Items.Add(rd[0].ToString());
            }
            conn.Close();
            if (cmbProyek.Items.Count > 0)
            {
                cmbProyek.SelectedIndex = 0;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih data yang akan diupdate terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn.Open();
            sql = "SELECT * FROM dev_update(@id, @nama, @status, @fitur, @bug)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(r.Cells[0].Value.ToString()));
            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
            cmd.Parameters.AddWithValue("@fitur", int.Parse(txtFitur.Text));
            cmd.Parameters.AddWithValue("@bug", int.Parse(txtBug.Text));

            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                LoadData();
                txtNama.Text = txtFitur.Text = txtBug.Text = null;

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {   
            conn.Open();
            sql = "SELECT * FROM dev_delete(@id)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(r.Cells["id"].Value.ToString()));

            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data Berhasil Dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                LoadData();
                txtNama.Text = txtFitur.Text = txtBug.Text = null;
            }

        }
    }
}
