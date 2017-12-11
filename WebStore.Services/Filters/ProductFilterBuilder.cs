using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebStore.Domain.Entities;
using LinqKit;
using LinqKit.Utilities;

namespace WebStore.Services.Filters
{
	public class ProductFilterBuilder
	{
		private ProductFilter _filter;
		public ProductFilterBuilder( ProductFilter filter)
		{
			_filter = filter;
		}
		/// <summary>
		/// Стандартный метод для паттерна фильтра
		/// </summary>
		/// <returns></returns>
		public Expression<Func<Product, bool>> Build()
		{
			//инициализируем выражение
			Expression<Func<Product, bool>> exp = PredicateBuilder.True<Product>();

			if(_filter != null && _filter.HasFilter)
			{
				if(!string.IsNullOrWhiteSpace(_filter.Model))
				{
					exp = exp.And( p => p.Model.Contains( _filter.Model ) ); //соединили 2 линк в один с помощью ЛинкКит
				}
				if ( _filter.BrandId.HasValue )
				{
					exp = exp.And( p => p.BrandId == _filter.BrandId ); //соединили 2 линк в один с помощью ЛинкКит
				}
				if (_filter.Price.HasValue)
				{
					exp = exp.And( p => p.Price == _filter.Price); //соединили 2 линк в один с помощью ЛинкКит
				}
				if (_filter.CompressorId.HasValue)
				{
					exp = exp.And( p => p.CompressorId == _filter.CompressorId ); //соединили 2 линк в один с помощью ЛинкКит
				}
				
			}
			return exp;
		}
	}
}