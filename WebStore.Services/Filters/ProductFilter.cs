using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.Services.Filters
{
	public class ProductFilter
	{
		public string Model { get; set; }
		public double? Price { get; set; }
		public string PriceRagne {get; set;}
		public int? BrandId { get; set; }
		public int? CompressorId { get; set; }

		/// <summary>
		/// Проверка на наличие параметров для улучшения фильтрации, есть ли смысл фильтровать
		/// </summary>
		public bool HasFilter =>
								!string.IsNullOrWhiteSpace( Model ) || 
								!string.IsNullOrWhiteSpace( PriceRagne ) ||
								Price.HasValue ||
								BrandId.HasValue ||
								CompressorId.HasValue;
	}
}