namespace TOYSTORE.HOANGPHUC
{
    partial class ucProducts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProducts));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panel1 = new Panel();
            lblName = new Label();
            txtImage = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2ShadowPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(panel1);
            guna2ShadowPanel1.Controls.Add(txtImage);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(136, 144);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 39);
            panel1.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(28, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Gấu Hồng 35cm";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtImage
            // 
            txtImage.CustomizableEdges = customizableEdges1;
            txtImage.Image = (Image)resources.GetObject("txtImage.Image");
            txtImage.ImageRotate = 0F;
            txtImage.Location = new Point(24, 3);
            txtImage.Name = "txtImage";
            txtImage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtImage.Size = new Size(87, 104);
            txtImage.SizeMode = PictureBoxSizeMode.Zoom;
            txtImage.TabIndex = 0;
            txtImage.TabStop = false;
            txtImage.Click += txtImage_Click;
            // 
            // ucProducts
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(guna2ShadowPanel1);
            Name = "ucProducts";
            Size = new Size(137, 147);
            guna2ShadowPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Panel panel1;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2PictureBox txtImage;
    }
}
