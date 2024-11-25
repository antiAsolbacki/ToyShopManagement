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
   
    public partial class ucProducts : UserControl
    { 
        public event EventHandler onSelect = null;
        public ucProducts()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public int PPrice { get; set; }
        public int PCategory { get; set; }

        public string PName
        {
            get { return lblName.Text; }



            set { lblName.Text = value; }
        }
        public Image Pimage

        {
            get { return txtImage.Image; }



            set { txtImage.Image = value; }
        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
