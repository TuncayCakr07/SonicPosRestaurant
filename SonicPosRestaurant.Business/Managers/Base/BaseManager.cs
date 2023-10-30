﻿using SonicPosRestaurant.Business.Services.Base;
using SonicPosRestaurant.DataAccess.UnitOfWork;
using SonicPosRestaurant.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Managers.Base
{
    public class BaseManager<TEntity> : IBaseService<TEntity> where TEntity : class, IEntity, new()
    {
        private IUnitOfWork _uow;
        public BaseManager(IUnitOfWork uow)
        {
            _uow = uow;
        }
        private bool disposedValue;

        public virtual void Add(TEntity entity)
        {
           _uow.Dal<TEntity>().Add(entity);
        }

        public virtual void Add(IEnumerable<TEntity> entities)
        {
           _uow.Dal<TEntity>().Add(entities);
        }

        public virtual void AddOrUpdate(TEntity entity)
        {
           _uow.Dal<TEntity>().AddOrUpdate(entity);
        }

        public virtual void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity>().AddOrUpdate(entities);
        }

        public virtual BindingList<TEntity> BindingList()
        {
          return _uow.Dal<TEntity>().BindingList();
        }

        public virtual void Delete(TEntity entity)
        {
            _uow.Dal<TEntity>().Delete(entity);
        }

        public virtual void Delete(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity>().Delete(entities);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _uow.Dal<TEntity>().Delete(filter);
        }

        public virtual bool Exist(Expression<Func<TEntity, bool>> filter)
        {
           return _uow.Dal<TEntity>().Exist(filter);
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
           return _uow.Dal<TEntity>().Get(filter, includes);
        }

        public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity>().GetList(filter, includes);
        }

        public bool HasChanges()
        {
            return _uow.Dal<TEntity>().HasChanges();
        }

        public virtual void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BaseManager()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
