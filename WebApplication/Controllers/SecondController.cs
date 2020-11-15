using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Database;
using WebApplication.Entities;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecondController : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;

        public SecondController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<ItemEntity>> Get()
        {
            var items = _dbContext.Items.ToList();
            return Ok(items);
        }

        [HttpPost]
        public ActionResult<CompanyAddedViewModel> Post(CompanyModel item)
        {
            var entity = new ItemEntity
            {
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            Response.Headers.Add("Content-type", "application/json");
            return Ok(new CompanyAddedViewModel(item.Name.Length, item.Description.Length, true));
        }
    }
}