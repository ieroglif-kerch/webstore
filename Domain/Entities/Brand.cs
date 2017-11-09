using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebStore.Domain.Entities
{
	[Table("Brands")]
	public class Brand
	{
		public int Id { get; set; }
		public string Name { get; set; }


		//In oreder to see all products with this brand name
		public virtual ICollection<Product> Products {get;set;}
	}
}