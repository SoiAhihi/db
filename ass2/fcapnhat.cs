using ass2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass2
{
    public partial class fcapnhat : Form
    {
        DataGridViewRow data;
        public fcapnhat(DataGridViewRow Data)
        {
            InitializeComponent();
            this.data = Data;
            tbID.Text = data.Cells["id"].Value.ToString();
            tbCre.Text = data.Cells["cre"].Value.ToString();
            tbCus.Text = data.Cells["cus"].Value.ToString();
            tbEmp.Text = data.Cells["emp"].Value.ToString();
            tbTotal.Text = data.Cells["total"].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == null || Convert.ToInt32(tbTotal.Text)<=0)
            {
                MessageBox.Show("nhap sai tong tien", "thong bao", MessageBoxButtons.OK);
                return;
            }
            BillDAO.Instance.UpdateBill(tbID.Text, tbTotal.Text);
            this.Close();
            
        }
    }
}
