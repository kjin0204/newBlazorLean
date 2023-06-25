using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class ExampleModel
    {
        [Required (ErrorMessage = "이름을 입력 해 주세요.")]
        [StringLength(10, ErrorMessage ="10자 이내로 입력 해 주세요.")]
        public string Name { get; set; }
    }
}
