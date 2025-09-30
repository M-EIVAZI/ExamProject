namespace ExamProject.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public Task Add(TEntity entity);
        public Task<bool> Delete(int id);
        public Task<bool> Update(TEntity entity);
        public Task<TEntity> GetByIdAsync(int id);
    }
}
