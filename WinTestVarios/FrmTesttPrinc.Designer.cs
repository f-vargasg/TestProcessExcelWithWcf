
namespace WinTestVarios
{
    partial class FrmTesttPrinc
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTesttPrinc));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.tlsStrpPrinc = new System.Windows.Forms.ToolStrip();
            this.tlsStrpExit = new System.Windows.Forms.ToolStripButton();
            this.tlsStrpDoTest = new System.Windows.Forms.ToolStripButton();
            this.dgrData = new System.Windows.Forms.DataGridView();
            this.tlsStrpPrinc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File To load:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(128, 38);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(570, 22);
            this.txtFname.TabIndex = 1;
            // 
            // tlsStrpPrinc
            // 
            this.tlsStrpPrinc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsStrpExit,
            this.tlsStrpDoTest});
            this.tlsStrpPrinc.Location = new System.Drawing.Point(0, 0);
            this.tlsStrpPrinc.Name = "tlsStrpPrinc";
            this.tlsStrpPrinc.Size = new System.Drawing.Size(787, 25);
            this.tlsStrpPrinc.TabIndex = 2;
            this.tlsStrpPrinc.Text = "toolStrip1";
            // 
            // tlsStrpExit
            // 
            this.tlsStrpExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsStrpExit.Image = ((System.Drawing.Image)(resources.GetObject("tlsStrpExit.Image")));
            this.tlsStrpExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStrpExit.Name = "tlsStrpExit";
            this.tlsStrpExit.Size = new System.Drawing.Size(23, 22);
            this.tlsStrpExit.Text = "toolStripButton1";
            this.tlsStrpExit.ToolTipText = "Exit";
            this.tlsStrpExit.Click += new System.EventHandler(this.tlsStrpExit_Click);
            // 
            // tlsStrpDoTest
            // 
            this.tlsStrpDoTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsStrpDoTest.Image = ((System.Drawing.Image)(resources.GetObject("tlsStrpDoTest.Image")));
            this.tlsStrpDoTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStrpDoTest.Name = "tlsStrpDoTest";
            this.tlsStrpDoTest.Size = new System.Drawing.Size(23, 22);
            this.tlsStrpDoTest.Text = "toolStripButton2";
            this.tlsStrpDoTest.ToolTipText = "Do Test";
            this.tlsStrpDoTest.Click += new System.EventHandler(this.tlsStrpDoTest_Click);
            // 
            // dgrData
            // 
            this.dgrData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrData.Location = new System.Drawing.Point(0, 105);
            this.dgrData.Name = "dgrData";
            this.dgrData.Size = new System.Drawing.Size(787, 356);
            this.dgrData.TabIndex = 3;
            // 
            // FrmTesttPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 461);
            this.Controls.Add(this.dgrData);
            this.Controls.Add(this.tlsStrpPrinc);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTesttPrinc";
            this.Text = "Form1";
            this.tlsStrpPrinc.ResumeLayout(false);
            this.tlsStrpPrinc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.ToolStrip tlsStrpPrinc;
        private System.Windows.Forms.ToolStripButton tlsStrpExit;
        private System.Windows.Forms.ToolStripButton tlsStrpDoTest;
        private System.Windows.Forms.DataGridView dgrData;
    }
}

