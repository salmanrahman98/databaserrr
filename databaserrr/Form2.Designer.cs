namespace databaserrr
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
            this.components = new System.ComponentModel.Container();
            this.btsave = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btdisplay = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbsalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new databaserrr.Database1DataSet3();
            this.btfetch = new System.Windows.Forms.Button();
            this.btselectimage = new System.Windows.Forms.Button();
            this.btsaveimage = new System.Windows.Forms.Button();
            this.tbimage = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(695, 24);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 23);
            this.btsave.TabIndex = 0;
            this.btsave.Text = "save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(695, 84);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 1;
            this.btupdate.Text = "update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(695, 122);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 2;
            this.btdelete.Text = "delete";
            this.btdelete.UseVisualStyleBackColor = true;
            // 
            // btdisplay
            // 
            this.btdisplay.Location = new System.Drawing.Point(695, 163);
            this.btdisplay.Name = "btdisplay";
            this.btdisplay.Size = new System.Drawing.Size(75, 23);
            this.btdisplay.TabIndex = 3;
            this.btdisplay.Text = "display";
            this.btdisplay.UseVisualStyleBackColor = true;
            this.btdisplay.Click += new System.EventHandler(this.btdisplay_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(695, 205);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 4;
            this.btexit.Text = "exit";
            this.btexit.UseVisualStyleBackColor = true;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(106, 34);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(100, 20);
            this.tbid.TabIndex = 5;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(106, 89);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 6;
            // 
            // tbsalary
            // 
            this.tbsalary.Location = new System.Drawing.Point(106, 142);
            this.tbsalary.Name = "tbsalary";
            this.tbsalary.Size = new System.Drawing.Size(100, 20);
            this.tbsalary.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "salary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.database1DataSet3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(233, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 216);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // database1DataSet3BindingSource
            // 
            this.database1DataSet3BindingSource.DataSource = this.database1DataSet3;
            this.database1DataSet3BindingSource.Position = 0;
            this.database1DataSet3BindingSource.CurrentChanged += new System.EventHandler(this.database1DataSet3BindingSource_CurrentChanged);
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btfetch
            // 
            this.btfetch.Location = new System.Drawing.Point(695, 55);
            this.btfetch.Name = "btfetch";
            this.btfetch.Size = new System.Drawing.Size(75, 23);
            this.btfetch.TabIndex = 12;
            this.btfetch.Text = "fetch";
            this.btfetch.UseVisualStyleBackColor = true;
            this.btfetch.Click += new System.EventHandler(this.btfetch_Click);
            // 
            // btselectimage
            // 
            this.btselectimage.Location = new System.Drawing.Point(598, 298);
            this.btselectimage.Name = "btselectimage";
            this.btselectimage.Size = new System.Drawing.Size(128, 23);
            this.btselectimage.TabIndex = 13;
            this.btselectimage.Text = "Select image";
            this.btselectimage.UseVisualStyleBackColor = true;
            this.btselectimage.Click += new System.EventHandler(this.btselectimage_Click);
            // 
            // btsaveimage
            // 
            this.btsaveimage.Location = new System.Drawing.Point(598, 340);
            this.btsaveimage.Name = "btsaveimage";
            this.btsaveimage.Size = new System.Drawing.Size(128, 23);
            this.btsaveimage.TabIndex = 14;
            this.btsaveimage.Text = "save image";
            this.btsaveimage.UseVisualStyleBackColor = true;
            this.btsaveimage.Click += new System.EventHandler(this.btsaveimage_Click);
            // 
            // tbimage
            // 
            this.tbimage.Location = new System.Drawing.Point(465, 301);
            this.tbimage.Name = "tbimage";
            this.tbimage.Size = new System.Drawing.Size(100, 20);
            this.tbimage.TabIndex = 15;
            this.tbimage.TextChanged += new System.EventHandler(this.tbimage_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(259, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 115);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Retrieve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbimage);
            this.Controls.Add(this.btsaveimage);
            this.Controls.Add(this.btselectimage);
            this.Controls.Add(this.btfetch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbsalary);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btdisplay);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btsave);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btdisplay;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbsalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database1DataSet3BindingSource;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.Button btfetch;
        private System.Windows.Forms.Button btselectimage;
        private System.Windows.Forms.Button btsaveimage;
        private System.Windows.Forms.TextBox tbimage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}