using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestLoadExcel.WcfTransferFiles
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.

    /*
     * Esta versión permite pasar varios parametros en el Upload, el resumen de cómo se hace
     * es pasarlo como una entidad
     * */
    public class TransferService : ITransferService
    {
        public RemoteFileInfo DownloadFile(DownloadRequest request)
        {
            RemoteFileInfo result = new RemoteFileInfo();
            try
            {
                string filePath = Path.Combine(ConfigurationManager.AppSettings["uploadPath"], request.FileName);
                FileInfo fileInfo = new FileInfo(filePath);

                // check if exists
                if (!fileInfo.Exists)
                    throw new FileNotFoundException("File not found", request.FileName);

                // open stream
                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                // return result 
                result.FileName = request.FileName;
                result.Length = fileInfo.Length;
                result.FileByteStream = stream;
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public void UploadFile(RemoteFileInfo request)
        {
            Stream sourceStream = request.FileByteStream;

            string uploadFolder = ConfigurationManager.AppSettings["uploadPath"]; ;

            string filePath = Path.Combine(uploadFolder, request.FileName);

            using (var fname = File.Create(filePath))
            {
                sourceStream.CopyTo(fname);
            }
        }
    }
}
