using BlazorInputFile;

namespace BlazorApp.Control
{
    public class FileUploadService : IFileUploadService
    {
        private readonly IWebHostEnvironment _environment;

        public FileUploadService(IWebHostEnvironment env)
        {
            this._environment = env;
        }

        public async Task UploadAsync(IFileListEntry file)
        {
            //wwwrot 경로, 폴더, 파일이름
            var path = Path.Combine(_environment.WebRootPath, "Upload", file.Name);
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            using(FileStream stream = new FileStream(path,FileMode.Create,FileAccess.Write))
            {
                ms.WriteTo(stream);
            }
        }
    }
}
