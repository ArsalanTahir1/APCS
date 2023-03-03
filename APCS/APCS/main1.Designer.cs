namespace APCS
{
    partial class main1
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
            this.btncapture = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnsaveimage = new System.Windows.Forms.Button();
            this.btnshowimage = new System.Windows.Forms.Button();
            this.imgboxstart = new Emgu.CV.UI.ImageBox();
            this.captureimgbox = new Emgu.CV.UI.ImageBox();
            this.test_loginDataSet = new APCS.test_loginDataSet();
            this.testloginDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPCSDataSet = new APCS.APCSDataSet();
            this.picturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picturesTableAdapter = new APCS.APCSDataSetTableAdapters.picturesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.picturesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aPCSDataSet1 = new APCS.APCSDataSet1();
            this.picturesTableAdapter1 = new APCS.APCSDataSet1TableAdapters.picturesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureimgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testloginDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPCSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncapture
            // 
            this.btncapture.Location = new System.Drawing.Point(451, 612);
            this.btncapture.Name = "btncapture";
            this.btncapture.Size = new System.Drawing.Size(96, 37);
            this.btncapture.TabIndex = 2;
            this.btncapture.Text = "Capture";
            this.btncapture.UseVisualStyleBackColor = true;
            this.btncapture.Click += new System.EventHandler(this.btncapture_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(138, 611);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(96, 37);
            this.btnstart.TabIndex = 3;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            // 
            // btnsaveimage
            // 
            this.btnsaveimage.Location = new System.Drawing.Point(557, 612);
            this.btnsaveimage.Name = "btnsaveimage";
            this.btnsaveimage.Size = new System.Drawing.Size(96, 37);
            this.btnsaveimage.TabIndex = 5;
            this.btnsaveimage.Text = "Save Image";
            this.btnsaveimage.UseVisualStyleBackColor = true;
            this.btnsaveimage.Click += new System.EventHandler(this.btnsaveimage_Click);
            // 
            // btnshowimage
            // 
            this.btnshowimage.Location = new System.Drawing.Point(659, 612);
            this.btnshowimage.Name = "btnshowimage";
            this.btnshowimage.Size = new System.Drawing.Size(96, 37);
            this.btnshowimage.TabIndex = 6;
            this.btnshowimage.Text = "Show Image";
            this.btnshowimage.UseVisualStyleBackColor = true;
            this.btnshowimage.Click += new System.EventHandler(this.btnshowimage_Click);
            // 
            // imgboxstart
            // 
            this.imgboxstart.Location = new System.Drawing.Point(9, 13);
            this.imgboxstart.Name = "imgboxstart";
            this.imgboxstart.Size = new System.Drawing.Size(655, 345);
            this.imgboxstart.TabIndex = 2;
            this.imgboxstart.TabStop = false;
            // 
            // captureimgbox
            // 
            this.captureimgbox.Location = new System.Drawing.Point(680, 13);
            this.captureimgbox.Name = "captureimgbox";
            this.captureimgbox.Size = new System.Drawing.Size(655, 345);
            this.captureimgbox.TabIndex = 7;
            this.captureimgbox.TabStop = false;
            // 
            // test_loginDataSet
            // 
            this.test_loginDataSet.DataSetName = "test_loginDataSet";
            this.test_loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testloginDataSetBindingSource
            // 
            this.testloginDataSetBindingSource.DataSource = this.test_loginDataSet;
            this.testloginDataSetBindingSource.Position = 0;
            // 
            // aPCSDataSet
            // 
            this.aPCSDataSet.DataSetName = "APCSDataSet";
            this.aPCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picturesBindingSource
            // 
            this.picturesBindingSource.DataMember = "pictures";
            this.picturesBindingSource.DataSource = this.aPCSDataSet;
            // 
            // picturesTableAdapter
            // 
            this.picturesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.ppictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.picturesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(123, 417);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "p_id";
            this.pidDataGridViewTextBoxColumn.HeaderText = "p_id";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ppictureDataGridViewImageColumn
            // 
            this.ppictureDataGridViewImageColumn.DataPropertyName = "p_picture";
            this.ppictureDataGridViewImageColumn.HeaderText = "p_picture";
            this.ppictureDataGridViewImageColumn.Name = "ppictureDataGridViewImageColumn";
            // 
            // picturesBindingSource1
            // 
            this.picturesBindingSource1.DataMember = "pictures";
            this.picturesBindingSource1.DataSource = this.aPCSDataSet1;
            // 
            // aPCSDataSet1
            // 
            this.aPCSDataSet1.DataSetName = "APCSDataSet1";
            this.aPCSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picturesTableAdapter1
            // 
            this.picturesTableAdapter1.ClearBeforeFill = true;
            // 
            // main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 735);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.captureimgbox);
            this.Controls.Add(this.imgboxstart);
            this.Controls.Add(this.btnshowimage);
            this.Controls.Add(this.btnsaveimage);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btncapture);
            this.Name = "main1";
            this.Text = "camera";
            this.Load += new System.EventHandler(this.main1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgboxstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureimgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testloginDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPCSDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncapture;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnsaveimage;
        private System.Windows.Forms.Button btnshowimage;
        private Emgu.CV.UI.ImageBox imgboxstart;
        private Emgu.CV.UI.ImageBox captureimgbox;
        private test_loginDataSet test_loginDataSet;
        private System.Windows.Forms.BindingSource testloginDataSetBindingSource;
        private APCSDataSet aPCSDataSet;
        private System.Windows.Forms.BindingSource picturesBindingSource;
        private APCSDataSetTableAdapters.picturesTableAdapter picturesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private APCSDataSet1 aPCSDataSet1;
        private System.Windows.Forms.BindingSource picturesBindingSource1;
        private APCSDataSet1TableAdapters.picturesTableAdapter picturesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn ppictureDataGridViewImageColumn;

    }
}