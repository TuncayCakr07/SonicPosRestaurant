using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SonicPosRestaurant.Core.Extensions
{
    public static class IncludeExtensions
    {
        public static IQueryable<TEntity> MultipleInclude<TEntity>(this IQueryable<TEntity> query, params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query;
        }
    }
}
