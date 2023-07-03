using BlazorInputFile;

namespace BlazorApp.Control
{
    public interface IFileUploadService
    {
        Task UploadAsync(IFileListEntry file);
    }
}
