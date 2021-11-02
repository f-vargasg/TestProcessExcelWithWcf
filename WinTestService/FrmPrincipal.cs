using System;
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
/*
 * 
 * Esta version y documentación leída, estandarice lo sigiuente
 * 
 * fname .- solo el nombre de un archivo (ie. datos.xlsx, docum.docx, datos.dat, etc.
 * 
 * path.- Solo un Path (ie 
 * C:\Users\garfi\Documents\Trash
 * C:\Users\garfi\Pictures\AppImages
 * etc.)
 * 
 * 
 * pathFname .- el nombre mas un path (ie. 
 * C:\Users\garfi\Documents\Trash\ArchSubir\ArchivoCargarDatosCltes.xlsx
 * C:\Users\garfi\Documents\Trash\ArchSubir\CorreccionConexionRed.docx
 * etc.)
 * 
 * */
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

        #region Operaciones Generales
        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = ConfigurationManager.AppSettings["formCaption"];

            this.ucPrimVersTransfFile.TxtPathFname.Text = ConfigurationManager.AppSettings["fname"];
            this.ucPrimVersTransfFile.TxtDownloadPath.Text = ConfigurationManager.AppSettings["downloadPath"];
            this.ucPrimVersTransfFile.ButBrowseFiles.Click += ButBrowseFiles_Click;
            this.ucPrimVersTransfFile.ButUpload.Click += ButUpload_Click;
            this.ucPrimVersTransfFile.ButStoreDb.Click += ButStoreDb_Click;
            this.ucPrimVersTransfFile.ButDownload.Click += ButDownload_Click;
        }

        private string GetFilePath(string pOldFilePath)
        {
            string res = string.Empty;
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "docx files (*.docx)|*.docx|doc files (*.doc)|*.doc|xlsx files (*.xlsx)|*.xlsx|xls files (*.xls)|*.xls|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                res = pOldFilePath;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    res = openFileDialog.FileName;
                }
            }
            return res;
        }

        #endregion

        #region Eventos Componentes Primera Version
        
        private void ButDownload_Click(object sender, EventArgs e)
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

        private void ButStoreDb_Click(object sender, EventArgs e)
        {
            try
            {
                MyServiceTranferFilesClient client = new MyServiceTranferFilesClient();
                string realServerFfname = lastFileUploaded.NameStored;
                client.StoreToDb(realServerFfname);
                string msgExito = string.Format("Archivo {0} cargado exitosamente !!!", realServerFfname);
                MessageBox.Show(msgExito);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButUpload_Click(object sender, EventArgs e)
        {
            try
            {
                MyServiceTranferFilesClient client = new MyServiceTranferFilesClient();
                string pathFname = ucPrimVersTransfFile.TxtPathFname.Text;
                FileStream fsSource = new FileStream(pathFname, FileMode.Open,
                                                     FileAccess.Read);
                this.lastFileUploaded.NameStored = client.Upload(fsSource);
                this.lastFileUploaded.RealExtension = Path.GetExtension(pathFname);

                MessageBox.Show("Archivo Subido correctamente ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButBrowseFiles_Click(object sender, EventArgs e)
        {
            string currentFilePath = ucPrimVersTransfFile.TxtPathFname.Text;
            ucPrimVersTransfFile.TxtPathFname.Text = GetFilePath(currentFilePath);
        }

        #endregion

        #region Eventos Componente Segunda Version

        #endregion

        #region Eventos Generales
        private void tlsStrExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion


    }
}
