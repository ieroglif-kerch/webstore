using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.Domain.Entities.enums
{
	public static class Ids
	{
		public enum BTU 
		{
			BTU7 = 1,
			BTU9,
			BTU12,
			BTU18,
			BTU24
		}
		public enum Area 
		{
			m21 = 1,
			m25,
			m35,
			m20,
			m22,
			m29
		}
		public enum Brand
		{
			Akvilon = 1,
			Kentatsu,
			Haier,
			Aeronik
		}
		public enum Inverter
		{
			No = 1,
			Yes
		}
	}
}