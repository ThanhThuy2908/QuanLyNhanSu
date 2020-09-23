namespace QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.butThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.butQuanLyLuong = new DevExpress.XtraEditors.SimpleButton();
            this.butQuanLyDanhMuc = new DevExpress.XtraEditors.SimpleButton();
            this.butQuanLyNV = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.splitContainer1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 30);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1271, 686);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.butThoat);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.butQuanLyLuong);
            this.splitContainer1.Panel1.Controls.Add(this.butQuanLyDanhMuc);
            this.splitContainer1.Panel1.Controls.Add(this.butQuanLyNV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1271, 686);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 1;
            // 
            // butThoat
            // 
            this.butThoat.ImageOptions.Image = global::QuanLyNhanVien.Properties.Resources.close_32x32;
            this.butThoat.Location = new System.Drawing.Point(12, 465);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(210, 76);
            this.butThoat.TabIndex = 5;
            this.butThoat.Text = "Thoát";
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(208, 66);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "CHỨC NĂNG QUẢN LÝ";
            // 
            // butQuanLyLuong
            // 
            this.butQuanLyLuong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("butQuanLyLuong.ImageOptions.Image")));
            this.butQuanLyLuong.Location = new System.Drawing.Point(12, 363);
            this.butQuanLyLuong.Name = "butQuanLyLuong";
            this.butQuanLyLuong.Size = new System.Drawing.Size(210, 76);
            this.butQuanLyLuong.TabIndex = 3;
            this.butQuanLyLuong.Text = "Quản Lý Lương";
            this.butQuanLyLuong.Click += new System.EventHandler(this.butQuanLyLuong_Click);
            // 
            // butQuanLyDanhMuc
            // 
            this.butQuanLyDanhMuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("butQuanLyDanhMuc.ImageOptions.Image")));
            this.butQuanLyDanhMuc.Location = new System.Drawing.Point(13, 138);
            this.butQuanLyDanhMuc.Name = "butQuanLyDanhMuc";
            this.butQuanLyDanhMuc.Size = new System.Drawing.Size(210, 76);
            this.butQuanLyDanhMuc.TabIndex = 1;
            this.butQuanLyDanhMuc.Text = "Quản Lý Danh Mục";
            this.butQuanLyDanhMuc.Click += new System.EventHandler(this.butQuanLyDanhMuc_Click);
            // 
            // butQuanLyNV
            // 
            this.butQuanLyNV.ImageOptions.SvgImage = global::QuanLyNhanVien.Properties.Resources.bo_department;
            this.butQuanLyNV.Location = new System.Drawing.Point(12, 249);
            this.butQuanLyNV.Name = "butQuanLyNV";
            this.butQuanLyNV.Size = new System.Drawing.Size(210, 76);
            this.butQuanLyNV.TabIndex = 0;
            this.butQuanLyNV.Text = "Quản Lý Nhân Viên";
            this.butQuanLyNV.Click += new System.EventHandler(this.butQuanLyNV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1042, 686);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1271, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 716);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Công ty cổ phần giải pháp Siêu Việt";
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton butQuanLyNV;
        private DevExpress.XtraEditors.SimpleButton butQuanLyLuong;
        private DevExpress.XtraEditors.SimpleButton butQuanLyDanhMuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton butThoat;
    }
}

