using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfTransferFiles
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITransferFileService
    {

        [OperationContract]
        RemoteFileInfo DownloadFile(DownloadRequest request);

        [OperationContract]
        void UploadFile(RemoteFileInfo request);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.


    [DataContract]
    public class DownloadRequest
    {
        private string filename;

        [DataMember]
        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }
    }

    [DataContract]
    public class RemoteFileInfo : IDisposable
    {
        private string filename;

        [DataMember]
        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }

        private long length;

        [DataMember]
        public long Length
        {
            get { return length; }
            set { length = value; }
        }

        private Stream fileByteStream;

        [DataMember]
        public Stream FileByteStream
        {
            get { return fileByteStream; }
            set { fileByteStream = value; }
        }

        public void Dispose()
        {
            if (FileByteStream != null)
            {
                FileByteStream.Close();
                FileByteStream = null;
            }
        }
    }
    
}
