namespace _1203_2
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
            menuStrip1 = new MenuStrip();
            功能ToolStripMenuItem = new ToolStripMenuItem();
            兌換ToolStripMenuItem = new ToolStripMenuItem();
            離開ToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 功能ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(478, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 功能ToolStripMenuItem
            // 
            功能ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 兌換ToolStripMenuItem, 離開ToolStripMenuItem });
            功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            功能ToolStripMenuItem.Size = new Size(73, 34);
            功能ToolStripMenuItem.Text = "功能";
            // 
            // 兌換ToolStripMenuItem
            // 
            兌換ToolStripMenuItem.Name = "兌換ToolStripMenuItem";
            兌換ToolStripMenuItem.Size = new Size(180, 34);
            兌換ToolStripMenuItem.Text = "兌換";
            兌換ToolStripMenuItem.Click += 兌換ToolStripMenuItem_Click;
            // 
            // 離開ToolStripMenuItem
            // 
            離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            離開ToolStripMenuItem.Size = new Size(180, 34);
            離開ToolStripMenuItem.Text = "離開";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(147, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 42);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(129, 35);
            label1.TabIndex = 2;
            label1.Text = "兌換金額:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(129, 35);
            label2.TabIndex = 3;
            label2.Text = "兌換選項:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(147, 118);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(195, 39);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "最少數量貨幣";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(147, 163);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(249, 39);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "最多面額種類貨幣";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 158);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "兌換種類";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(301, 48);
            label6.Name = "label6";
            label6.Size = new Size(47, 35);
            label6.TabIndex = 9;
            label6.Text = "$1";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(206, 48);
            label5.Name = "label5";
            label5.Size = new Size(47, 35);
            label5.TabIndex = 8;
            label5.Text = "$5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(111, 48);
            label4.Name = "label4";
            label4.Size = new Size(63, 35);
            label4.TabIndex = 7;
            label4.Text = "$20";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 48);
            label3.Name = "label3";
            label3.Size = new Size(63, 35);
            label3.TabIndex = 6;
            label3.Text = "$25";
            label3.Click += label3_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(301, 86);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(137, 42);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(206, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(89, 42);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(111, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(89, 42);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(16, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 42);
            textBox2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 388);
            Controls.Add(groupBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "零錢兌換機";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 功能ToolStripMenuItem;
        private ToolStripMenuItem 兌換ToolStripMenuItem;
        private ToolStripMenuItem 離開ToolStripMenuItem;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}