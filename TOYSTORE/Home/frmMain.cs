using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOYSTORE.HOANGPHUC;

namespace TOYSTORE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public string name = "{?}";
        private void MovePanel(Control Btn)
        {
            pnlMove.Top = Btn.Top;
            pnlMove.Height = Btn.Height;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUsername.Text = name;
            timerdatentime.Stop();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            MovePanel(btnStaff);
            userControlDashBoard1.Visible = false;
        }

        private void lblDatetime_Click(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("dd-MM-yy  hh:mm:ss tt");
        }
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            MovePanel(btnDashBoard);
            userControlDashBoard1.Visible = true;
        }
        private void btnBrand_Click(object sender, EventArgs e)
        {
            MovePanel(btnProduct);
            userControlDashBoard1.Visible = false;
            frmProduct prodForm = new frmProduct();
            prodForm.ShowDialog();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            MovePanel(btnPOS);
            userControlDashBoard1.Visible = false;
            frmPOS posForm = new frmPOS();
            posForm.ShowDialog(); // or posForm.Show();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            MovePanel(btnLogout);
            System.Diagnostics.Debugger.Break();
            Environment.Exit(0);
            Close();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            MovePanel(btnCate);
            userControlDashBoard1.Visible = false;
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            MovePanel(btnReceipt);
            userControlDashBoard1.Visible = false;
        }
    }
}
