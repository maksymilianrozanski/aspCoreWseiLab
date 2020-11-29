using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Database;

namespace WebApplication.ViewComponents
{
    public class LatestItem : ViewComponent
    {

        private readonly ExchangesDbContext _dbContext;

        public LatestItem(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var lastItem = _dbContext.Items
                .OrderByDescending(x => x.Id).First();
            return View("Index", lastItem);
        }
    }
}