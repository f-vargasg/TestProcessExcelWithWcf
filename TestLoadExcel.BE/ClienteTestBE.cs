using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLoadExcel.BE
{
    public class ClienteTestBE
    {
        public int CodClienteN { get; set; }
        public string NomCliente { get; set; }
        public string DesDireccion { get; set; }
        public int CodEstadoN { get; set; }
        public decimal? CodRegistroN { get; set; }

        public override string ToString()
        {
            return "[CodCliente: " + CodClienteN.ToString() + " - " +
                     "NomCliente: " + NomCliente + " - " +
                     "DesDireccion: " + DesDireccion + " - " +
                     "CodEstadoN: " + CodEstadoN.ToString() + " - " +
                     "CodRegistro " + (CodRegistroN == null ? "null"  : CodRegistroN.ToString());
        }
    }
}
