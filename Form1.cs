using Npgsql;
using System.Data;

namespace Responsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=Responsi2";
        private DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDep.Items.Add("HR");
            cbDep.Items.Add("ENG");
            cbDep.Items.Add("DEV");
            cbDep.Items.Add("PM");
            cbDep.Items.Add("FIN");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = "SELECT * FROM st_load()";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        dt = new DataTable();
                        using (var rd = cmd.ExecuteReader())
                        {
                            dt.Load(rd);
                        }
                        dgvData.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = "SELECT * FROM st_insert(:_nama, :_nama_dep)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                        cmd.Parameters.AddWithValue("_nama_dep", cbDep.Text);
                    }
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Karyawan Berhasil Ditambahkan!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLoad.PerformClick();
                        tbNama.Clear();
                        cbDep.SelectedIndex = -1;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = "SELECT * FROM st_update(:id_karyawan, :_nama, :_nama_dep)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("_id_karyawan", label3.Text);
                        cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                        cmd.Parameters.AddWithValue("_nama_dep", cbDep.Text);

                        int result = (int)cmd.ExecuteScalar();
                        if (result == 200)
                        {
                            MessageBox.Show("Data Karyawan Berhasil Diperbarui!", "Update Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLoad.PerformClick();
                            tbNama.Clear();
                            cbDep.SelectedIndex = -1;
                        }
                        else if (result == 404)
                        {
                            MessageBox.Show("Karyawan tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                label3.Text = r.Cells["id_karyawan"].Value.ToString();
                tbNama.Text = r.Cells["nama"].Value.ToString();
                cbDep.Text = r.Cells["nama_dep"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = "SELECT * FROM st_delete(:_id_karyawan)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("_id_karyawan", label3.Text);

                        int result = (int)cmd.ExecuteScalar();
                        if (result == 200)
                        {
                            MessageBox.Show("Data Karyawan Berhasil Dihapus!", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLoad.PerformClick();
                            label3.Text = string.Empty;
                        }
                        else if (result == 404)
                        {
                            MessageBox.Show("Karyawan tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
