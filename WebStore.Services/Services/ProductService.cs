using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStore.DAL.Repositories.Base;
using WebStore.Services.DTO;
using WebStore.Services.Filters;
using WebStore.Services.Services.Base;

namespace WebStore.Services.Services
{
	public class ProductService
		: IProductService
	{
		private IProductRepository _productRepository;

		public ProductService(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		
		public IEnumerable<ProductDTO> GetProducts( ProductFilter filter = null )
		{
			//прокидываем наш фильтр в filter builder
			var builder = new ProductFilterBuilder(filter);
			//берем результат
			var expr = builder.Build();

			return _productRepository.GetProducts(expr).Select( x => new ProductDTO
			{
				Id				  = x.Id,
				Model		 	  = x.Model,
				Series			  = x.Series,
				Price			  = x.Price,
				ConsumPowerCold   = x.ConsumPowerCold,
				ConsumPowerHeat   = x.ConsumPowerHeat,
				ProducePowerCold  = x.ProducePowerCold,
				ProducePowerHeat  = x.ProducePowerHeat,
				WindFlowMax		  = x.WindFlowMax,
				OutUnitSize		  = x.OutUnitSize,
				InUnitSize		  = x.InUnitSize,
				NoiseMin		  = x.NoiseMin,
				Brand			  = x.Brand.Name,
				TypeofConditioner = x.TypeOfConditioner.Name,
				OperationMode     = x.OperationMode.Mode,
				ServiceArea       = x.ServiceArea.Area,
				TypeOfCompressor  = x.Compressor.Type,
				BTU				  = x.TermalCapability.BTU
			} ).ToList();
		}

	
	}
}