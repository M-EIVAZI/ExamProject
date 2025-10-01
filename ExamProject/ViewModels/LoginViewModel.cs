using System.ComponentModel.DataAnnotations;

namespace ExamProject.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "وارد کردن آیدی آزمون الزامی است.")]
        [Display(Name = "آیدی آزمون")]
        public int ExamId { get; set; }

        [Required(ErrorMessage = "وارد کردن آیدی دانشجو الزامی است.")]
        [Display(Name = "آیدی دانشجو")]
        public int StudentId { get; set; }
    }
}
