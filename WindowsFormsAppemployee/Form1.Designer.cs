namespace WindowsFormsAppemployee
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtgs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combodept = new System.Windows.Forms.ComboBox();
            this.txthra = new System.Windows.Forms.TextBox();
            this.txtta = new System.Windows.Forms.TextBox();
            this.txtda = new System.Windows.Forms.TextBox();
            this.txtpf = new System.Windows.Forms.TextBox();
            this.txtdisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee id\r\n";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gross Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Employee Dept";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(351, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(252, 26);
            this.txtid.TabIndex = 8;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(351, 61);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 26);
            this.txtname.TabIndex = 9;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(351, 124);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(252, 26);
            this.txtsalary.TabIndex = 10;
            // 
            // txtgs
            // 
            this.txtgs.Location = new System.Drawing.Point(351, 182);
            this.txtgs.Name = "txtgs";
            this.txtgs.Size = new System.Drawing.Size(252, 26);
            this.txtgs.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "pf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Da";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Hra";
            // 
            // combodept
            // 
            this.combodept.FormattingEnabled = true;
            this.combodept.Location = new System.Drawing.Point(351, 233);
            this.combodept.Name = "combodept";
            this.combodept.Size = new System.Drawing.Size(252, 28);
            this.combodept.TabIndex = 22;
            // 
            // txthra
            // 
            this.txthra.Enabled = false;
            this.txthra.Location = new System.Drawing.Point(351, 299);
            this.txthra.Name = "txthra";
            this.txthra.Size = new System.Drawing.Size(252, 26);
            this.txthra.TabIndex = 23;
            // 
            // txtta
            // 
            this.txtta.Enabled = false;
            this.txtta.Location = new System.Drawing.Point(351, 363);
            this.txtta.Name = "txtta";
            this.txtta.Size = new System.Drawing.Size(252, 26);
            this.txtta.TabIndex = 24;
            // 
            // txtda
            // 
            this.txtda.Enabled = false;
            this.txtda.Location = new System.Drawing.Point(351, 426);
            this.txtda.Name = "txtda";
            this.txtda.Size = new System.Drawing.Size(252, 26);
            this.txtda.TabIndex = 25;
            // 
            // txtpf
            // 
            this.txtpf.Enabled = false;
            this.txtpf.Location = new System.Drawing.Point(351, 480);
            this.txtpf.Name = "txtpf";
            this.txtpf.Size = new System.Drawing.Size(252, 26);
            this.txtpf.TabIndex = 26;
            // 
            // txtdisplay
            // 
            this.txtdisplay.Location = new System.Drawing.Point(694, 546);
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(104, 35);
            this.txtdisplay.TabIndex = 27;
            this.txtdisplay.Text = "display";
            this.txtdisplay.UseVisualStyleBackColor = true;
            this.txtdisplay.Click += new System.EventHandler(this.txtdisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 603);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.txtpf);
            this.Controls.Add(this.txtda);
            this.Controls.Add(this.txtta);
            this.Controls.Add(this.txthra);
            this.Controls.Add(this.combodept);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtgs);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtgs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combodept;
        private System.Windows.Forms.TextBox txthra;
        private System.Windows.Forms.TextBox txtta;
        private System.Windows.Forms.TextBox txtda;
        private System.Windows.Forms.TextBox txtpf;
        private System.Windows.Forms.Button txtdisplay;
    }
}

