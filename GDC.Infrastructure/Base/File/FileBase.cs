using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDC.Business;

namespace GDC.Infrastructure.Base.File
{
    public class FileBase
    {
        string path = string.Empty;
        public FileBase()
        {
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Uploads");
        }

        public async Task UploadFiles()
        {
            
        }

        public async Task DeleteFile()
        {

        }

        public async Task ClearDirectory()
        {

        }
    }
}
