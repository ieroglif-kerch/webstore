using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebStore.Services.DTO
{
	public class EmailModel
	{
		[Required( AllowEmptyStrings = false, ErrorMessage = "Обязательно напишите тему сообщения" )]
		[Display( Name = "Тема" )]
		public string Subject { get; set; }

		[Required( AllowEmptyStrings = false, ErrorMessage = "Как к Вам обращаться" )]
		[Display(Name ="Имя")]
		public string CustomerName { get; set; }

		public string Body { get; set; }


		[Range( 0, 24, ErrorMessage = "всего 24 часа " )]		
		public int? HrFrom { get; set;}
		
		[Range( 0, 24, ErrorMessage = "всего 24 часа " )]	
		public int? HrTill { get; set; }
	}
}
