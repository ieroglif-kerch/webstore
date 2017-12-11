using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using WebStore.Domain.Entities;
using WebStore.DAL.Context;
using WebStore.DAL.Repositories.Base;

namespace WebStore.DAL.Repositories
{
	public class ProductRepository
		: IProductRepository
	{
		private WebDBContext _context;
		/// <summary>
		/// Set bindings between db and web
		/// </summary>
		/// <param name="context"></param>
		public ProductRepository(DbContext context)
		{
			_context = (WebDBContext) context;
		}

		/// <summary>
		/// Sub fuction, take products from context
		/// </summary>
		/// <returns></returns>
		private IQueryable<Product> GetProductQuerry()
		{
			return _context.Product.Include(x=> x.Brand )
								   .Include(x=> x.TypeOfConditioner)
								   .Include(x=> x.OperationMode)
								   .Include(x=> x.TermalCapability)
								   .Include(x=> x.ServiceArea)
								   .Include(x=> x.Compressor)
								   .Where(  x=> x.IsRemoved == false);
		}

		/// <summary>
		/// Return products in list
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Product> GetProducts()
		{
			return GetProductQuerry().ToList();
		}

		/// <summary>
		/// Get products with additional parametr, for seaching
		/// </summary>
		/// <param name="func"></param>
		/// <returns></returns>
		public IEnumerable<Product> GetProducts( Expression<Func<Product, bool>> func )
		{
			return GetProductQuerry().Where( func ).ToList();
		}
		public Product GetProduct( Expression<Func<Product, bool>> func )
		{
			return GetProductQuerry().FirstOrDefault( func );
		}

		//Adding products
		public void AddProducts( IEnumerable<Product> products )
		{
			_context.Product.AddRange( products );
			_context.SaveChanges();
		}

		public void AddProduct( Product product )
		{
			_context.Product.Add( product);
			_context.SaveChanges();
		}

		/// <summary>
		/// Change parameter "IsRemoved" on true
		/// </summary>
		/// <param name="product">Product item</param>
		/// <param name="save">Record changes in DB</param>
		public void RemoveProduct( Product product, bool save = true )
		{
			product.IsRemoved = true;

			if(save)
				_context.SaveChanges();
		}

		public void RemoveProducts( IEnumerable<Product> products )
		{
			foreach(var p in products)
			{
				RemoveProduct( p, false );
			}
			_context.SaveChanges();
		}
	}
}