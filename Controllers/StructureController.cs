using HierarchicalDirectory.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HierarchicalDirectory.Controllers
{
    [Route("/")]
    public class StructureController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public StructureController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("/{name}")]
        public IActionResult Catalog(string name)
        {
            var catalog = _dbContext.Catalogs.Include(c => c.Children).FirstOrDefault(c => c.Name == name);

            return View(catalog);
        }
    }
}
