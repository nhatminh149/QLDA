﻿namespace C_PRL
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_sanpham = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            butSANPHAM = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(butSANPHAM);
            panel1.Controls.Add(btn_sanpham);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 540);
            panel1.TabIndex = 0;
            // 
            // btn_sanpham
            // 
            btn_sanpham.BackColor = Color.LightBlue;
            btn_sanpham.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sanpham.Location = new Point(0, 255);
            btn_sanpham.Margin = new Padding(3, 2, 3, 2);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Size = new Size(158, 45);
            btn_sanpham.TabIndex = 0;
            btn_sanpham.Text = "Nhân Viên";
            btn_sanpham.UseVisualStyleBackColor = false;
            btn_sanpham.Click += btn_sanpham_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.MediumTurquoise;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(200, 9);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(971, 540);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // butSANPHAM
            // 
            butSANPHAM.BackColor = Color.LightBlue;
            butSANPHAM.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butSANPHAM.Location = new Point(0, 183);
            butSANPHAM.Margin = new Padding(3, 2, 3, 2);
            butSANPHAM.Name = "butSANPHAM";
            butSANPHAM.Size = new Size(158, 45);
            butSANPHAM.TabIndex = 1;
            butSANPHAM.Text = "Sản phẩm";
            butSANPHAM.UseVisualStyleBackColor = false;
            butSANPHAM.Click += butSANPHAM_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 590);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_sanpham;
        private TableLayoutPanel tableLayoutPanel1;
        private Button butSANPHAM;
    }
}
