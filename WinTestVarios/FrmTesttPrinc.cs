using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLoadExcel.BE;
using TestLoadExcel.BL;

namespace WinTestVarios
{
    public partial class FrmTesttPrinc : Form
    {
        public FrmTesttPrinc()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = ConfigurationManager.AppSettings["formCaption"];
            txtFname.Text = ConfigurationManager.AppSettings["fname"];
                 
        }

        private void tlsStrpExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tlsStrpDoTest_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteTestBL clienteTestBL = new ClienteTestBL();

                List<ClienteTestBE> lst =   clienteTestBL.ExcelToList(txtFname.Text);
                var source = new BindingSource();
                source.DataSource = lst;
                dgrData.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
