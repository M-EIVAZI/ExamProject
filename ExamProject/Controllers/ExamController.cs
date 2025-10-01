using ExamProject.Interfaces;
using ExamProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExamProject.Controllers
{
    [Route("[controller]")]
    public class ExamController : Controller
    {
        private readonly ITestService _testService;

        public ExamController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View(new LoginViewModel());
        }

        [HttpPost("HandleLoginPost")] 
        [ValidateAntiForgeryToken]
        public IActionResult HandleLoginPost(LoginViewModel model)
        {
            if (model.ExamId == 0 || model.StudentId == 0)
            {
                return View("Index", model);
            }

            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            return RedirectToAction("StartExam", new { testId = model.ExamId, studentId = model.StudentId });
        }

        [HttpGet("StartExam")]
        public async Task<IActionResult> StartExam(int testId, int studentId)
        {
            if (!await _testService.IsExamCompletedAsync(testId, studentId))
            {
                return View("Error", "آزمون شما قبلاً ثبت نهایی شده است و امکان شرکت مجدد وجود ندارد.");
            }

            if (!await _testService.IsExamTimeValidAsync(testId))
            {
                return View("Error", "شروع این آزمون خارج از تاریخ یا بازه زمانی مجاز است.");
            }

            var viewModel = await _testService.GetExamWithQuestionsViewAsync(testId, studentId);

            return View(viewModel);
        }

        [HttpPost("SubmitExam")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitExam(ExamStudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Error", "لطفاً تمامی سوالات را پاسخ دهید.");
            }

            if (await _testService.IsExamCompletedAsync(model.ExamId, model.StudentId))
            {
                return View("Error", "ثبت ناموفق: این آزمون قبلا ثبت شده است.");
            }

            try
            {
                await _testService.ProccessFinishedExamAsync(model);

                TempData["SuccessMessage"] = "آزمون شما با موفقیت ثبت نهایی شد.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View("Error", "خطا در پردازش آزمون: " + ex.Message);
            }
        }
    }
}