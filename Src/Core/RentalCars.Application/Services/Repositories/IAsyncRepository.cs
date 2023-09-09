using Microsoft.EntityFrameworkCore.Query;
using RentalCars.Application.Paging;
using RentalCars.Domain.Common;
using System.Linq.Expressions;

namespace RentalCars.Application.Services.Repositories
{
    public interface IAsyncRepository<TEntity> : IQuery<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity?> GetAsync(
       Expression<Func<TEntity, bool>> predicate,
       Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
       bool withDeleted = false,
       bool enableTracking = true,
       CancellationToken cancellationToken = default);

        Task<Paginate<TEntity>> GetListAsync(
            Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            int index = 0,
            int size = 10,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default);

        Task<bool> AnyAsync(
           Expression<Func<TEntity, bool>>? predicate = null,
           bool withDeleted = false,
           bool enableTracking = true,
           CancellationToken cancellationToken = default);

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<TEntity> DeleteAsync(TEntity entity, bool permanent = false);
    }
}
