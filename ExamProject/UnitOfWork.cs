using ExamProject.Interfaces;

namespace ExamProject
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public  async void SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
