﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinTestService.TransfFilesSrvRef;

namespace WinTestService
{
    public partial class FrmPrincipal : Form
    {

        // string lastFileUploaded;
        FileStored lastFileUploaded = new FileStored();

        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            txtFname.Text = ConfigurationManager.AppSettings["fname"];
            txtDownloadPath.Text = ConfigurationManager.AppSettings["downloadPath"];
        }

        private void butUpload_Click(object sender, EventArgs e)
        {
            try
            {
                MyServiceTranferFilesClient client = new MyServiceTranferFilesClient();
                FileStream fsSource = new FileStream(txtFname.Text, FileMode.Open,
                                                     FileAccess.Read);
                this.lastFileUploaded.NameStored = client.Upload(fsSource);
                this.lastFileUploaded.RealExtension = Path.GetExtension(txtFname.Text);
                MessageBox.Show("Archivo Subido correctamente ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void butDownload_Click(object sender, EventArgs e)
        {
            try
            {
                MyServiceTranferFilesClient client = new MyServiceTranferFilesClient();
                var stream = client.Download(this.lastFileUploaded.NameStored);
                var realFname = Path.Combine(ConfigurationManager.AppSettings["downloadPath"], this.lastFileUploaded.RealFname());
                using (FileStream outputFs = new FileStream(realFname, FileMode.Create))
                {
                    stream.CopyTo(outputFs);
                }
                MessageBox.Show("Archivo Bajado correctamente ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}