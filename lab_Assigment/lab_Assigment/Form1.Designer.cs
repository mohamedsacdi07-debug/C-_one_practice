namespace lab_Assigment
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiostsndard = new System.Windows.Forms.RadioButton();
            this.radionormal = new System.Windows.Forms.RadioButton();
            this.radiohights = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxbareakfast = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtnumofguest = new System.Windows.Forms.TextBox();
            this.booking = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiohights);
            this.groupBox2.Controls.Add(this.radionormal);
            this.groupBox2.Controls.Add(this.radiostsndard);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(90, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room type";
            // 
            // radiostsndard
            // 
            this.radiostsndard.AutoSize = true;
            this.radiostsndard.Location = new System.Drawing.Point(13, 55);
            this.radiostsndard.Name = "radiostsndard";
            this.radiostsndard.Size = new System.Drawing.Size(139, 33);
            this.radiostsndard.TabIndex = 2;
            this.radiostsndard.TabStop = true;
            this.radiostsndard.Text = "standard";
            this.radiostsndard.UseVisualStyleBackColor = true;
            // 
            // radionormal
            // 
            this.radionormal.AutoSize = true;
            this.radionormal.Location = new System.Drawing.Point(182, 55);
            this.radionormal.Name = "radionormal";
            this.radionormal.Size = new System.Drawing.Size(118, 33);
            this.radionormal.TabIndex = 3;
            this.radionormal.TabStop = true;
            this.radionormal.Text = "normal";
            this.radionormal.UseVisualStyleBackColor = true;
            // 
            // radiohights
            // 
            this.radiohights.AutoSize = true;
            this.radiohights.Location = new System.Drawing.Point(343, 55);
            this.radiohights.Name = "radiohights";
            this.radiohights.Size = new System.Drawing.Size(112, 33);
            this.radiohights.TabIndex = 4;
            this.radiohights.TabStop = true;
            this.radiohights.Text = "Hights";
            this.radiohights.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxbareakfast);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(90, 448);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adinotal options";
            // 
            // checkBoxbareakfast
            // 
            this.checkBoxbareakfast.AutoSize = true;
            this.checkBoxbareakfast.Location = new System.Drawing.Point(13, 47);
            this.checkBoxbareakfast.Name = "checkBoxbareakfast";
            this.checkBoxbareakfast.Size = new System.Drawing.Size(441, 33);
            this.checkBoxbareakfast.TabIndex = 3;
            this.checkBoxbareakfast.Text = "Bareakfast (10 per guest per nigts)";
            this.checkBoxbareakfast.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(154, 590);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(157, 38);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(391, 590);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(132, 38);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(626, 590);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(144, 33);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "guest name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "guest age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "number of nights";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "number of guest";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnumofguest);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtnights);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(114, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "personal information";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(319, 27);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 39);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(319, 116);
            this.txtnights.Multiline = true;
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(239, 39);
            this.txtnights.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(319, 72);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(239, 32);
            this.txtAge.TabIndex = 7;
            // 
            // txtnumofguest
            // 
            this.txtnumofguest.Location = new System.Drawing.Point(319, 161);
            this.txtnumofguest.Multiline = true;
            this.txtnumofguest.Name = "txtnumofguest";
            this.txtnumofguest.Size = new System.Drawing.Size(239, 31);
            this.txtnumofguest.TabIndex = 8;
            // 
            // booking
            // 
            this.booking.FormattingEnabled = true;
            this.booking.ItemHeight = 20;
            this.booking.Location = new System.Drawing.Point(747, 24);
            this.booking.Name = "booking";
            this.booking.Size = new System.Drawing.Size(295, 524);
            this.booking.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1075, 655);
            this.Controls.Add(this.booking);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiohights;
        private System.Windows.Forms.RadioButton radionormal;
        private System.Windows.Forms.RadioButton radiostsndard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxbareakfast;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnumofguest;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox booking;
    }
}

