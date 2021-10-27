using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLoadExcel.BE;

namespace TestLoadExcel.DL
{
    public class ClienteTestDL : DataWorker
    {
        public void Insertar(ClienteTestBE pParams, string pCodUsuarioRegV, int? pNumVersion)
        {
            try
            {
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateStoredProcCommand("CL_PCLIENTETEST.Inserta", connection))
                    {
                        #region Parameters
                        DbParameter param = database.CreateParameter("pCOD_CLIENTE_N", DbType.Decimal, null);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pNOM_CLIENTE", DbType.String, pParams.NomCliente);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pDES_DIRECCION", DbType.String, pParams.DesDireccion);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pCOD_ESTADO_N", DbType.Int32, pParams.CodEstadoN);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pCOD_REGISTRO_N", DbType.Decimal, null);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pCOD_USUARIOREG_V", DbType.String, pCodUsuarioRegV);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("PNUM_VERSION", DbType.Int32, pNumVersion);
                        command.Parameters.Add(param);

                        #endregion
                        command.ExecuteNonQuery();
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
