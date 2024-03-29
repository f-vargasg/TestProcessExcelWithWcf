﻿using System;
using System.Configuration;
using System.IO;
using System.Security.Principal;
using TestLoadExcel.BL;

namespace TestProcessExcelWithWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MyServiceTranferFiles : IMyServiceTranferFiles
    {

        // string path = @"c:\path";
        string path = string.Empty;

        public Stream Download(String file)
        {
            MemoryStream stream = new MemoryStream();

            var bytes = File.ReadAllBytes(file);
            stream.Write(bytes, 0, bytes.Length);
            stream.Position = 0;
            return stream;
        }

        public string Upload(Stream input)
        {
            path = ConfigurationManager.AppSettings["uploadPath"];
            string filename = String.Format(@"{0}\{1}.dat", path, Guid.NewGuid().ToString());
            using (var fname = File.Create(filename))
            {
                input.CopyTo(fname);
            }
            return filename;
        }

        public bool StoreToDb(string filename)
        {
            ClienteTestBL clienteTestBL = new ClienteTestBL();
            bool res = true;

            try
            {
                string usuario = WindowsIdentity.GetCurrent().Name;
                clienteTestBL.LoadFromExcel(filename, usuario);
            }
            catch (Exception ex)
            {
                string msgErr = ex.Message;
                res = false;
            }
            return res;
        }

        


    }
}
