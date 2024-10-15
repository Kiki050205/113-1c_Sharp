namespace _113221039
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
            txtdayofweek1 = new Label();
            txtDay2 = new Label();
            txtMonth3 = new Label();
            txtYear4 = new Label();
            txtdayofweek = new TextBox();
            txtday = new TextBox();
            txtMonth = new TextBox();
            txtYear = new TextBox();
            lblshow = new Label();
            btnshowday = new Button();
            btnclear = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // txtdayofweek1
            // 
            txtdayofweek1.AutoSize = true;
            txtdayofweek1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtdayofweek1.Location = new Point(235, 65);
            txtdayofweek1.Name = "txtdayofweek1";
            txtdayofweek1.Size = new Size(104, 37);
            txtdayofweek1.TabIndex = 0;
            txtdayofweek1.Text = "星期幾";
            // 
            // txtDay2
            // 
            txtDay2.AutoSize = true;
            txtDay2.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDay2.Location = new Point(264, 125);
            txtDay2.Name = "txtDay2";
            txtDay2.Size = new Size(75, 37);
            txtDay2.TabIndex = 1;
            txtDay2.Text = "日期";
            // 
            // txtMonth3
            // 
            txtMonth3.AutoSize = true;
            txtMonth3.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtMonth3.Location = new Point(264, 188);
            txtMonth3.Name = "txtMonth3";
            txtMonth3.Size = new Size(75, 37);
            txtMonth3.TabIndex = 2;
            txtMonth3.Text = "月份";
            // 
            // txtYear4
            // 
            txtYear4.AutoSize = true;
            txtYear4.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtYear4.Location = new Point(264, 253);
            txtYear4.Name = "txtYear4";
            txtYear4.Size = new Size(75, 37);
            txtYear4.TabIndex = 3;
            txtYear4.Text = "年份";
            // 
            // txtdayofweek
            // 
            txtdayofweek.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtdayofweek.Location = new Point(360, 64);
            txtdayofweek.Name = "txtdayofweek";
            txtdayofweek.Size = new Size(184, 38);
            txtdayofweek.TabIndex = 4;
            // 
            // txtday
            // 
            txtday.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtday.Location = new Point(360, 124);
            txtday.Name = "txtday";
            txtday.Size = new Size(184, 38);
            txtday.TabIndex = 5;
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtMonth.Location = new Point(360, 190);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(184, 38);
            txtMonth.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtYear.Location = new Point(360, 255);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(184, 38);
            txtYear.TabIndex = 7;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Location = new Point(235, 347);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(288, 54);
            lblshow.TabIndex = 8;
            // 
            // btnshowday
            // 
            btnshowday.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnshowday.Location = new Point(62, 453);
            btnshowday.Name = "btnshowday";
            btnshowday.Size = new Size(166, 96);
            btnshowday.TabIndex = 9;
            btnshowday.Text = "顯示完整日期";
            btnshowday.UseVisualStyleBackColor = true;
            btnshowday.Click += button1_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnclear.Location = new Point(297, 453);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(166, 96);
            btnclear.TabIndex = 10;
            btnclear.Text = "清空內容";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnexit.Location = new Point(549, 453);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(166, 96);
            btnexit.TabIndex = 11;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 646);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnshowday);
            Controls.Add(lblshow);
            Controls.Add(txtYear);
            Controls.Add(txtMonth);
            Controls.Add(txtday);
            Controls.Add(txtdayofweek);
            Controls.Add(txtYear4);
            Controls.Add(txtMonth3);
            Controls.Add(txtDay2);
            Controls.Add(txtdayofweek1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtdayofweek1;
        private Label txtDay2;
        private Label txtMonth3;
        private Label txtYear4;
        private TextBox txtdayofweek;
        private TextBox txtday;
        private TextBox txtMonth;
        private TextBox txtYear;
        private Label lblshow;
        private Button btnshowday;
        private Button btnclear;
        private Button btnexit;
    }
}
