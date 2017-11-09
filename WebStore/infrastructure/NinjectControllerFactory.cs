using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using WebStore.DAL.Context;
using WebStore.DAL.Repositories;
using WebStore.DAL.Repositories.Base;
using WebStore.Services.Services;
using WebStore.Services.Services.Base;

namespace WebStore.infrastructure
{
	public class NinjectControllerFactory
				: DefaultControllerFactory
	{
		private IKernel _kernel;

		public NinjectControllerFactory()
		{
			_kernel = new StandardKernel();
			AddBindings();
		}

		private void AddBindings()
		{
			//were asked DbContext return WebDBContext
			_kernel.Bind<DbContext>().To<WebDBContext>();

			//were interface iproductrepository will be asked, we will throw product repository
			_kernel.Bind<IProductRepository>().To<ProductRepository>();

			_kernel.Bind<IProductService>().To<ProductService>();
		}
		protected override IController GetControllerInstance( RequestContext requestContext, Type controllerType )
		{
			if (controllerType == null)
				return null;
			return (IController)_kernel.Get( controllerType );
		}
	}
}