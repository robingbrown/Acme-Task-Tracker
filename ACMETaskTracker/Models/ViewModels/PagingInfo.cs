using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMETaskTracker.Models.ViewModels
{
    public class PagingInfo
    {
        /// <summary>
        /// Auto-implemented property
        /// </summary>
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        /// <summary>
        /// Expression body member - get only with this syntax
        /// </summary>
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
