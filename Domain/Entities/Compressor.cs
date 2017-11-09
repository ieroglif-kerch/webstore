using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebStore.Domain.Entities
{
	[Table("Compressor")]
	public class Compressor
	{
		public int Id { get; set; }
		public string Type { get; set; }


		//In oreder to see all products with this brand name
		public virtual ICollection<Product> Products { get; set; }
	}
}