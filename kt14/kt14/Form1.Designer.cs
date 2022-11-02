namespace kt14
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
            this.tx1 = new System.Windows.Forms.TextBox();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.tx3 = new System.Windows.Forms.TextBox();
            this.tx4 = new System.Windows.Forms.TextBox();
            this.tx5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(88, 73);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(151, 23);
            this.tx1.TabIndex = 0;
            this.tx1.TextChanged += new System.EventHandler(this.tx1_TextChanged);
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(88, 102);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(151, 23);
            this.tx2.TabIndex = 1;
            this.tx2.TextChanged += new System.EventHandler(this.tx2_TextChanged);
            // 
            // tx3
            // 
            this.tx3.Location = new System.Drawing.Point(88, 131);
            this.tx3.Name = "tx3";
            this.tx3.Size = new System.Drawing.Size(151, 23);
            this.tx3.TabIndex = 2;
            
            this.tx3.TextChanged += new System.EventHandler(this.tx3_TextChanged);
            // 
            // tx4
            // 
            this.tx4.Location = new System.Drawing.Point(88, 160);
            this.tx4.Name = "tx4";
            this.tx4.Size = new System.Drawing.Size(151, 23);
            this.tx4.TabIndex = 3;
            this.tx4.TextChanged += new System.EventHandler(this.tx4_TextChanged);
            // 
            // tx5
            // 
            this.tx5.Location = new System.Drawing.Point(88, 189);
            this.tx5.Name = "tx5";
            this.tx5.Size = new System.Drawing.Size(151, 23);
            this.tx5.TabIndex = 4;
            this.tx5.TextChanged += new System.EventHandler(this.tx5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patronymic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Age";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(104, 232);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(114, 23);
            this.btn.TabIndex = 10;
            this.btn.Text = "Add new student";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(446, 73);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(22, 15);
            this.output.TabIndex = 11;
            this.output.Text = "list";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "List students";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(709, 426);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 15);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "link on lesson";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.output);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx5);
            this.Controls.Add(this.tx4);
            this.Controls.Add(this.tx3);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.tx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tx1;
        private TextBox tx2;
        private TextBox tx3;
        private TextBox tx4;
        private TextBox tx5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn;
        private Label output;
        private Label label7;
        private LinkLabel linkLabel1;
    }
}