using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestProcessExcelWithWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMyServiceTranferFiles
    {

        [OperationContract]
        Stream Download(String file);
        
        [OperationContract]
        string Upload(Stream input);
        [OperationContract]
        bool StoreToDb(string filename);


    }

}
