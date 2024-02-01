using Microsoft.AspNetCore.Components.Forms;

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
