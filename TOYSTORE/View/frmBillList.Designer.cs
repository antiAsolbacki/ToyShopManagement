namespace TOYSTORE.HOANGPHUC
{
    partial class frmBillList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillList));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvBillList = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            Customer = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            dgvdel = new DataGridViewImageColumn();
            dgvprint = new DataGridViewImageColumn();
            lblDatetime = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblBillList = new Label();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvBillList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBillList
            // 
            dgvBillList.AllowDrop = true;
            dgvBillList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBillList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBillList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvBillList.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBillList.ColumnHeadersHeight = 17;
            dgvBillList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBillList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Time, Column3, Column4, Customer, Type, Status, dgvdel, dgvprint });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBillList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBillList.GridColor = Color.FromArgb(231, 229, 255);
            dgvBillList.Location = new Point(0, 101);
            dgvBillList.Name = "dgvBillList";
            dgvBillList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBillList.RowHeadersVisible = false;
            dgvBillList.Size = new Size(1016, 369);
            dgvBillList.TabIndex = 6;
            dgvBillList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBillList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBillList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBillList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBillList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBillList.ThemeStyle.BackColor = SystemColors.Control;
            dgvBillList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvBillList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBillList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBillList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvBillList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBillList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBillList.ThemeStyle.HeaderStyle.Height = 17;
            dgvBillList.ThemeStyle.ReadOnly = false;
            dgvBillList.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBillList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBillList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvBillList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBillList.ThemeStyle.RowsStyle.Height = 25;
            dgvBillList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBillList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.Name = "Time";
            // 
            // Column3
            // 
            Column3.HeaderText = "Quanlity";
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Customer
            // 
            Customer.HeaderText = "Customer";
            Customer.Name = "Customer";
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // dgvdel
            // 
            dgvdel.HeaderText = "";
            dgvdel.Image = Properties.Resources.Screenshot_2024_09_17_023705_removebg_preview;
            dgvdel.Name = "dgvdel";
            // 
            // dgvprint
            // 
            dgvprint.HeaderText = "";
            dgvprint.Image = Properties.Resources.Screenshot_2024_09_11_011754_removebg_preview;
            dgvprint.Name = "dgvprint";
            // 
            // lblDatetime
            // 
            lblDatetime.AutoSize = true;
            lblDatetime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDatetime.Location = new Point(1150, 29);
            lblDatetime.Name = "lblDatetime";
            lblDatetime.Size = new Size(27, 21);
            lblDatetime.TabIndex = 11;
            lblDatetime.Text = "(?)";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Center;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.FillColor = Color.SteelBlue;
            guna2PictureBox1.Image = Properties.Resources.Screenshot_2024_09_17_230034_removebg_preview;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(3, 3);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(79, 67);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 15;
            guna2PictureBox1.TabStop = false;
            // 
            // lblBillList
            // 
            lblBillList.Anchor = AnchorStyles.None;
            lblBillList.AutoSize = true;
            lblBillList.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillList.ForeColor = Color.OldLace;
            lblBillList.Location = new Point(436, 20);
            lblBillList.Name = "lblBillList";
            lblBillList.Size = new Size(99, 22);
            lblBillList.TabIndex = 66;
            lblBillList.Text = "BILL LIST";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.CustomizableEdges = customizableEdges3;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageSize = new Size(30, 30);
            btnClose.Location = new Point(962, 0);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(54, 42);
            btnClose.TabIndex = 67;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lblBillList);
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Controls.Add(lblDatetime);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 70);
            panel1.TabIndex = 5;
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.BackColor = Color.Transparent;
            guna2CheckBox1.BackgroundImageLayout = ImageLayout.None;
            guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.CheckedState.BorderRadius = 0;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.CheckMarkColor = Color.RosyBrown;
            guna2CheckBox1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2CheckBox1.Location = new Point(21, 76);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(51, 19);
            guna2CheckBox1.TabIndex = 7;
            guna2CheckBox1.Text = "ALL";
            guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UncheckedState.BorderRadius = 0;
            guna2CheckBox1.UncheckedState.BorderThickness = 0;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UseVisualStyleBackColor = false;
            // 
            // guna2CheckBox2
            // 
            guna2CheckBox2.AutoSize = true;
            guna2CheckBox2.BackColor = Color.Transparent;
            guna2CheckBox2.BackgroundImageLayout = ImageLayout.None;
            guna2CheckBox2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox2.CheckedState.BorderRadius = 0;
            guna2CheckBox2.CheckedState.BorderThickness = 0;
            guna2CheckBox2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox2.CheckMarkColor = Color.RosyBrown;
            guna2CheckBox2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2CheckBox2.Location = new Point(108, 76);
            guna2CheckBox2.Name = "guna2CheckBox2";
            guna2CheckBox2.Size = new Size(77, 19);
            guna2CheckBox2.TabIndex = 8;
            guna2CheckBox2.Text = "ONLINE";
            guna2CheckBox2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox2.UncheckedState.BorderRadius = 0;
            guna2CheckBox2.UncheckedState.BorderThickness = 0;
            guna2CheckBox2.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox2.UseVisualStyleBackColor = false;
            // 
            // guna2CheckBox3
            // 
            guna2CheckBox3.AutoSize = true;
            guna2CheckBox3.BackColor = Color.Transparent;
            guna2CheckBox3.BackgroundImageLayout = ImageLayout.None;
            guna2CheckBox3.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox3.CheckedState.BorderRadius = 0;
            guna2CheckBox3.CheckedState.BorderThickness = 0;
            guna2CheckBox3.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox3.CheckMarkColor = Color.RosyBrown;
            guna2CheckBox3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2CheckBox3.Location = new Point(224, 76);
            guna2CheckBox3.Name = "guna2CheckBox3";
            guna2CheckBox3.Size = new Size(79, 19);
            guna2CheckBox3.TabIndex = 9;
            guna2CheckBox3.Text = "DIRECT ";
            guna2CheckBox3.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox3.UncheckedState.BorderRadius = 0;
            guna2CheckBox3.UncheckedState.BorderThickness = 0;
            guna2CheckBox3.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox3.UseVisualStyleBackColor = false;
            // 
            // frmBillList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 469);
            Controls.Add(guna2CheckBox3);
            Controls.Add(guna2CheckBox2);
            Controls.Add(guna2CheckBox1);
            Controls.Add(dgvBillList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBillList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillList";
            ((System.ComponentModel.ISupportInitialize)dgvBillList).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvBillList;
        private Label lblDatetime;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label lblBillList;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column4;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewImageColumn dgvdel;
        private DataGridViewImageColumn dgvprint;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox3;
    }
}