using System.ComponentModel.DataAnnotations;
namespace MySQLTest.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]

        [Display(Name = "書名")]

        [MaxLength(50, ErrorMessage = "タイトルの文字数は 50 文字までです。")]

        public string Title { get; set; }

        [Required]

        [Display(Name = "よみがな")]

        [MaxLength(100, ErrorMessage = "よみがなの文字数は 100 文字までです。")]

        public string TitleYomigana { get; set; }
    }
}