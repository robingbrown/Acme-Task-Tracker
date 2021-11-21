using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ACMETaskTracker.Models;
using ACMETaskTracker.Models.ViewModels;

namespace ACMETaskTracker.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(string category, int TaskPage = 1)
            => View(new TasksListViewModel
            {
                Tasks = repository.Tasks
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.TaskID)
                    .Skip((TaskPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = TaskPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Tasks.Count() :
                        repository.Tasks.Where(e => e.Category == category).Count()
                },
                CurrentCategory = category
            });
    }
}
