namespace WinTestService
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.butUpload = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.butDownload = new System.Windows.Forms.Button();
            this.butBrowseFiles = new System.Windows.Forms.Button();
            this.txtDownloadPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsStrExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.butStoreDb = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butUpload
            // 
            this.butUpload.Location = new System.Drawing.Point(14, 187);
            this.butUpload.Name = "butUpload";
            this.butUpload.Size = new System.Drawing.Size(118, 28);
            this.butUpload.TabIndex = 0;
            this.butUpload.Text = "UpLoad";
            this.butUpload.UseVisualStyleBackColor = true;
            this.butUpload.Click += new System.EventHandler(this.butUpload_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(2, 68);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(550, 22);
            this.txtFname.TabIndex = 1;
            // 
            // butDownload
            // 
            this.butDownload.Location = new System.Drawing.Point(309, 187);
            this.butDownload.Name = "butDownload";
            this.butDownload.Size = new System.Drawing.Size(118, 28);
            this.butDownload.TabIndex = 2;
            this.butDownload.Text = "Download";
            this.butDownload.UseVisualStyleBackColor = true;
            this.butDownload.Click += new System.EventHandler(this.butDownload_Click);
            // 
            // butBrowseFiles
            // 
            this.butBrowseFiles.Location = new System.Drawing.Point(419, 96);
            this.butBrowseFiles.Name = "butBrowseFiles";
            this.butBrowseFiles.Size = new System.Drawing.Size(118, 28);
            this.butBrowseFiles.TabIndex = 3;
            this.butBrowseFiles.Text = "Browse";
            this.butBrowseFiles.UseVisualStyleBackColor = true;
            this.butBrowseFiles.Click += new System.EventHandler(this.butBrowseFiles_Click);
            // 
            // txtDownloadPath
            // 
            this.txtDownloadPath.Location = new System.Drawing.Point(2, 148);
            this.txtDownloadPath.Name = "txtDownloadPath";
            this.txtDownloadPath.Size = new System.Drawing.Size(550, 22);
            this.txtDownloadPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Archivo Subir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruta Descargue (Download):";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsStrExit,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(549, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsStrExit
            // 
            this.tlsStrExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsStrExit.Image = ((System.Drawing.Image)(resources.GetObject("tlsStrExit.Image")));
            this.tlsStrExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStrExit.Name = "tlsStrExit";
            this.tlsStrExit.Size = new System.Drawing.Size(23, 22);
            this.tlsStrExit.Text = "toolStripButton1";
            this.tlsStrExit.ToolTipText = "Salir";
            this.tlsStrExit.Click += new System.EventHandler(this.tlsStrExit_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Test";
            // 
            // butStoreDb
            // 
            this.butStoreDb.Location = new System.Drawing.Point(159, 187);
            this.butStoreDb.Name = "butStoreDb";
            this.butStoreDb.Size = new System.Drawing.Size(118, 28);
            this.butStoreDb.TabIndex = 8;
            this.butStoreDb.Text = "Save To DB";
            this.butStoreDb.UseVisualStyleBackColor = true;
            this.butStoreDb.Click += new System.EventHandler(this.butStoreDb_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 249);
            this.Controls.Add(this.butStoreDb);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDownloadPath);
            this.Controls.Add(this.butBrowseFiles);
            this.Controls.Add(this.butDownload);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.butUpload);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butUpload;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button butDownload;
        private System.Windows.Forms.Button butBrowseFiles;
        private System.Windows.Forms.TextBox txtDownloadPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsStrExit;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button butStoreDb;
    }
}

