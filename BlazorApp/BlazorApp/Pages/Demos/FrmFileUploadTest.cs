using BlazorApp.Control;
using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Linq;

namespace BlazorApp.Pages.Demos
{
    public partial class FrmFileUploadTest
    {
        [Inject]
        IFileUploadService fileUploadService { get; set; }

        protected string selectFileName = "선택된 파일이 없습니다.";


        private IFileListEntry[] selectedFiles;

        protected void HandleSelection(IFileListEntry[] files)
        {
            selectedFiles = files;
            selectFileName = selectedFiles?.FirstOrDefault().Name;
        }

        [Inject]
        IJSRuntime js { get; set; }

        protected async Task OnClickButton()
        {

            var file = selectedFiles != null ? selectedFiles.FirstOrDefault() : null; //첫번째 파일만 가지고옴.
            if(file != null)
            {
                await fileUploadService.UploadAsync(file);
                await js.InvokeAsync<object>("alert", "업로드가 완료됬습니다.");
                selectedFiles = null;
                selectFileName = "선택된 파일이 없습니다.";
            }
            else
                await js.InvokeAsync<object>("alert", "파일을 선택 해 주세요.");


        }
    }
}
