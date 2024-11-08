using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_232410101085_utspbo.View
{
    public partial class DataBuku : Form
    {
        public DataBuku()
        {
            InitializeComponent();
            this.Load += DataBuku_Load;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBuku addBuku = new AddBuku();
            if (addBuku.ShowDialog() == DialogResult.OK)
            {
                LoadDataBuku();
            }
            this.Show();
        }
        private void DataBuku_Load(object sender, EventArgs e)
        {
            LoadDataBuku();
        }
        private void LoadDataBuku()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;
                DataTable bukuData = BukuContext.All();
                if (bukuData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data buku");
                    return;
                }
                dataGridView1.Columns.Clear();
                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);
                dataGridView1.DataSource = bukuData;

                if (dataGridView1.Columns["id_buku"] != null) dataGridView1.Columns["id_buku"].Visible = false;
                if (dataGridView1.Columns["judul_buku"] != null)
                    dataGridView1.Columns["judul_buku"].HeaderText = "Judul Buku";
                if (dataGridView1.Columns["penerbit"] != null)
                    dataGridView1.Columns["penerbit"].HeaderText = "Penerbit";
                if (dataGridView1.Columns["tahun_terbit"] != null)
                    dataGridView1.Columns["tahun_terbit"].HeaderText = "Tahun Terbit";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }

                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(updateButtonColumn);

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}
