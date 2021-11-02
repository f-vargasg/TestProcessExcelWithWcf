
namespace WinTestService
{
    partial class UCTransferFiles
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTransferFile = new System.Windows.Forms.Panel();
            this.butStoreDb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDownloadPath = new System.Windows.Forms.TextBox();
            this.butBrowseFiles = new System.Windows.Forms.Button();
            this.butDownload = new System.Windows.Forms.Button();
            this.txtPathFname = new System.Windows.Forms.TextBox();
            this.butUpload = new System.Windows.Forms.Button();
            this.pnlTransferFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTransferFile
            // 
            this.pnlTransferFile.Controls.Add(this.butStoreDb);
            this.pnlTransferFile.Controls.Add(this.label2);
            this.pnlTransferFile.Controls.Add(this.label1);
            this.pnlTransferFile.Controls.Add(this.txtDownloadPath);
            this.pnlTransferFile.Controls.Add(this.butBrowseFiles);
            this.pnlTransferFile.Controls.Add(this.butDownload);
            this.pnlTransferFile.Controls.Add(this.txtPathFname);
            this.pnlTransferFile.Controls.Add(this.butUpload);
            this.pnlTransferFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransferFile.Location = new System.Drawing.Point(0, 0);
            this.pnlTransferFile.Name = "pnlTransferFile";
            this.pnlTransferFile.Size = new System.Drawing.Size(564, 214);
            this.pnlTransferFile.TabIndex = 0;
            // 
            // butStoreDb
            // 
            this.butStoreDb.Location = new System.Drawing.Point(164, 154);
            this.butStoreDb.Name = "butStoreDb";
            this.butStoreDb.Size = new System.Drawing.Size(118, 28);
            this.butStoreDb.TabIndex = 16;
            this.butStoreDb.Text = "Save To DB";
            this.butStoreDb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ruta Descargue (Download):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Archivo Subir";
            // 
            // txtDownloadPath
            // 
            this.txtDownloadPath.Location = new System.Drawing.Point(7, 115);
            this.txtDownloadPath.Name = "txtDownloadPath";
            this.txtDownloadPath.Size = new System.Drawing.Size(550, 20);
            this.txtDownloadPath.TabIndex = 13;
            // 
            // butBrowseFiles
            // 
            this.butBrowseFiles.Location = new System.Drawing.Point(424, 63);
            this.butBrowseFiles.Name = "butBrowseFiles";
            this.butBrowseFiles.Size = new System.Drawing.Size(118, 28);
            this.butBrowseFiles.TabIndex = 12;
            this.butBrowseFiles.Text = "Browse";
            this.butBrowseFiles.UseVisualStyleBackColor = true;
            // 
            // butDownload
            // 
            this.butDownload.Location = new System.Drawing.Point(314, 154);
            this.butDownload.Name = "butDownload";
            this.butDownload.Size = new System.Drawing.Size(118, 28);
            this.butDownload.TabIndex = 11;
            this.butDownload.Text = "Download";
            this.butDownload.UseVisualStyleBackColor = true;
            // 
            // txtPathFname
            // 
            this.txtPathFname.Location = new System.Drawing.Point(7, 35);
            this.txtPathFname.Name = "txtPathFname";
            this.txtPathFname.Size = new System.Drawing.Size(550, 20);
            this.txtPathFname.TabIndex = 10;
            // 
            // butUpload
            // 
            this.butUpload.Location = new System.Drawing.Point(19, 154);
            this.butUpload.Name = "butUpload";
            this.butUpload.Size = new System.Drawing.Size(118, 28);
            this.butUpload.TabIndex = 9;
            this.butUpload.Text = "UpLoad";
            this.butUpload.UseVisualStyleBackColor = true;
            // 
            // UCTransferFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTransferFile);
            this.Name = "UCTransferFiles";
            this.Size = new System.Drawing.Size(564, 214);
            this.pnlTransferFile.ResumeLayout(false);
            this.pnlTransferFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTransferFile;
        private System.Windows.Forms.Button butStoreDb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDownloadPath;
        private System.Windows.Forms.Button butBrowseFiles;
        private System.Windows.Forms.Button butDownload;
        private System.Windows.Forms.TextBox txtPathFname;
        private System.Windows.Forms.Button butUpload;
    }
}
