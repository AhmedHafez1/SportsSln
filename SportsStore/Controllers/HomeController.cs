using Microsoft.AspNetCore.Mvc;
using SportsStore.Data;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreRepository _repo;
        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(int page = 1)
        {
            return View(_repo.Products
                .OrderBy(p => p.Name)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                );
        }
    }
}
