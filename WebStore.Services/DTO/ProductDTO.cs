using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.Services.DTO
{
	public class ProductDTO
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public double Price { get; set; }		
		public int NoiseMin { get; set; }
		///Consumed electrical power in cold mode
		public int? ConsumPowerCold { get; set; }
		///Consumed electrical power in heat mode
		public int? ConsumPowerHeat { get; set; }
		/// Produced power in modes
		public int ProducePowerCold { get; set; }
		public int ProducePowerHeat { get; set; }
		///Max wind flow from conditioner
		public int? WindFlowMax { get; set; }
		///Outdoor unit size
		public string OutUnitSize { get; set; }
		///Indoor unit size
		public string InUnitSize { get; set; }

		public string Brand  { get; set; }

		public string TypeofConditioner { get; set; }
		public string OperationMode { get; set; }
		public int BTU { get; set; }
		public int ServiceArea { get; set; }
		public string TypeOfCompressor { get; set; }


	}
}