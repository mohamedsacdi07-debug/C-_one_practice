namespace Assigment_3
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbloutputusage = new System.Windows.Forms.Label();
            this.lbloutputtax = new System.Windows.Forms.Label();
            this.lbloutputTotal = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter customer name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter previous reading";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter current reading";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter price per unit ($)";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Electricity usage (units)";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tax Amount (7%)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total bill (including $5 fixed charge)";
            // 
            // lbloutputusage
            // 
            this.lbloutputusage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutputusage.Location = new System.Drawing.Point(508, 338);
            this.lbloutputusage.Name = "lbloutputusage";
            this.lbloutputusage.Size = new System.Drawing.Size(276, 38);
            this.lbloutputusage.TabIndex = 7;
            // 
            // lbloutputtax
            // 
            this.lbloutputtax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutputtax.Location = new System.Drawing.Point(508, 408);
            this.lbloutputtax.Name = "lbloutputtax";
            this.lbloutputtax.Size = new System.Drawing.Size(266, 35);
            this.lbloutputtax.TabIndex = 8;
            // 
            // lbloutputTotal
            // 
            this.lbloutputTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutputTotal.Location = new System.Drawing.Point(508, 477);
            this.lbloutputTotal.Name = "lbloutputTotal";
            this.lbloutputTotal.Size = new System.Drawing.Size(266, 33);
            this.lbloutputTotal.TabIndex = 9;
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(414, 27);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(216, 26);
            this.txtcustomer.TabIndex = 10;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(414, 197);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(216, 26);
            this.txtunitprice.TabIndex = 11;
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(414, 136);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(216, 26);
            this.txtcurrent.TabIndex = 12;
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(414, 84);
            this.txtprevious.Multiline = true;
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(216, 28);
            this.txtprevious.TabIndex = 13;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(364, 273);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(178, 47);
            this.btncalculate.TabIndex = 14;
            this.btncalculate.Text = "Calculate Bill";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 561);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtprevious);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.lbloutputTotal);
            this.Controls.Add(this.lbloutputtax);
            this.Controls.Add(this.lbloutputusage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbloutputusage;
        private System.Windows.Forms.Label lbloutputtax;
        private System.Windows.Forms.Label lbloutputTotal;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.Button btncalculate;
    }
}

