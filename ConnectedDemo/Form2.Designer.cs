namespace ConnectedDemo
{
    partial class Form2
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
            this.btnshowall = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.lblsal = new System.Windows.Forms.Label();
            this.cmbdep = new System.Windows.Forms.ComboBox();
            this.lbldid = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(665, 349);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(168, 34);
            this.btnshowall.TabIndex = 35;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(417, 292);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 34;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(417, 229);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 33;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(417, 166);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 32;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(417, 110);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 31;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(540, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 196);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(225, 322);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 22);
            this.txtsal.TabIndex = 29;
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Location = new System.Drawing.Point(115, 328);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(46, 16);
            this.lblsal.TabIndex = 28;
            this.lblsal.Text = "Salary";
            // 
            // cmbdep
            // 
            this.cmbdep.FormattingEnabled = true;
            this.cmbdep.Location = new System.Drawing.Point(225, 381);
            this.cmbdep.Name = "cmbdep";
            this.cmbdep.Size = new System.Drawing.Size(100, 24);
            this.cmbdep.TabIndex = 27;
            // 
            // lbldid
            // 
            this.lbldid.AutoSize = true;
            this.lbldid.Location = new System.Drawing.Point(115, 389);
            this.lbldid.Name = "lbldid";
            this.lbldid.Size = new System.Drawing.Size(28, 16);
            this.lbldid.TabIndex = 26;
            this.lbldid.Text = "Did";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(225, 150);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 25;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(225, 209);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 22);
            this.txtemail.TabIndex = 24;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(225, 268);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 22);
            this.txtage.TabIndex = 23;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(115, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(115, 212);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(41, 16);
            this.lblemail.TabIndex = 21;
            this.lblemail.Text = "Email";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(115, 268);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 20;
            this.lblAge.Text = "Age";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(225, 97);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 19;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(115, 100);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 502);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.ComboBox cmbdep;
        private System.Windows.Forms.Label lbldid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblID;
    }
}