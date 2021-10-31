using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
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


        public List<ClienteTestBE> ExcelToList(string pFilename)
        {
            try
            {
                List<ClienteTestBE> lst = new List<ClienteTestBE>();
                XSSFWorkbook hssfwb;

                using (FileStream file = new FileStream(pFilename, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new XSSFWorkbook(file);
                }

                ISheet sheet = hssfwb.GetSheet("Hoja1");
                for (int row = 3; row <= sheet.LastRowNum; row++)
                {
                    if (sheet.GetRow(row) != null) //null is when the row only contains empty cells 
                    {
                            ClienteTestBE clienteTestBE = new ClienteTestBE()
                            {
                                CodClienteN = Convert.ToInt32(sheet.GetRow(row).GetCell(2).NumericCellValue),
                                NomCliente = Convert.ToString(sheet.GetRow(row).GetCell(3).StringCellValue),
                                CodRegistroN = null,
                                DesDireccion = Convert.ToString(sheet.GetRow(row).GetCell(4).StringCellValue),
                                CodEstadoN = 2
                            };

                        lst.Add(clienteTestBE);
                        Console.WriteLine(clienteTestBE.ToString());
                        // MessageBox.Show(string.Format("Row {0} = {1}", row, sheet.GetRow(row).GetCell(0).StringCellValue));
                    }
                }
                return lst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LoadFromExcel(string pFilename, string pCodUsuarioV)
        {
            try
            {
                List<ClienteTestBE> lst = ExcelToList(pFilename);
                foreach (var item in lst)
                {
                    Insertar(item, pCodUsuarioV, null);
                }
                    

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
