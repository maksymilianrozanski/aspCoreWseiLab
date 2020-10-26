using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecondController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CompanyAddedViewModel> Get()
        {
            return Ok(new CompanyAddedViewModel(10, 10, true));
        }

        [HttpPost]
        public ActionResult<CompanyAddedViewModel> Post(CompanyModel item)
        {
            Response.Headers.Add("Content-type", "application/json");
            return Ok(new CompanyAddedViewModel(10, 10, true));
        }
    }
}