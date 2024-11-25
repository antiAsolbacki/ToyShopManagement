namespace TOYSTORE.HOANGPHUC
{
    partial class frmPOSview
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnOK = new Button();
            lblItems = new Label();
            dgvBill = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Origin = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            pnlBot = new Guna.UI2.WinForms.Guna2Panel();
            pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            label5 = new Label();
            lblOnline = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            pnlBot.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.None;
            btnOK.BackColor = Color.SteelBlue;
            btnOK.ForeColor = SystemColors.Info;
            btnOK.Location = new Point(690, 0);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(143, 50);
            btnOK.TabIndex = 70;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // lblItems
            // 
            lblItems.Anchor = AnchorStyles.None;
            lblItems.AutoSize = true;
            lblItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItems.ForeColor = SystemColors.ControlText;
            lblItems.Location = new Point(12, 476);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(60, 21);
            lblItems.TabIndex = 69;
            lblItems.Text = "Items :";
            // 
            // dgvBill
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBill.ColumnHeadersHeight = 17;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Discount, Age, Origin, Note });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBill.GridColor = Color.FromArgb(192, 192, 255);
            dgvBill.Location = new Point(0, 48);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersVisible = false;
            dgvBill.Size = new Size(857, 384);
            dgvBill.TabIndex = 67;
            dgvBill.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBill.ThemeStyle.BackColor = Color.White;
            dgvBill.ThemeStyle.GridColor = Color.FromArgb(192, 192, 255);
            dgvBill.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBill.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBill.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvBill.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBill.ThemeStyle.HeaderStyle.Height = 17;
            dgvBill.ThemeStyle.ReadOnly = false;
            dgvBill.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBill.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBill.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvBill.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBill.ThemeStyle.RowsStyle.Height = 25;
            dgvBill.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBill.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Qty";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount";
            Discount.Name = "Discount";
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            // 
            // Origin
            // 
            Origin.HeaderText = "Xuat su";
            Origin.Name = "Origin";
            // 
            // Note
            // 
            Note.HeaderText = "Note";
            Note.Name = "Note";
            // 
            // pnlBot
            // 
            pnlBot.BackColor = SystemColors.ActiveCaption;
            pnlBot.Controls.Add(btnOK);
            pnlBot.CustomizableEdges = customizableEdges1;
            pnlBot.Dock = DockStyle.Bottom;
            pnlBot.Location = new Point(0, 504);
            pnlBot.Name = "pnlBot";
            pnlBot.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlBot.Size = new Size(857, 50);
            pnlBot.TabIndex = 66;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.SteelBlue;
            pnlTop.Controls.Add(label5);
            pnlTop.Controls.Add(lblOnline);
            pnlTop.CustomizableEdges = customizableEdges3;
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlTop.Size = new Size(857, 42);
            pnlTop.TabIndex = 65;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.OldLace;
            label5.Location = new Point(354, 9);
            label5.Name = "label5";
            label5.Size = new Size(125, 22);
            label5.TabIndex = 66;
            label5.Text = "POS CHECK";
            // 
            // lblOnline
            // 
            lblOnline.Anchor = AnchorStyles.None;
            lblOnline.AutoSize = true;
            lblOnline.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOnline.ForeColor = Color.OldLace;
            lblOnline.Location = new Point(620, -20);
            lblOnline.Name = "lblOnline";
            lblOnline.Size = new Size(88, 22);
            lblOnline.TabIndex = 65;
            lblOnline.Text = "ONLINE ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 439);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 71;
            label1.Text = "Total :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(313, 439);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 72;
            label2.Text = "Customer :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(313, 476);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 73;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(587, 439);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 74;
            label4.Text = "Address :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(587, 476);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 75;
            label6.Text = "Discount :";
            // 
            // frmPOSview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 554);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblItems);
            Controls.Add(label1);
            Controls.Add(dgvBill);
            Controls.Add(pnlBot);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPOSview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPOSview";
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            pnlBot.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOK;
        private Label lblItems;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBill;
        private Guna.UI2.WinForms.Guna2Panel pnlBot;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private Label lblOnline;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Origin;
        private DataGridViewTextBoxColumn Note;
        private Label label6;
    }
}