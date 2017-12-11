using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;


namespace WebStore.Domain.Entities
{
	[Table("Products")]
	public class Product
	{
		[Key]
		public int	  Id { get; set; }
		public string Series { get; set; }
		public string Model { get; set; }
		public double Price { get; set; }
		///Flag for cheaking if product is removed (erased)
		public bool IsRemoved { get; set; }
		public int  NoiseMin { get; set; }
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

		//Connections
		[ForeignKey( "Brand" )]
		public int						 BrandId			{ get; set; }		
		public virtual  Brand			 Brand				{ get; set; }

		[ForeignKey( "TypeOfConditioner" )]
		public int						TypeOfConditionerId { get; set; }
		public virtual TypeOfConditioner TypeOfConditioner  { get; set; }

		[ForeignKey( "Compressor" )]
		public int						 CompressorId		{ get; set; }
		public virtual Compressor		 Compressor			{ get; set; }

		[ForeignKey( "OperationMode" )]
		public int						 OperationModeId	{ get; set; }
		public virtual OperationMode	 OperationMode		{ get; set; }

		[ForeignKey( "ServiceArea" )]
		public int						 ServiceAreaId		{ get; set; }
		public virtual ServiceArea		 ServiceArea		{ get; set; }

		[ForeignKey( "TermalCapability" )]
		public int						 TermalCapabilityId { get; set; }
		public virtual TermalCapability  TermalCapability   { get; set; }

	}
}