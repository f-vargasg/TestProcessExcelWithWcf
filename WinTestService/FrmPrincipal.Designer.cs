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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsStrExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tblServices = new System.Windows.Forms.TabControl();
            this.tbPgPrimVersion = new System.Windows.Forms.TabPage();
            this.ucPrimVersTransfFile = new WinTestService.UCTransferFiles();
            this.tbPgSegVersion = new System.Windows.Forms.TabPage();
            this.ucSegVersTransfFile = new WinTestService.UCTransferFiles();
            this.toolStrip1.SuspendLayout();
            this.tblServices.SuspendLayout();
            this.tbPgPrimVersion.SuspendLayout();
            this.tbPgSegVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsStrExit,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(919, 25);
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
            // tblServices
            // 
            this.tblServices.Controls.Add(this.tbPgPrimVersion);
            this.tblServices.Controls.Add(this.tbPgSegVersion);
            this.tblServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblServices.Location = new System.Drawing.Point(0, 25);
            this.tblServices.Name = "tblServices";
            this.tblServices.SelectedIndex = 0;
            this.tblServices.Size = new System.Drawing.Size(919, 454);
            this.tblServices.TabIndex = 8;
            // 
            // tbPgPrimVersion
            // 
            this.tbPgPrimVersion.Controls.Add(this.ucPrimVersTransfFile);
            this.tbPgPrimVersion.Location = new System.Drawing.Point(4, 25);
            this.tbPgPrimVersion.Name = "tbPgPrimVersion";
            this.tbPgPrimVersion.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgPrimVersion.Size = new System.Drawing.Size(911, 425);
            this.tbPgPrimVersion.TabIndex = 0;
            this.tbPgPrimVersion.Text = "Primera Versión";
            this.tbPgPrimVersion.UseVisualStyleBackColor = true;
            // 
            // ucPrimVersTransfFile
            // 
            this.ucPrimVersTransfFile.Location = new System.Drawing.Point(0, 0);
            this.ucPrimVersTransfFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucPrimVersTransfFile.Name = "ucPrimVersTransfFile";
            this.ucPrimVersTransfFile.Size = new System.Drawing.Size(776, 289);
            this.ucPrimVersTransfFile.TabIndex = 0;
            // 
            // tbPgSegVersion
            // 
            this.tbPgSegVersion.Controls.Add(this.ucSegVersTransfFile);
            this.tbPgSegVersion.Location = new System.Drawing.Point(4, 25);
            this.tbPgSegVersion.Name = "tbPgSegVersion";
            this.tbPgSegVersion.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgSegVersion.Size = new System.Drawing.Size(911, 425);
            this.tbPgSegVersion.TabIndex = 1;
            this.tbPgSegVersion.Text = "Segunda Versión";
            this.tbPgSegVersion.UseVisualStyleBackColor = true;
            // 
            // ucSegVersTransfFile
            // 
            this.ucSegVersTransfFile.Location = new System.Drawing.Point(0, 0);
            this.ucSegVersTransfFile.Margin = new System.Windows.Forms.Padding(5);
            this.ucSegVersTransfFile.Name = "ucSegVersTransfFile";
            this.ucSegVersTransfFile.Size = new System.Drawing.Size(865, 328);
            this.ucSegVersTransfFile.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 479);
            this.Controls.Add(this.tblServices);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tblServices.ResumeLayout(false);
            this.tbPgPrimVersion.ResumeLayout(false);
            this.tbPgSegVersion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsStrExit;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TabControl tblServices;
        private System.Windows.Forms.TabPage tbPgPrimVersion;
        private UCTransferFiles ucPrimVersTransfFile;
        private System.Windows.Forms.TabPage tbPgSegVersion;
        private UCTransferFiles ucSegVersTransfFile;
    }
}

