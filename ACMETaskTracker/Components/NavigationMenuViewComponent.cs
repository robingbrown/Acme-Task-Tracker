using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ACMETaskTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACMETaskTracker.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo    )
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Tasks
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
