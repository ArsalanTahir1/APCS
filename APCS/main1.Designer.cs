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
            this.btnconvert = new System.Windows.Forms.Button();
            this.imgboxstart = new Emgu.CV.UI.ImageBox();
            this.test_loginDataSet = new APCS.test_loginDataSet();
            this.testloginDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPCSDataSet = new APCS.APCSDataSet();
            this.picturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picturesTableAdapter = new APCS.APCSDataSetTableAdapters.picturesTableAdapter();
            this.picturesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aPCSDataSet1 = new APCS.APCSDataSet1();
            this.picturesTableAdapter1 = new APCS.APCSDataSet1TableAdapters.picturesTableAdapter();
            this.pnlsms = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.txtapi = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnsaveimage = new System.Windows.Forms.Button();
            this.btncapture = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.txtconvert = new System.Windows.Forms.TextBox();
            this.picboxselect = new System.Windows.Forms.PictureBox();
            this.captureimgbox = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxaft = new System.Windows.Forms.PictureBox();
            this.btnconvertimg = new System.Windows.Forms.Button();
            this.txtboxnum = new System.Windows.Forms.TextBox();
            this.btnconvertnum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testloginDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPCSDataSet1)).BeginInit();
            this.pnlsms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureimgbox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxaft)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(679, 685);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(10, 26);
            this.btnconvert.TabIndex = 6;
            this.btnconvert.Text = "Covert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Visible = false;
            this.btnconvert.Click += new System.EventHandler(this.btnshowimage_Click);
            // 
            // imgboxstart
            // 
            this.imgboxstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))));
            this.imgboxstart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgboxstart.Location = new System.Drawing.Point(9, 12);
            this.imgboxstart.Name = "imgboxstart";
            this.imgboxstart.Size = new System.Drawing.Size(323, 244);
            this.imgboxstart.TabIndex = 2;
            this.imgboxstart.TabStop = false;
            this.imgboxstart.Click += new System.EventHandler(this.imgboxstart_Click);
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
            // pnlsms
            // 
            this.pnlsms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlsms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlsms.Controls.Add(this.label1);
            this.pnlsms.Controls.Add(this.btnsend);
            this.pnlsms.Controls.Add(this.txtapi);
            this.pnlsms.Controls.Add(this.label34);
            this.pnlsms.Location = new System.Drawing.Point(787, 276);
            this.pnlsms.Name = "pnlsms";
            this.pnlsms.Size = new System.Drawing.Size(517, 255);
            this.pnlsms.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "SMS PANEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnsend
            // 
            this.btnsend.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(288, 152);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 29);
            this.btnsend.TabIndex = 7;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // txtapi
            // 
            this.txtapi.Location = new System.Drawing.Point(200, 85);
            this.txtapi.Name = "txtapi";
            this.txtapi.Size = new System.Drawing.Size(216, 20);
            this.txtapi.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(71, 86);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(123, 15);
            this.label34.TabIndex = 0;
            this.label34.Text = "MOBILE NUMBER";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 63);
            this.label2.TabIndex = 18;
            this.label2.Text = "APCS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 711);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(1354, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 725);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(12, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1355, 15);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Location = new System.Drawing.Point(12, 698);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1355, 15);
            this.panel5.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Location = new System.Drawing.Point(747, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 613);
            this.panel6.TabIndex = 23;
            // 
            // btnsaveimage
            // 
            this.btnsaveimage.Location = new System.Drawing.Point(404, 345);
            this.btnsaveimage.Name = "btnsaveimage";
            this.btnsaveimage.Size = new System.Drawing.Size(96, 37);
            this.btnsaveimage.TabIndex = 5;
            this.btnsaveimage.Text = "Save Image";
            this.btnsaveimage.UseVisualStyleBackColor = true;
            this.btnsaveimage.Click += new System.EventHandler(this.btnsaveimage_Click);
            // 
            // btncapture
            // 
            this.btncapture.Location = new System.Drawing.Point(244, 343);
            this.btncapture.Name = "btncapture";
            this.btncapture.Size = new System.Drawing.Size(96, 37);
            this.btncapture.TabIndex = 2;
            this.btncapture.Text = "Capture";
            this.btncapture.UseVisualStyleBackColor = true;
            this.btncapture.Click += new System.EventHandler(this.btncapture_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(563, 348);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(98, 34);
            this.btnselect.TabIndex = 12;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // txtconvert
            // 
            this.txtconvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtconvert.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtconvert.Location = new System.Drawing.Point(909, 586);
            this.txtconvert.Multiline = true;
            this.txtconvert.Name = "txtconvert";
            this.txtconvert.Size = new System.Drawing.Size(323, 94);
            this.txtconvert.TabIndex = 13;
            // 
            // picboxselect
            // 
            this.picboxselect.BackColor = System.Drawing.Color.Transparent;
            this.picboxselect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxselect.Location = new System.Drawing.Point(46, 393);
            this.picboxselect.Name = "picboxselect";
            this.picboxselect.Size = new System.Drawing.Size(323, 244);
            this.picboxselect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxselect.TabIndex = 11;
            this.picboxselect.TabStop = false;
            this.picboxselect.Click += new System.EventHandler(this.picboxselect_Click);
            this.picboxselect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picboxselect_MouseDown);
            this.picboxselect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picboxselect_MouseMove);
            this.picboxselect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picboxselect_MouseUp);
            // 
            // captureimgbox
            // 
            this.captureimgbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.captureimgbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.captureimgbox.Location = new System.Drawing.Point(382, 93);
            this.captureimgbox.Name = "captureimgbox";
            this.captureimgbox.Size = new System.Drawing.Size(323, 244);
            this.captureimgbox.TabIndex = 7;
            this.captureimgbox.TabStop = false;
            this.captureimgbox.Click += new System.EventHandler(this.captureimgbox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.imgboxstart);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(33, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 609);
            this.panel1.TabIndex = 17;
            // 
            // picBoxaft
            // 
            this.picBoxaft.BackColor = System.Drawing.Color.Transparent;
            this.picBoxaft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxaft.Location = new System.Drawing.Point(383, 393);
            this.picBoxaft.Name = "picBoxaft";
            this.picBoxaft.Size = new System.Drawing.Size(323, 244);
            this.picBoxaft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxaft.TabIndex = 14;
            this.picBoxaft.TabStop = false;
            // 
            // btnconvertimg
            // 
            this.btnconvertimg.Location = new System.Drawing.Point(568, 645);
            this.btnconvertimg.Name = "btnconvertimg";
            this.btnconvertimg.Size = new System.Drawing.Size(85, 37);
            this.btnconvertimg.TabIndex = 25;
            this.btnconvertimg.Text = "Covert Image OCR";
            this.btnconvertimg.UseVisualStyleBackColor = true;
            this.btnconvertimg.Click += new System.EventHandler(this.btnconvertimg_Click_1);
            // 
            // txtboxnum
            // 
            this.txtboxnum.Location = new System.Drawing.Point(981, 117);
            this.txtboxnum.Name = "txtboxnum";
            this.txtboxnum.Size = new System.Drawing.Size(236, 20);
            this.txtboxnum.TabIndex = 26;
            // 
            // btnconvertnum
            // 
            this.btnconvertnum.Location = new System.Drawing.Point(1058, 166);
            this.btnconvertnum.Name = "btnconvertnum";
            this.btnconvertnum.Size = new System.Drawing.Size(75, 32);
            this.btnconvertnum.TabIndex = 27;
            this.btnconvertnum.Text = "Convert";
            this.btnconvertnum.UseVisualStyleBackColor = true;
            this.btnconvertnum.Click += new System.EventHandler(this.btnconvertnum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(850, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Enter NO. Plate :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "Covert Image Tesserect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 712);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnconvertnum);
            this.Controls.Add(this.txtboxnum);
            this.Controls.Add(this.btnconvertimg);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlsms);
            this.Controls.Add(this.captureimgbox);
            this.Controls.Add(this.btncapture);
            this.Controls.Add(this.btnsaveimage);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.picboxselect);
            this.Controls.Add(this.picBoxaft);
            this.Controls.Add(this.txtconvert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnconvert);
            this.Name = "main1";
            this.Text = "camera";
            this.Load += new System.EventHandler(this.main1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgboxstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testloginDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPCSDataSet1)).EndInit();
            this.pnlsms.ResumeLayout(false);
            this.pnlsms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureimgbox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxaft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvert;
        private Emgu.CV.UI.ImageBox imgboxstart;
        private test_loginDataSet test_loginDataSet;
        private System.Windows.Forms.BindingSource testloginDataSetBindingSource;
        private APCSDataSet aPCSDataSet;
        private System.Windows.Forms.BindingSource picturesBindingSource;
        private APCSDataSetTableAdapters.picturesTableAdapter picturesTableAdapter;
        private APCSDataSet1 aPCSDataSet1;
        private System.Windows.Forms.BindingSource picturesBindingSource1;
        private APCSDataSet1TableAdapters.picturesTableAdapter picturesTableAdapter1;
        private System.Windows.Forms.Panel pnlsms;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox txtapi;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnsaveimage;
        private System.Windows.Forms.Button btncapture;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox txtconvert;
        private System.Windows.Forms.PictureBox picboxselect;
        private Emgu.CV.UI.ImageBox captureimgbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxaft;
        private System.Windows.Forms.Button btnconvertimg;
        private System.Windows.Forms.TextBox txtboxnum;
        private System.Windows.Forms.Button btnconvertnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;

    }
}