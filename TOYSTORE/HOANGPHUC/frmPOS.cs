using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOYSTORE.HOANGPHUC
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void POS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            frmOnline onlForm = new frmOnline();
            onlForm.ShowDialog(); // or posForm.Show();
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            frmBillList onlForm = new frmBillList();
            onlForm.ShowDialog();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {

        }
        private void CategoryAdd()
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmPOSview pOSview = new frmPOSview();
            pOSview.ShowDialog();
        }
    }
}
