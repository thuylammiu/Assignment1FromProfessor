using AppointmentBooking.Data;
using AppointmentBooking.Entities;
using AppointmentBooking.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AppointmentBooking.Repositoties
{
    public class Repositoty<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DataContext dataContext;
        private DbSet<T> dbSet;

        public Repositoty(DataContext dataContext) 
        {
            this.dataContext = dataContext;
            dbSet = dataContext.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await dataContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IList<T>> GetAll()
        {
            return await dbSet.Include("Patient").ToListAsync();
        }

        public async Task<IList<T>> GetWithFilter(Expression<Func<T, bool>>? filter, string include = "")
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (!String.IsNullOrEmpty(include))
            {
                query= query.Include(include);
            }
               

            return await query.ToListAsync();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
