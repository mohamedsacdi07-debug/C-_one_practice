namespace Assigment
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
            this.btnreadfunctions = new System.Windows.Forms.Button();
            this.btndeleteitem = new System.Windows.Forms.Button();
            this.btndeletefile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnreadfunctions
            // 
            this.btnreadfunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadfunctions.Location = new System.Drawing.Point(113, 43);
            this.btnreadfunctions.Name = "btnreadfunctions";
            this.btnreadfunctions.Size = new System.Drawing.Size(234, 122);
            this.btnreadfunctions.TabIndex = 1;
            this.btnreadfunctions.Text = "read other function";
            this.btnreadfunctions.UseVisualStyleBackColor = true;
            this.btnreadfunctions.Click += new System.EventHandler(this.btnreadfunctions_Click);
            // 
            // btndeleteitem
            // 
            this.btndeleteitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteitem.Location = new System.Drawing.Point(162, 209);
            this.btndeleteitem.Name = "btndeleteitem";
            this.btndeleteitem.Size = new System.Drawing.Size(110, 111);
            this.btndeleteitem.TabIndex = 3;
            this.btndeleteitem.Text = "Delete item";
            this.btndeleteitem.UseVisualStyleBackColor = true;
            this.btndeleteitem.Click += new System.EventHandler(this.btndeleteitem_Click);
            // 
            // btndeletefile
            // 
            this.btndeletefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletefile.Location = new System.Drawing.Point(162, 368);
            this.btndeletefile.Name = "btndeletefile";
            this.btndeletefile.Size = new System.Drawing.Size(110, 118);
            this.btndeletefile.TabIndex = 4;
            this.btndeletefile.Text = "Delete file";
            this.btndeletefile.UseVisualStyleBackColor = true;
            this.btndeletefile.Click += new System.EventHandler(this.btndeletefile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(462, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 404);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(977, 616);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndeletefile);
            this.Controls.Add(this.btndeleteitem);
            this.Controls.Add(this.btnreadfunctions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnreadfunctions;
        private System.Windows.Forms.Button btndeleteitem;
        private System.Windows.Forms.Button btndeletefile;
        private System.Windows.Forms.ListBox listBox1;
    }
}

