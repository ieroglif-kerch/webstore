using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStore.Services.DTO;

namespace WebStore.Services.Services.Base
{
	public interface IProductService
	{
		IEnumerable<ProductDTO> GetProducts();
	}
}