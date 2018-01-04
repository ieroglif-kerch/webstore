using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.DAL.Context;
using System.Data.Entity;
using WebStore.Services.Services.Base;
using WebStore.Services.DTO;
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
		/// <summary>
		/// starting page
		/// </summary>
		/// <param name="filter">product filter</param>
		/// <param name="idInfo">product it, for printig all info</param>
		/// <param name="PriceRange">main top tabs</param>
		/// <returns></returns>
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
		/// <summary>
		/// Partial view with conditioner info
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public ActionResult ConditionerInfo ()
		{
			if ((int)TempData[ "Info" ] == 0) return PartialView( "Empty" );

			var product = _productService.GetProducts().FirstOrDefault(p=>p.Id == (int)TempData["Info"]);			
			return PartialView( "_ConditionerInfo", product );
		}

		/// <summary>
		/// view articles menu
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public ActionResult Articles ()
		{
			return View();
		}

		/// <summary>
		/// view article
		/// </summary>
		/// <param name="ArticleName"></param>
		/// <returns></returns>
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

		/// <summary>
		/// partial view with services and addition info
		/// </summary>
		/// <param name="ArticleName"></param>
		/// <returns></returns>
		public ActionResult MenuItem( string ArticleName = "_services" )
		{
			return PartialView( ArticleName );
		}
		
		/// <summary>
		/// view Request call
		/// </summary>
		/// <returns></returns>
		public ActionResult RequestCall(string Subject = "")
		{
			ViewBag.Subject = Subject;
			return View();
		}

		/// <summary>
		/// request call logic
		/// </summary>
		/// <param name="model">model for mail view</param>
		/// <returns></returns>
		[HttpPost] 
		public ActionResult RequestCall(EmailModel model)
		{
			if (ModelState.IsValid)
			{
				new EmailController().SendEmail( model ).Deliver();

				return RedirectToAction( "SuccessSendingMail" );
				
			}
			return View( model );
		}


		public ActionResult SuccessSendingMail()
		{
			return View();
		}
		public ActionResult ErrorSendigMail()
		{
			return View();
		}
	}
}