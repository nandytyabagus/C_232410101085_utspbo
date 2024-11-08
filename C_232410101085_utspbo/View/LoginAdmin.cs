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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataBuku dataBuku = new DataBuku();
            if (dataBuku.ShowDialog() == DialogResult.OK)
            {
                LoadDataBuku();
            }
            this.Show();
        }
    }
}
