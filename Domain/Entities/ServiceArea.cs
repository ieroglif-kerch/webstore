using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebStore.Domain.Entities
{
	[Table("ServiceArea")]
	public class ServiceArea
	{
		
		public int Id { get; set; }
		public int Area { get; set; }


		//In oreder to see all products with this brand name
		public virtual ICollection<Product> Products { get; set; }
	}
}