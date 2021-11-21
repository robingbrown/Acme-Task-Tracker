using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMETaskTracker.Models.ViewModels
{
    public class TasksListViewModel
    {
        public IEnumerable<AcmeTask> Tasks { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
