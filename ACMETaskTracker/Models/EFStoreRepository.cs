using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMETaskTracker.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;
        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        /// <summary>
        /// Expression body member - get only with this syntax
        /// </summary>
        public IQueryable<AcmeTask> Tasks => context.Tasks;
    }
}
