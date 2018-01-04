using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.Services.DTO
{
	public class EmailModel
	{
		public string Subject { get; set; }
		public string CustomerName { get; set; }
		public string Body { get; set; }
		/// <summary>
		/// started time  for calling
		/// </summary>
		public int HrBegin { get; set;}
		/// <summary>
		/// end line for callind
		/// </summary>
		public int HrEnd { get; set; }
	}
}
