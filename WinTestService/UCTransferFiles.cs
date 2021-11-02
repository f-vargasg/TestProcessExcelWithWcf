using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestService
{
    public partial class UCTransferFiles : UserControl
    {

        public TextBox TxtPathFname
        {
            get { return txtPathFname; }

        }

        public Button ButBrowseFiles
        {
            get { return butBrowseFiles; }
        }

        public TextBox TxtDownloadPath
        {
            get { return txtDownloadPath; }
        }

        public Button ButUpload
        {
            get { return butUpload; }
        }

        public Button ButStoreDb
        {
            get { return butStoreDb; }
        }

        public Button ButDownload
        {
            get { return butDownload; }
        }

        public UCTransferFiles()
        {
            InitializeComponent();
        }
    }
}
