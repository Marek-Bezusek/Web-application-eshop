using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectEshop.Interfaces;
using ProjectEshop.Models;

namespace ProjectEshop.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IHasId
    {
        private EshopContext _context;
        private DbSet<TEntity> _entities;

        public Repository(EshopContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public virtual void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _entities.Attach(entity);
            }
            _entities.Remove(entity);
        }

        public virtual bool Delete(int ID)
        {
            var entity = _entities.Find(ID);
            if (entity == null)
            {
                throw new ArgumentOutOfRangeException("ID");
            }
            Delete(entity);
            return true;
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }


            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        public virtual TEntity GetByID(int ID)
        {

            return _entities.Find(ID);

        }

        public virtual TEntity GetById(int id, string includeProperties = "")
        {
            IQueryable<TEntity> query = _entities;

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            var finalResult = query.FirstOrDefault(e => e.Id == id);
            return finalResult;
        }

        public virtual void Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Add(entity);

        }

        public virtual void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual int Commit()
        {
            return _context.SaveChanges();
        }
    }

}
