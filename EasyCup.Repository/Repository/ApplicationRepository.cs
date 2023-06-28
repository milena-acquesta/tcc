using EasyCup.Domain.Base;
using EasyCup.Domain.Interface;
using EasyCup.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyCup.Repository.Repository
{
    public class ApplicationRepository<TEntity> : IRepository<TEntity> where TEntity : BaseDomain
    {
        #region Fields
        protected DbContext DbContext;
        #endregion

        #region Constructor
        public ApplicationRepository(ApplicationDbContext dbontext)
        {
            DbContext = dbontext;
        }
        #endregion

        #region Methods
        public async Task<TEntity> Insert(TEntity obj)
        {
            obj.CreatedDate = DateTime.Now;
            var user = await DbContext.Set<TEntity>().AddAsync(obj);
            await DbContext.SaveChangesAsync();

            return user.Entity;
        }

        public async Task<TEntity> SelectFirstBy(Expression<Func<TEntity, bool>> predicate) =>
           await DbContext.Set<TEntity>().FirstOrDefaultAsync(predicate);


        public async Task<IList<TEntity>> Select() =>
            await DbContext.Set<TEntity>().Where(x => x.DeletedAt == null).ToListAsync();


        public async Task<IList<TEntity>> Select(Expression<Func<TEntity, bool>> predicate) =>
          await DbContext.Set<TEntity>().Where(predicate).Where(x => x.DeletedAt == null).ToListAsync();


        public async Task<IList<TEntity>> Select(Expression<Func<TEntity, bool>> predicate, params string[] relations)
        {
            var query = DbContext.Set<TEntity>().Where(predicate).Where(x => x.DeletedAt == null);

            foreach (var relation in relations)
            {
                query = query.Include(relation);
            }

            return await query.ToListAsync();
        }


        public async Task DeleteFirstBy(Expression<Func<TEntity, bool>> predicate)
        {
            var data = await SelectFirstBy(predicate);
            data.UpdatedDate = DateTime.Now;
            data.DeletedAt = DateTime.Now;

            DbContext.Entry(data).State = EntityState.Modified;

            await DbContext.SaveChangesAsync();
        }

        public async Task Update(TEntity obj)
        {
            obj.UpdatedDate = DateTime.Now;
            DbContext.Entry(obj).State = EntityState.Modified;

            var updated = await DbContext.SaveChangesAsync();

            if (updated == 0)
                throw new Exception("Não foi possível atualizar.");

        }

        #endregion
    }
}
