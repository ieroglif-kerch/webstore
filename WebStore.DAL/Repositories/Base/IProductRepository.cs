using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebStore.Domain.Entities;


namespace WebStore.DAL.Repositories.Base
{
	public interface IProductRepository
	{
		
		IEnumerable<Product> GetProducts();

		IEnumerable<Product> GetProducts( Expression<Func<Product, bool>> func );

	  

		Product GetProduct( Expression<Func<Product, bool>> func );

		//Adding or removing products from Db
		void AddProduct(Product product);
		void AddProducts( IEnumerable<Product> products);

		void RemoveProduct( Product product, bool save = true );
		void RemoveProducts( IEnumerable<Product> products );
	}
}