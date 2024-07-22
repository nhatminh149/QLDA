namespace C_PRL
{
    partial class FormSanPham
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
            butShowSp = new Button();
            tabSanPham = new TableLayoutPanel();
            labBack = new Label();
            labNext = new Label();
            labPage = new Label();
            SuspendLayout();
            // 
            // butShowSp
            // 
            butShowSp.Location = new Point(12, 30);
            butShowSp.Name = "butShowSp";
            butShowSp.Size = new Size(87, 50);
            butShowSp.TabIndex = 0;
            butShowSp.Text = "Hiển thị sản phẩm";
            butShowSp.UseVisualStyleBackColor = true;
            butShowSp.Click += butShowSp_Click;
            // 
            // tabSanPham
            // 
            tabSanPham.ColumnCount = 2;
            tabSanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tabSanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tabSanPham.Location = new Point(177, 12);
            tabSanPham.Name = "tabSanPham";
            tabSanPham.RowCount = 2;
            tabSanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tabSanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tabSanPham.Size = new Size(1110, 705);
            tabSanPham.TabIndex = 1;
            // 
            // labBack
            // 
            labBack.AutoSize = true;
            labBack.Location = new Point(654, 737);
            labBack.Name = "labBack";
            labBack.Size = new Size(31, 15);
            labBack.TabIndex = 2;
            labBack.Text = "<<<";
            labBack.Click += labBack_Click;
            // 
            // labNext
            // 
            labNext.AutoSize = true;
            labNext.Location = new Point(789, 738);
            labNext.Name = "labNext";
            labNext.Size = new Size(31, 15);
            labNext.TabIndex = 3;
            labNext.Text = ">>>";
            labNext.Click += labNext_Click;
            // 
            // labPage
            // 
            labPage.AutoSize = true;
            labPage.Location = new Point(716, 737);
            labPage.Name = "labPage";
            labPage.Size = new Size(13, 15);
            labPage.TabIndex = 4;
            labPage.Text = "1";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 770);
            Controls.Add(labPage);
            Controls.Add(labNext);
            Controls.Add(labBack);
            Controls.Add(tabSanPham);
            Controls.Add(butShowSp);
            Name = "FormSanPham";
            Text = "FormSanPham";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butShowSp;
        private TableLayoutPanel tabSanPham;
        private Label labBack;
        private Label labNext;
        private Label labPage;
    }
}