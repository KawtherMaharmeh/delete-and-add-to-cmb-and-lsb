namespace delete_and_add_to_cmb_and_lsb
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
            this.lbladdlist = new System.Windows.Forms.Label();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.lsbcity = new System.Windows.Forms.ListBox();
            this.lblselected = new System.Windows.Forms.Label();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.txtlsb = new System.Windows.Forms.TextBox();
            this.btndelc = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.txtcmb = new System.Windows.Forms.TextBox();
            this.lblbaddcombo = new System.Windows.Forms.Label();
            this.btnaddc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbladdlist
            // 
            this.lbladdlist.AutoSize = true;
            this.lbladdlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbladdlist.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdlist.Location = new System.Drawing.Point(19, 178);
            this.lbladdlist.Name = "lbladdlist";
            this.lbladdlist.Size = new System.Drawing.Size(52, 15);
            this.lbladdlist.TabIndex = 0;
            this.lbladdlist.Text = "list item";
            // 
            // cmbcity
            // 
            this.cmbcity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Items.AddRange(new object[] {
            "DEDSEA",
            "SALT"});
            this.cmbcity.Location = new System.Drawing.Point(22, 24);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(203, 23);
            this.cmbcity.TabIndex = 2;
            // 
            // lsbcity
            // 
            this.lsbcity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbcity.FormattingEnabled = true;
            this.lsbcity.ItemHeight = 15;
            this.lsbcity.Items.AddRange(new object[] {
            "AMMAN ",
            "KARAK ",
            "AQABA"});
            this.lsbcity.Location = new System.Drawing.Point(22, 64);
            this.lsbcity.Name = "lsbcity";
            this.lsbcity.Size = new System.Drawing.Size(203, 94);
            this.lsbcity.TabIndex = 3;
            // 
            // lblselected
            // 
            this.lblselected.AutoSize = true;
            this.lblselected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblselected.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselected.Location = new System.Drawing.Point(249, 53);
            this.lblselected.Name = "lblselected";
            this.lblselected.Size = new System.Drawing.Size(99, 15);
            this.lblselected.TabIndex = 4;
            this.lblselected.Text = "selected item add";
            // 
            // txtshow
            // 
            this.txtshow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshow.Location = new System.Drawing.Point(252, 81);
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(100, 22);
            this.txtshow.TabIndex = 6;
            this.txtshow.TextChanged += new System.EventHandler(this.txtshow_TextChanged);
            // 
            // txtlsb
            // 
            this.txtlsb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlsb.Location = new System.Drawing.Point(87, 174);
            this.txtlsb.Name = "txtlsb";
            this.txtlsb.Size = new System.Drawing.Size(100, 22);
            this.txtlsb.TabIndex = 7;
            // 
            // btndelc
            // 
            this.btndelc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelc.Location = new System.Drawing.Point(294, 216);
            this.btndelc.Name = "btndelc";
            this.btndelc.Size = new System.Drawing.Size(75, 23);
            this.btndelc.TabIndex = 8;
            this.btndelc.Text = "delete item";
            this.btndelc.UseVisualStyleBackColor = true;
            this.btndelc.Click += new System.EventHandler(this.btndelc_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(204, 174);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "add item";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(294, 174);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 10;
            this.btndel.Text = "delete item";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // txtcmb
            // 
            this.txtcmb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmb.Location = new System.Drawing.Point(87, 216);
            this.txtcmb.Name = "txtcmb";
            this.txtcmb.Size = new System.Drawing.Size(100, 22);
            this.txtcmb.TabIndex = 13;
            // 
            // lblbaddcombo
            // 
            this.lblbaddcombo.AutoSize = true;
            this.lblbaddcombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblbaddcombo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaddcombo.Location = new System.Drawing.Point(19, 220);
            this.lblbaddcombo.Name = "lblbaddcombo";
            this.lblbaddcombo.Size = new System.Drawing.Size(62, 15);
            this.lblbaddcombo.TabIndex = 14;
            this.lblbaddcombo.Text = "combo box";
            // 
            // btnaddc
            // 
            this.btnaddc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddc.Location = new System.Drawing.Point(204, 216);
            this.btnaddc.Name = "btnaddc";
            this.btnaddc.Size = new System.Drawing.Size(75, 23);
            this.btnaddc.TabIndex = 15;
            this.btnaddc.Text = "add item";
            this.btnaddc.UseVisualStyleBackColor = true;
            this.btnaddc.Click += new System.EventHandler(this.btnaddc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnaddc);
            this.Controls.Add(this.lblbaddcombo);
            this.Controls.Add(this.txtcmb);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btndelc);
            this.Controls.Add(this.txtlsb);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.lblselected);
            this.Controls.Add(this.lsbcity);
            this.Controls.Add(this.cmbcity);
            this.Controls.Add(this.lbladdlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdlist;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.ListBox lsbcity;
        private System.Windows.Forms.Label lblselected;
        private System.Windows.Forms.TextBox txtshow;
        private System.Windows.Forms.TextBox txtlsb;
        private System.Windows.Forms.Button btndelc;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.TextBox txtcmb;
        private System.Windows.Forms.Label lblbaddcombo;
        private System.Windows.Forms.Button btnaddc;
    }
}

