using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLoadExcel.BE;
using TestLoadExcel.DL;

namespace TestLoadExcel.BL
{
    public class ClienteTestBL
    {
        ClienteTestDL clienteTestDL;

        public ClienteTestBL()
        {
            this.clienteTestDL = new ClienteTestDL();
        }
        public void Insertar(ClienteTestBE pParams, string pCodUsuarioRegV, int? pNumVersion)
        {
            try
            {
                this.clienteTestDL.Insertar(pParams, pCodUsuarioRegV, pNumVersion);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void LoadExcel(string pFilename, string pCodUsuarioV)
        {
            try
            {
                HSSFWorkbook hssfwb;
                using (FileStream file = new FileStream(pFilename, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new HSSFWorkbook(file);
                }

                ISheet sheet = hssfwb.GetSheet("Hoja1");
                for (int row = 4; row <= sheet.LastRowNum; row++)
                {
                    if (sheet.GetRow(row) != null) //null is when the row only contains empty cells 
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            ClienteTestBE clienteTestBE = new ClienteTestBE()
                            {
                                CodClienteN = Convert.ToInt32(sheet.GetRow(row).GetCell(0).StringCellValue),
                                NomCliente = Convert.ToString(sheet.GetRow(row).GetCell(1).StringCellValue),
                                CodRegistroN = null,
                                DesDireccion = Convert.ToString(sheet.GetRow(row).GetCell(2).StringCellValue)
                            };
                            Insertar(clienteTestBE, pCodUsuarioV, null);
                        }
                        // MessageBox.Show(string.Format("Row {0} = {1}", row, sheet.GetRow(row).GetCell(0).StringCellValue));
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
