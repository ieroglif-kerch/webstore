using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStore.Services.DTO;
using WebStore.Services.Filters;

namespace WebStore.Services.Services.Base
{
	public interface IProductService
	{
		IEnumerable<ProductDTO> GetProducts(ProductFilter filter = null);
		

	}
}