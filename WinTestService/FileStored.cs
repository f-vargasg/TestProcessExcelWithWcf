using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTestService
{
    public class FileStored
    {
        public string PathFnameInServer { get; set; }     // full name in the server
        public string RealExtension { get; set; }

        public string RealFname ()
        {
            string res = string.Empty;
            res = Path.GetFileNameWithoutExtension(this.PathFnameInServer);
            res += "." + this.RealExtension;
            return res;
        }
    }
}
