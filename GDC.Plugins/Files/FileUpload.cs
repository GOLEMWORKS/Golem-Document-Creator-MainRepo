using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDC.Plugins.Files
{
    public class FileUpload
    {
        string currentUploadFilePath = Path.Combine(FileSystem.Current.CacheDirectory, "uploads");
        public void InitUploadDir() 
        {
            if (!Directory.Exists(currentUploadFilePath)) Directory.CreateDirectory(currentUploadFilePath);
        }


    }
}
