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

namespace belajarCRUD
{
    public partial class frmBelajarCRUD : Form
    {
        public frmBelajarCRUD()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection
            ("datasource=localhost;port=3306;" + "Initial Catalog='db_crud';username=root;password=");

        public void showData()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_crud", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvCRUD.RowTemplate.Height = 150;
            dgvCRUD.AllowUserToAddRows = false;
            dgvCRUD.DataSource = table;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)dgvCRUD.Columns[3];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvCRUD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image (*.JPG;*.PNG;*.GIF) | *.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pbGambar.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dgvCRUD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Byte[] img = (Byte[])dgvCRUD.CurrentRow.Cells[3].Value;

            MemoryStream ms = new MemoryStream(img);

            pbGambar.Image = Image.FromStream(ms);

            txtId.Text = dgvCRUD.CurrentRow.Cells[0].Value.ToString();
            txtNamabarang.Text = dgvCRUD.CurrentRow.Cells[1].Value.ToString();
            txtDeskripsi.Text = dgvCRUD.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            pbGambar.Image.Save(ms, pbGambar.Image.RawFormat);

            byte[] img = ms.ToArray();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_crud " + "(nama, deskripsi, gambar) VALUES (@nama, @deskripsi, @image)", conn);

            cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = txtNamabarang.Text;
            cmd.Parameters.Add("@deskripsi", MySqlDbType.VarChar).Value = txtDeskripsi.Text;
            cmd.Parameters.Add("@image", MySqlDbType.Blob).Value = img;

            ExecMyQuery(cmd, "Data Inserted");
        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            conn.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg);
            }
            else
            {
                MessageBox.Show("Query Not Executed");
            }
            conn.Close();
        }

        private void FrmBelajarCRUD_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            pbGambar.Image.Save(ms, pbGambar.Image.RawFormat);

            byte[] img = ms.ToArray();

            MySqlCommand cmd = new MySqlCommand("UPDATE tbl_crud SET nama=@nama, " + "deskripsi=@deskripsi, gambar=@image WHERE id=@id", conn);

            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtId.Text;
            cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = txtNamabarang.Text;
            cmd.Parameters.Add("@deskripsi", MySqlDbType.VarChar).Value = txtDeskripsi.Text;
            cmd.Parameters.Add("@image", MySqlDbType.Blob).Value = img;

            ExecMyQuery(cmd, "Data Updated");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_crud WHERE id=@id", conn);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtId.Text;

            ExecMyQuery(cmd, "Data Deleted");
        }
    }
}
