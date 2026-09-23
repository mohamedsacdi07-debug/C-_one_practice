namespace Assignment1
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblconcatination = new System.Windows.Forms.Label();
            this.txtenterdayofweek = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtnumericofthemonth = new System.Windows.Forms.TextBox();
            this.txtnameofmonth = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter day of week";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter name of month";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter numeric of the month";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter of the year";
            // 
            // lblconcatination
            // 
            this.lblconcatination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblconcatination.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconcatination.Location = new System.Drawing.Point(202, 244);
            this.lblconcatination.Name = "lblconcatination";
            this.lblconcatination.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblconcatination.Size = new System.Drawing.Size(508, 54);
            this.lblconcatination.TabIndex = 4;
            // 
            // txtenterdayofweek
            // 
            this.txtenterdayofweek.Location = new System.Drawing.Point(384, 38);
            this.txtenterdayofweek.Name = "txtenterdayofweek";
            this.txtenterdayofweek.Size = new System.Drawing.Size(201, 26);
            this.txtenterdayofweek.TabIndex = 5;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(384, 180);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(201, 26);
            this.txtyear.TabIndex = 6;
            this.txtyear.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtnumericofthemonth
            // 
            this.txtnumericofthemonth.Location = new System.Drawing.Point(384, 133);
            this.txtnumericofthemonth.Name = "txtnumericofthemonth";
            this.txtnumericofthemonth.Size = new System.Drawing.Size(201, 26);
            this.txtnumericofthemonth.TabIndex = 7;
            // 
            // txtnameofmonth
            // 
            this.txtnameofmonth.Location = new System.Drawing.Point(384, 82);
            this.txtnameofmonth.Name = "txtnameofmonth";
            this.txtnameofmonth.Size = new System.Drawing.Size(201, 26);
            this.txtnameofmonth.TabIndex = 8;
            this.txtnameofmonth.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(178, 357);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(131, 36);
            this.btnshow.TabIndex = 9;
            this.btnshow.Text = "Show me";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(345, 357);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(124, 33);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(514, 357);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(138, 36);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 435);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtnameofmonth);
            this.Controls.Add(this.txtnumericofthemonth);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtenterdayofweek);
            this.Controls.Add(this.lblconcatination);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblconcatination;
        private System.Windows.Forms.TextBox txtenterdayofweek;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtnumericofthemonth;
        private System.Windows.Forms.TextBox txtnameofmonth;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

