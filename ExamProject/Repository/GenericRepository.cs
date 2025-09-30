using ExamProject.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExamProject.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
         where TEntity : class
    {
        private AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Add(TEntity entity)
        {

            await _appDbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task<bool> Delete(int id)
        {
            // از FindAsync استفاده کنید که برای PK کار میکنه
            var entity = await _appDbContext.Set<TEntity>().FindAsync(id);

            if (entity != null)
            {
                _appDbContext.Set<TEntity>().Remove(entity);
                return true;
            }

            return false;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _appDbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<bool> Update(TEntity entity)
        {
            _appDbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            // بررسی کن که آیا تغییراتی برای ذخیره وجود داشته؟
            return (await _appDbContext.SaveChangesAsync() > 0);
        }
    }
}
