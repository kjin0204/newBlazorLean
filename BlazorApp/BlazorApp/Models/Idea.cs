using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class Idea
    {
        public int Id { get; set; }

        [Required] // Required 필수 한정자 초기화를 강제성 부여
        public string Note { get; set; }
    }
}
