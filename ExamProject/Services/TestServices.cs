using ExamProject.Interfaces;
using ExamProject.Models;
using ExamProject.Repository;
using ExamProject.ViewModels;

namespace ExamProject.Services
{
    public class TestServices : ITestService
    {
        private IExamRepository _examRepository;
        private IExamStudentRepository _examstudentRepository;
        private IStudentAnswerRepository _studentAsnwerRepository;
        private IUnitOfWork _unitOfWork;

        public TestServices(IExamRepository examRepository, IExamStudentRepository examstudentRepository, IStudentAnswerRepository IstudentAsnwerRepository, IUnitOfWork unitOfWork)
        {
            _examRepository = examRepository;
            _examstudentRepository = examstudentRepository;
            _studentAsnwerRepository = IstudentAsnwerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> IsExamCompletedAsync(int studentId, int examid)
        {
            var res= await  _examstudentRepository.IsCompletedAsync(studentId, examid);
            return res;
        }

        public async Task<bool> IsExamTimeValidAsync(int examid)
        {
            var exam=await _examRepository.GetByIdAsync(examid);
            var currenttime=DateTime.Now;
            if (currenttime < exam.StartDate)
                return false;
            return true;
        }
        public async Task<ExamStartViewModel> GetExamWithQuestionsViewAsync(int examid, int studentid)
        {
            var exam = await _examRepository.GetExamWithQuestions(examid);

            var viewModel = new ExamStartViewModel()
            {
                ExamId = examid,
                StudentId = studentid,
                Title = exam.Title,
                DurationInMinutes = exam.DurationInMinutes,
                Questions = exam.Questions.Select(x => new QuestionViewModel()
                {

                    QuestionId = x.Id,
                    Description = x.Description,
                    Option1 = x.Option1,
                    Option2 = x.Option2,
                    Option3 = x.Option3,
                    Option4 = x.Option4,
                }).ToList()

            };
            return viewModel;
        }
        public async Task ProccessFinishedExamAsync(ExamStudentViewModel model)
        {
            var exam = await _examRepository.GetByIdAsync(model.ExamId);
            var examstudent = new ExamStudent()
            {
                ExamId = model.ExamId,
                StudentId = model.StudentId,
                FinishedAt = DateTime.Now,
                IsCompleted = true,
            };
            await _examstudentRepository.Add(examstudent);
            await _unitOfWork.SaveChangesAsync();
            var starttime = DateTime.Now;
            var allowedtime = exam.StartDate.AddMinutes(exam.DurationInMinutes);
            var Answers = new List<StudentAsnwers>();
            foreach (var answer in model.Answers)
            {
                var answeredtime = DateTime.Now;
                var isontime = answeredtime <= allowedtime;
                Answers.Add(new StudentAsnwers()
                {
                    ExamStudentId = examstudent.Id,
                    QuestionId = answer.Key,
                    SelectedOption = answer.Value,
                    AnsweredAt = answeredtime,
                    IsOnTime = isontime
                });
            }
            await _studentAsnwerRepository.AddRangeAsync(Answers);
            await _unitOfWork.SaveChangesAsync();
        }


            

    }
}
