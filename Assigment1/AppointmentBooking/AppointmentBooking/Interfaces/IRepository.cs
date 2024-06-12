using AppointmentBooking.Entities;
using System.Linq.Expressions;

namespace AppointmentBooking.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public Task<T> CreateAsync(T entity);

        public Task<IList<T>> GetAll();
        public Task<T> UpdateAsync(T entity);
        public Task<IList<T>> GetWithFilter(Expression<Func<T,bool>>? filter, string include="");
        //public Task<IList<T>> GetWithFilter();
    }
}
