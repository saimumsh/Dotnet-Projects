using Blogie.core;
using Blogie.core.BlogInfo;
using Blogie.data.Repositoty;
using Microsoft.AspNetCore.Mvc;

namespace Blogie.web.Controllers
{
	public class BloggieController : Controller
	{
        private readonly IRepository<BlogData> _blogAction;
        private readonly IWebHostEnvironment webHostEnvironment;
        public BloggieController(IRepository<BlogData> blogAction, IWebHostEnvironment webHostEnvironment)
        {
            _blogAction = blogAction;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
		{
			List<BlogData> obj = _blogAction.GetAll();

			return View(obj);
		}
        public IActionResult Create()
        {
			return View();
        }
		[HttpPost]
        public IActionResult Create( BlogData obj)
		{
            _blogAction.Add(obj);
			return RedirectToAction("Index","Bloggie");
		}
		public IActionResult Update(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
            BlogData obj = _blogAction.GetById(id);
			return View(obj);
		}
		[HttpPost]
        public IActionResult Update(BlogData obj)
        {
            
            _blogAction.Update(obj);
            return RedirectToAction("Index","Bloggie");
        }
        public IActionResult Delete(int id)
		{
            if (id == null)
            {
                return NotFound();
            }
            BlogData obj = _blogAction.GetById(id);
            return View(obj);
		}
        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(BlogData obj)
        {
            _blogAction.Delete(obj);
            return RedirectToAction("Index","Bloggie");
        }
        public IActionResult ShowDetails(int id)
        {
            BlogData obj = _blogAction.GetById(id);
            return View(obj);
        }

    }
}
