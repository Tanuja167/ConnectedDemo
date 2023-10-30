namespace ConnectedDemo
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbldid = new System.Windows.Forms.Label();
            this.cmbdep = new System.Windows.Forms.ComboBox();
            this.lblsal = new System.Windows.Forms.Label();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(31, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(141, 24);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 1;
            this.txtid.Text = "2";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(31, 195);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(31, 139);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(41, 16);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(141, 195);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 22);
            this.txtage.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(141, 136);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 22);
            this.txtemail.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(141, 77);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 7;
            // 
            // lbldid
            // 
            this.lbldid.AutoSize = true;
            this.lbldid.Location = new System.Drawing.Point(31, 316);
            this.lbldid.Name = "lbldid";
            this.lbldid.Size = new System.Drawing.Size(28, 16);
            this.lbldid.TabIndex = 8;
            this.lbldid.Text = "Did";
            // 
            // cmbdep
            // 
            this.cmbdep.FormattingEnabled = true;
            this.cmbdep.Location = new System.Drawing.Point(141, 308);
            this.cmbdep.Name = "cmbdep";
            this.cmbdep.Size = new System.Drawing.Size(100, 24);
            this.cmbdep.TabIndex = 9;
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Location = new System.Drawing.Point(31, 255);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(46, 16);
            this.lblsal.TabIndex = 10;
            this.lblsal.Text = "Salary";
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(141, 249);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 22);
            this.txtsal.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 196);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(333, 37);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(333, 93);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(333, 156);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(333, 219);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(581, 276);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(168, 34);
            this.btnshowall.TabIndex = 17;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 473);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.cmbdep);
            this.Controls.Add(this.lbldid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbldid;
        private System.Windows.Forms.ComboBox cmbdep;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnshowall;
    }
}

