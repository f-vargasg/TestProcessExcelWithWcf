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
            this.butUpload = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.butDownload = new System.Windows.Forms.Button();
            this.butBrowseFiles = new System.Windows.Forms.Button();
            this.txtDownloadPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.butDownload.Location = new System.Drawing.Point(154, 187);
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 249);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDownloadPath);
            this.Controls.Add(this.butBrowseFiles);
            this.Controls.Add(this.butDownload);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.butUpload);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
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
    }
}

