using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.DAL.Context;
using System.Data.Entity;
using WebStore.Services.Services.Base;

namespace WebStore.Controllers
{
    public class DefaultController 
		: Controller
    {
		private IProductService _productService;
		public DefaultController(IProductService productService)
		{
			_productService = productService;
		}
        // GET: Main
        public ActionResult Index()
        {
			var products = _productService.GetProducts();
			
            return View(products);
        }
    }
}