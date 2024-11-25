namespace TOYSTORE
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnReceipt = new Button();
            pnlMove = new Panel();
            btnLogout = new Button();
            btnStaff = new Button();
            btnPOS = new Button();
            btnCate = new Button();
            btnProduct = new Button();
            btnDashBoard = new Button();
            txtManagementSystem = new Label();
            txtToyStore = new Label();
            picShopicon = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblDatetime = new Label();
            lblUsername = new Label();
            label3 = new Label();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            timerdatentime = new System.Windows.Forms.Timer(components);
            userControlDashBoard1 = new HOANGPHUC.UserControlDashBoard();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShopicon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.GradientActiveCaption;
            guna2Panel1.Controls.Add(btnReceipt);
            guna2Panel1.Controls.Add(pnlMove);
            guna2Panel1.Controls.Add(btnLogout);
            guna2Panel1.Controls.Add(btnStaff);
            guna2Panel1.Controls.Add(btnPOS);
            guna2Panel1.Controls.Add(btnCate);
            guna2Panel1.Controls.Add(btnProduct);
            guna2Panel1.Controls.Add(btnDashBoard);
            guna2Panel1.Controls.Add(txtManagementSystem);
            guna2Panel1.Controls.Add(txtToyStore);
            guna2Panel1.Controls.Add(picShopicon);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Left;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(213, 664);
            guna2Panel1.TabIndex = 0;
            // 
            // btnReceipt
            // 
            btnReceipt.FlatAppearance.BorderSize = 0;
            btnReceipt.FlatStyle = FlatStyle.Flat;
            btnReceipt.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReceipt.Image = (Image)resources.GetObject("btnReceipt.Image");
            btnReceipt.ImageAlign = ContentAlignment.MiddleLeft;
            btnReceipt.Location = new Point(22, 436);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.RightToLeft = RightToLeft.No;
            btnReceipt.Size = new Size(188, 58);
            btnReceipt.TabIndex = 9;
            btnReceipt.Text = "      RECEIPT";
            btnReceipt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // pnlMove
            // 
            pnlMove.BackColor = SystemColors.ControlLightLight;
            pnlMove.Location = new Point(3, 177);
            pnlMove.Name = "pnlMove";
            pnlMove.Size = new Size(10, 64);
            pnlMove.TabIndex = 1;
            pnlMove.Paint += panel1_Paint;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 606);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(207, 58);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "         LOG OUT";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStaff
            // 
            btnStaff.FlatAppearance.BorderSize = 0;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnStaff.Image = (Image)resources.GetObject("btnStaff.Image");
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(19, 500);
            btnStaff.Name = "btnStaff";
            btnStaff.RightToLeft = RightToLeft.No;
            btnStaff.Size = new Size(188, 58);
            btnStaff.TabIndex = 7;
            btnStaff.Text = "         STAFF";
            btnStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnPOS
            // 
            btnPOS.BackgroundImageLayout = ImageLayout.Zoom;
            btnPOS.FlatAppearance.BorderSize = 0;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPOS.Image = (Image)resources.GetObject("btnPOS.Image");
            btnPOS.ImageAlign = ContentAlignment.MiddleLeft;
            btnPOS.Location = new Point(19, 244);
            btnPOS.Name = "btnPOS";
            btnPOS.RightToLeft = RightToLeft.No;
            btnPOS.Size = new Size(188, 58);
            btnPOS.TabIndex = 6;
            btnPOS.Text = "         POS";
            btnPOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOS.UseVisualStyleBackColor = true;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnCate
            // 
            btnCate.FlatAppearance.BorderSize = 0;
            btnCate.FlatStyle = FlatStyle.Flat;
            btnCate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCate.Image = (Image)resources.GetObject("btnCate.Image");
            btnCate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCate.Location = new Point(19, 372);
            btnCate.Name = "btnCate";
            btnCate.RightToLeft = RightToLeft.No;
            btnCate.Size = new Size(188, 58);
            btnCate.TabIndex = 5;
            btnCate.Text = "      CATEGORY";
            btnCate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCate.UseVisualStyleBackColor = true;
            btnCate.Click += btnCate_Click;
            // 
            // btnProduct
            // 
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(19, 308);
            btnProduct.Name = "btnProduct";
            btnProduct.RightToLeft = RightToLeft.No;
            btnProduct.Size = new Size(188, 58);
            btnProduct.TabIndex = 4;
            btnProduct.Text = "      PRODUCT";
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnBrand_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDashBoard.Image = (Image)resources.GetObject("btnDashBoard.Image");
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(9, 177);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(201, 61);
            btnDashBoard.TabIndex = 3;
            btnDashBoard.Text = "      DASH BOARD";
            btnDashBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // txtManagementSystem
            // 
            txtManagementSystem.AutoSize = true;
            txtManagementSystem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtManagementSystem.Location = new Point(9, 129);
            txtManagementSystem.Name = "txtManagementSystem";
            txtManagementSystem.Size = new Size(191, 21);
            txtManagementSystem.TabIndex = 2;
            txtManagementSystem.Text = "MANAGEMENT SYSTEM";
            // 
            // txtToyStore
            // 
            txtToyStore.AutoSize = true;
            txtToyStore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtToyStore.Location = new Point(60, 108);
            txtToyStore.Name = "txtToyStore";
            txtToyStore.Size = new Size(92, 21);
            txtToyStore.TabIndex = 1;
            txtToyStore.Text = "TOY STORE";
            // 
            // picShopicon
            // 
            picShopicon.Image = (Image)resources.GetObject("picShopicon.Image");
            picShopicon.Location = new Point(22, 3);
            picShopicon.Name = "picShopicon";
            picShopicon.Size = new Size(161, 102);
            picShopicon.SizeMode = PictureBoxSizeMode.Zoom;
            picShopicon.TabIndex = 0;
            picShopicon.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = pnlMove;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblDatetime);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(213, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 62);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 19);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 13;
            label2.Text = "(?)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 12;
            label1.Text = "ROLE :";
            // 
            // lblDatetime
            // 
            lblDatetime.AutoSize = true;
            lblDatetime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDatetime.Location = new Point(603, 19);
            lblDatetime.Name = "lblDatetime";
            lblDatetime.Size = new Size(27, 21);
            lblDatetime.TabIndex = 11;
            lblDatetime.Text = "(?)";
            lblDatetime.Click += lblDatetime_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(105, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(27, 21);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "(?)";
            lblUsername.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 9;
            label3.Text = "WELCOME :";
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 10;
            guna2Elipse2.TargetControl = this;
            // 
            // userControlDashBoard1
            // 
            userControlDashBoard1.BackColor = SystemColors.InactiveCaption;
            userControlDashBoard1.Dock = DockStyle.Fill;
            userControlDashBoard1.Location = new Point(213, 62);
            userControlDashBoard1.Name = "userControlDashBoard1";
            userControlDashBoard1.Size = new Size(857, 602);
            userControlDashBoard1.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1070, 664);
            Controls.Add(userControlDashBoard1);
            Controls.Add(panel1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShopicon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private PictureBox picShopicon;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label txtManagementSystem;
        private Label txtToyStore;
        private Button btnDashBoard;
        private Button btnProduct;
        private Button btnCate;
        private Button btnPOS;
        private Button btnStaff;
        private Button btnLogout;
        private Panel pnlMove;
        private Panel panel1;
        private Label label3;
        private Label lblUsername;
        private Label lblDatetime;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Timer timerdatentime;
        private HOANGPHUC.UserControlDashBoard userControlDashBoard1;
        private Label label2;
        private Label label1;
        private Button btnReceipt;
    }
}