using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMETaskTracker.Models
{
    public interface IStoreRepository
    {
        IQueryable<AcmeTask> Tasks { get; }
    }
}
