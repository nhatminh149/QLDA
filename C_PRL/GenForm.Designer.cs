namespace C_PRL
{
    partial class GenForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            butMua = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 245);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 51);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 2;
            label2.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 79);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 113);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 4;
            label4.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 139);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 5;
            label5.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 169);
            label6.Name = "label6";
            label6.Size = new Size(16, 15);
            label6.TabIndex = 6;
            label6.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(265, 202);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 7;
            label7.Text = "Số lượng mua";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 23);
            textBox1.TabIndex = 8;
            // 
            // butMua
            // 
            butMua.Location = new Point(344, 229);
            butMua.Name = "butMua";
            butMua.Size = new Size(75, 28);
            butMua.TabIndex = 9;
            butMua.Text = "Mua";
            butMua.UseVisualStyleBackColor = true;
            butMua.Click += butMua_Click;
            // 
            // GenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 264);
            Controls.Add(butMua);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "GenForm";
            Text = "GenForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private Button butMua;
    }
}