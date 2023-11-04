using SonicPosRestaurant.Core.Functions;
using SonicPosRestaurant.DataAccess.Contexts.Restaurant;
using SonicPosRestaurant.DataAccess.Dals;
using SonicPosRestaurant.DataAccess.Dals.Base;
using SonicPosRestaurant.DataAccess.Functions;
using SonicPosRestaurant.DataAccess.Interfaces;
using SonicPosRestaurant.DataAccess.Interfaces.Base;
using System;
using System.Linq;

namespace SonicPosRestaurant.DataAccess.UnitOfWork
{
    public class RestaurantUnitOfWork : IUnitOfWork
    {
        private readonly RestaurantContext _context;
        private bool disposedValue;

        public IUrunDal UrunDal { get; set; }
        public ITanimDal TanimDal { get; set; }
        public IPorsiyonDal PorsiyonDal { get; set; }
        public IEkMalzemeDal EkMalzemeDal { get; set; }
        public IMusteriDal MusteriDal { get; set; }
        public ITelefonDal TelefonDal  { get; set; }
        public IAdresDal AdresDal { get; set; }
        public RestaurantUnitOfWork(string connectionString = null)
        {
            if (connectionString == null)
            {
                _context = new RestaurantContext(ConnectionStringInfo.Get());
            }
            else
            { 
                _context = new RestaurantContext(connectionString);
            }
            UrunDal = new UrunDal(_context);
            TanimDal = new TanimDal(_context);
            PorsiyonDal = new PorsiyonDal(_context);
            EkMalzemeDal = new EkMalzemeDal(_context);
            MusteriDal = new MusteriDal(_context);
            TelefonDal = new TelefonDal(_context);
            AdresDal = new AdresDal(_context);
        }

        public bool Commit()
        {
            EntityBaseInfo.Add(_context);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hata oluştu: {e.Message}");
                return false; 
                
            }

        }

        public void DetectChanges()
        {
            _context.ChangeTracker.DetectChanges();
        }

        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }

        IRepository<TEntity> IUnitOfWork.Dal<TEntity>()
        {
            return new Repository<TEntity>(_context);
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
        // ~RestaurantUnitOfWork()
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


        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RestaurantUnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

    }
}
