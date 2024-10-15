namespace _113_10_15_2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbkm = new TextBox();
            txbliter = new TextBox();
            lblshow = new Label();
            btn1 = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("標楷體", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(153, 108);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("標楷體", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(153, 253);
            label2.Name = "label2";
            label2.Size = new Size(178, 29);
            label2.TabIndex = 1;
            label2.Text = "公里/每公升";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("標楷體", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(153, 178);
            label3.Name = "label3";
            label3.Size = new Size(133, 29);
            label3.TabIndex = 2;
            label3.Text = "使用油耗";
            // 
            // txbkm
            // 
            txbkm.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbkm.Location = new Point(416, 99);
            txbkm.Name = "txbkm";
            txbkm.Size = new Size(100, 38);
            txbkm.TabIndex = 3;
            // 
            // txbliter
            // 
            txbliter.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbliter.Location = new Point(416, 174);
            txbliter.Name = "txbliter";
            txbliter.Size = new Size(100, 38);
            txbliter.TabIndex = 4;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Location = new Point(411, 244);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(126, 52);
            lblshow.TabIndex = 5;
            lblshow.Click += label4_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn1.Location = new Point(103, 334);
            btn1.Name = "btn1";
            btn1.Size = new Size(183, 73);
            btn1.TabIndex = 6;
            btn1.Text = "計算";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnexit.Location = new Point(411, 334);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(183, 73);
            btnexit.TabIndex = 7;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnexit);
            Controls.Add(btn1);
            Controls.Add(lblshow);
            Controls.Add(txbliter);
            Controls.Add(txbkm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbkm;
        private TextBox txbliter;
        private Label lblshow;
        private Button btn1;
        private Button btnexit;
    }
}
