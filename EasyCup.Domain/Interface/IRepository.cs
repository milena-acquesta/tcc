using EasyCup.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyCup.Domain.Interface
{
    public interface IRepository<TEntity> where TEntity : BaseDomain
    {
        Task<TEntity> Insert(TEntity obj);

        Task<TEntity> SelectFirstBy(Expression<Func<TEntity, bool>> predicate);

        Task<IList<TEntity>> Select();

        Task<IList<TEntity>> Select(Expression<Func<TEntity, bool>> predicate);

        Task<IList<TEntity>> Select(Expression<Func<TEntity, bool>> predicate, params string[] relations);

        Task DeleteFirstBy(Expression<Func<TEntity, bool>> predicate);

        Task Update(TEntity obj);
    }
}
