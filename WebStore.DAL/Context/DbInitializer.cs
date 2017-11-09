using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;
using WebStore.Domain.Entities.enums;
using WebStore.Domain.Entities;

namespace WebStore.DAL.Context
{
	public class DbInitializer
		: DropCreateDatabaseAlways<WebDBContext>
	{
		protected override void Seed( WebDBContext context )
		{
			base.Seed( context );

			context.Brand.AddRange( new List<Brand>
						{
						new Brand { Name = "Akvilon " },
						new Brand { Name = "Kentatsu" },
						new Brand { Name = "Haier"    }
						} );

			context.Type.AddRange( new List<TypeOfConditioner>
						{
						new TypeOfConditioner {Name = "Настенная сплит система"}
						} );

			context.Compressor.AddRange( new List<Compressor>
						{
						new Compressor { Type = "ON/OFF" },
						new Compressor { Type = "Инвертор" }
						} );
			context.OperationMode.Add(
						new OperationMode { Mode = "охлождение/обогрев" }
						);
			context.ServiceArea.AddRange( new List<ServiceArea>
						{
						new ServiceArea { Area = 21 },
						new ServiceArea { Area = 25 },
						new ServiceArea { Area = 35 }
						} );
			context.TermalCapability.AddRange( new List<TermalCapability>
						{
							new TermalCapability {BTU = 7000 },
							new TermalCapability {BTU = 9000 },
							new TermalCapability {BTU = 12000 },
							new TermalCapability {BTU = 18000 },
						} );
			context.SaveChanges();

			
			context.Product.AddRange( new List<Product>
			{
		#region Akvilon
				new Product {
							BrandId				= (int)Ids.Brand.Akvilon,
							Model				= "NC-12",
							NoiseMin			= 36,
							ProducePowerCold	= 3516,
							ProducePowerHeat	= 3810,
							OutUnitSize			= "805x540x270",
							InUnitSize			= "790x270x196" ,
							Price				= 20000,
							TypeOfConditionerId = 1,
							OperationModeId		= 1,
							ServiceAreaId		= (int)Ids.Area.m35,
							CompressorId		= (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU12,

							},

				new Product {
							BrandId				= (int)Ids.Brand.Akvilon,
							Model				= "NC-7",
							NoiseMin			= 34,
							ProducePowerCold	= 2051,
							ProducePowerHeat	= 2198,
							OutUnitSize			= "625x450x250", 
							InUnitSize			= "680x245x188", 
							Price				= 12000,
							TypeOfConditionerId = 1,
						    OperationModeId		= 1,
							ServiceAreaId       = (int)Ids.Area.m21,
							CompressorId        = (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU7,
							},
				new Product {
							BrandId             = (int)Ids.Brand.Akvilon,
							Model               = "NC-9",
							NoiseMin            = 34,
							ProducePowerCold    = 2637,
							ProducePowerHeat    = 2785,
							OutUnitSize         = "690x530x260",
							InUnitSize          = "720x270x196",
							Price               = 15000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m25,
							CompressorId        = (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU9,
							},
				#endregion
		#region Kentatsu
				new Product {
							BrandId             = (int)Ids.Brand.Kentatsu,
							Model               = "KSGM21HFAN1",
							NoiseMin            = 30,
							ConsumPowerCold		= 700,
							ConsumPowerHeat		= 680,
							ProducePowerCold    = 2200,
							ProducePowerHeat    = 2340,
							WindFlowMax			= 460,
							OutUnitSize         = "700x540x240",
							InUnitSize          = "715x250x188",
							Price               = 15000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m21,
							CompressorId        = (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU7,
							},
				new Product {
							BrandId             = (int)Ids.Brand.Kentatsu,
							Model               = "KSGM26HFAN1",
							NoiseMin            = 29,
							ConsumPowerCold     = 830,
							ConsumPowerHeat     = 780,
							ProducePowerCold    = 2640,
							ProducePowerHeat    = 2780,
							WindFlowMax         = 460,
							OutUnitSize         = "685x430x260",
							InUnitSize          = "715x250x188",
							Price               = 20000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m25,
							CompressorId        = (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU9,
							},
				new Product {
							BrandId             = (int)Ids.Brand.Kentatsu,
							Model               = "KSGM35HFAN1",
							NoiseMin            = 30,
							ConsumPowerCold     = 1090,
							ConsumPowerHeat     = 1020,
							ProducePowerCold    = 3520,
							ProducePowerHeat    = 3520,
							WindFlowMax         = 580,
							OutUnitSize         = "700x540x250",
							InUnitSize          = "800x275x188",
							Price               = 25000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m35,
							CompressorId        = (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU12,
							},
			#endregion

			 } );
			context.SaveChanges();
	 }
	}
}