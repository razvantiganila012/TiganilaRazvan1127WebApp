using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TiganilaRazvanWebApp.Models.Interfaces;
using TiganilaRazvanWebApp.Web;


namespace TiganilaRazvanWebApp.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductServices productService;

        public HomeController(IProductServices productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = productService.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            var product = productService.GetProduct(id);
            return View(product);
        }

        [HttpPost]
        [Route("Add/{id}")]
        public IActionResult Add(int id)
        {
            var shopList = HttpContext.Session.Get<List<int>>(SessionHelper.ShoppingCart);

            if (shopList == null)
                shopList = new List<int>();

            if (!shopList.Contains(id))
                shopList.Add(id);

            HttpContext.Session.Set(SessionHelper.ShoppingCart, shopList);

            return RedirectToAction("Index", "Home", productService.GetAllProducts());
        }

        [HttpPost]
        [Route("Remove/{id}")]
        public IActionResult Remove(int id)
        {
            var shopList = HttpContext.Session.Get<List<int>>(SessionHelper.ShoppingCart);

            if (shopList == null)
                return RedirectToAction("Index", "Home", productService.GetAllProducts());

            if (shopList.Contains(id))
                shopList.Remove(id);

            HttpContext.Session.Set(SessionHelper.ShoppingCart, shopList);

            return RedirectToAction("Index", "Home", productService.GetAllProducts());
        }

        [HttpPost]
        [Route("AddWishList/{id}")]
        public IActionResult AddWishList(int id)
        {
            var wishList = HttpContext.Session.Get<List<int>>(SessionHelper.WishList);
            if (wishList == null)
                wishList = new List<int>();

            if (!wishList.Contains(id))
                wishList.Add(id);

            HttpContext.Session.Set(SessionHelper.WishList, wishList);
            return RedirectToAction("Index", "Home", productService.GetAllProducts());
        }

        [HttpPost]
        [Route("RemoveWishList/{id}")]
        public IActionResult RemoveWishList(int id)
        {
            var shopList = HttpContext.Session.Get<List<int>>(SessionHelper.WishList);

            if (shopList == null)
                return RedirectToAction("Index", "Home", productService.GetAllProducts());

            if (shopList.Contains(id))
                shopList.Remove(id);

            HttpContext.Session.Set(SessionHelper.WishList, shopList);

            return RedirectToAction("Index", "Home", productService.GetAllProducts());
        }
    }
}
