using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.DAL.Context;
using System.Data.Entity;
using WebStore.Services.Services.Base;
using WebStore.Services.Filters;
using System.Text;

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
		[HttpGet]
		public ActionResult Index( ProductFilter filter, int idInfo = 0, int PriceRange = 0  )
		{

			var products = _productService.GetProducts(filter) ;
			TempData["Info"] = idInfo;
			ViewBag.Tab = PriceRange;
			if (PriceRange == 1)
				{
				 products = products.Where(p=>p.Price <= 15000);				
				}
			if (PriceRange == 2)
			{
				 products = products.Where(p=>p.Price > 15000 && p.Price <= 20000);
			}
			if (PriceRange == 3)
			{
				 products = products.Where(p=>p.Price > 20000);
			}
			if (PriceRange == 4)
			{
				products = products.Where( p => p.TypeOfCompressor == "Инвертор" );
			}
			return View( products );
		}

		[HttpGet]
		public ActionResult ConditionerInfo ()
		{
			if ((int)TempData[ "Info" ] == 0) return PartialView( "Empty" );

			var product = _productService.GetProducts().First(p=>p.Id == (int)TempData["Info"]);			
			return PartialView( "_ConditionerInfo", product );
		}
		[HttpGet]
		public ActionResult Articles ()
		{
			return View();
		}
		[HttpGet]
		public ActionResult Article (string ArticleName = "_mounting")
		{			
			return PartialView( ArticleName );
		}
		
		[HttpGet]
		public ActionResult Menu()
		{
			return View();
		}
		public ActionResult MenuItem( string ArticleName = "_services" )
		{
			return PartialView( ArticleName );
		}
	}
}