namespace lab_Assigment2
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
            this.txtclories = new System.Windows.Forms.TextBox();
            this.txtfatgram = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.checkBoxlowfat = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblpercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtclories
            // 
            this.txtclories.Location = new System.Drawing.Point(329, 46);
            this.txtclories.Multiline = true;
            this.txtclories.Name = "txtclories";
            this.txtclories.Size = new System.Drawing.Size(254, 37);
            this.txtclories.TabIndex = 0;
            // 
            // txtfatgram
            // 
            this.txtfatgram.Location = new System.Drawing.Point(329, 100);
            this.txtfatgram.Multiline = true;
            this.txtfatgram.Name = "txtfatgram";
            this.txtfatgram.Size = new System.Drawing.Size(254, 35);
            this.txtfatgram.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "colries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "fat";
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(137, 227);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(134, 54);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // checkBoxlowfat
            // 
            this.checkBoxlowfat.AutoSize = true;
            this.checkBoxlowfat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxlowfat.Location = new System.Drawing.Point(381, 241);
            this.checkBoxlowfat.Name = "checkBoxlowfat";
            this.checkBoxlowfat.Size = new System.Drawing.Size(94, 29);
            this.checkBoxlowfat.TabIndex = 5;
            this.checkBoxlowfat.Text = "lowfat";
            this.checkBoxlowfat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "number of color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "percentage of fat";
            // 
            // lblnumber
            // 
            this.lblnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnumber.Location = new System.Drawing.Point(436, 319);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(569, 88);
            this.lblnumber.TabIndex = 8;
            // 
            // lblpercentage
            // 
            this.lblpercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpercentage.Location = new System.Drawing.Point(381, 493);
            this.lblpercentage.Name = "lblpercentage";
            this.lblpercentage.Size = new System.Drawing.Size(555, 101);
            this.lblpercentage.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 663);
            this.Controls.Add(this.lblpercentage);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxlowfat);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfatgram);
            this.Controls.Add(this.txtclories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtclories;
        private System.Windows.Forms.TextBox txtfatgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.CheckBox checkBoxlowfat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblpercentage;
    }
}

