namespace _113_10_22_3
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(82, 80);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(429, 341);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "個人資料";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 79);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 0;
            label1.Text = "姓名:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 36);
            textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(551, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 162);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(110, 173);
            button1.Name = "button1";
            button1.Size = new Size(146, 68);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(50, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 28);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "內用";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(50, 71);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(77, 28);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "外帶";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 671);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("標楷體", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "個人資料";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
