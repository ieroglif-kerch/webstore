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

			//TypeOfConditionerId  1- split system
			//OperationModeId	   1 - cold/heat

			context.Brand.AddRange( new List<Brand>
						{
						new Brand { Name = "Akvilon" },
						new Brand { Name = "Kentatsu" },
						new Brand { Name = "Haier"    },
						new Brand { Name = "Aeronik"  }

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
						new ServiceArea { Area = 35 },
						new ServiceArea { Area = 20 },
						new ServiceArea { Area = 22 },
						new ServiceArea { Area = 29 }

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
							Series				= "NC",
							NoiseMin			= 36,
							ConsumPowerCold		= 1050,
							ConsumPowerHeat		= 1025,
							ProducePowerCold	= 3516,
							ProducePowerHeat	= 3810,
							WindFlowMax			= 550,
							OutUnitSize			= "805x540x270",
							InUnitSize			= "790x270x196" ,
							Price				= 20000,
							TypeOfConditionerId = 1,
							OperationModeId		= 1,
							ServiceAreaId		= (int)Ids.Area.m35,
							CompressorId		= (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU12,
							MakerRef			= "https://market.yandex.ru/product--akvilon-nc-12/13624672",
							},

				new Product {
							BrandId				= (int)Ids.Brand.Akvilon,
							Model				= "NC-7",
							Series              = "NC",
							NoiseMin            = 34,
							ProducePowerCold	= 2051,
							ProducePowerHeat	= 2198,
							ConsumPowerCold     = 655,
							ConsumPowerHeat     = 610,
							WindFlowMax			= 380,
							OutUnitSize			= "625x450x250", 
							InUnitSize			= "680x245x188", 
							Price				= 12000,
							TypeOfConditionerId = 1,
						    OperationModeId		= 1,
							ServiceAreaId       = (int)Ids.Area.m21,
							CompressorId        = (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU7,
							MakerRef            = "https://market.yandex.ru/product--akvilon-nc-07/13624670",
							},
				new Product {
							BrandId             = (int)Ids.Brand.Akvilon,
							Model               = "NC-9",
							Series              = "NC",
							NoiseMin            = 34,
							ProducePowerCold    = 2637,
							ProducePowerHeat    = 2785,
							ConsumPowerCold     = 800,
							ConsumPowerHeat     = 760,
							WindFlowMax         = 450,
							OutUnitSize         = "690x530x260",
							InUnitSize          = "720x270x196",
							Price               = 15000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m25,
							CompressorId        = (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU9,
							MakerRef            = "https://market.yandex.ru/product--akvilon-nc-09/13624671",

							},
				#endregion
		#region Kentatsu
				new Product {
							BrandId             = (int)Ids.Brand.Kentatsu,
							Model               = "KSGM21HFAN1",
							Series              = "KSGM",
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
							MakerRef			= "http://www.kentatsu-aircon.ru/nastennye-split-sistemy-kentatsu-ksgm-hfa.shtml",
							},
				new Product {
							BrandId             = (int)Ids.Brand.Kentatsu,
							Series              = "KSGM",
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
							MakerRef            = "http://www.kentatsu-aircon.ru/nastennye-split-sistemy-kentatsu-ksgm-hfa.shtml",

							},
				new Product {
							BrandId             = (int)Ids.Brand.Kentatsu,
							Model               = "KSGM35HFAN1",
							Series              = "KSGM",
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
							MakerRef            = "http://www.kentatsu-aircon.ru/nastennye-split-sistemy-kentatsu-ksgm-hfa.shtml",

							},
				new Product {
							BrandId             = (int)Ids.Brand.Kentatsu,
							Model               = "KSGH26HZAN1",
							Series              = "KSGH_HZA TITAN",
							NoiseMin            = 32,
							ConsumPowerCold     = 820,
							ConsumPowerHeat     = 810,
							ProducePowerCold    = 2640,
							ProducePowerHeat    = 2930,
							WindFlowMax         = 500,
							OutUnitSize         = "700x535x235",
							InUnitSize          = "795x270x165",
							Price               = 20000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m25,
							CompressorId        = (int)Ids.Inverter.Yes,
							TermalCapabilityId  = (int)Ids.BTU.BTU9,
							MakerRef            = "http://www.kentatsu-aircon.ru/nastennaya-split-sistema-kentatsu-ksgh-hza-titan.shtml",

							},
			#endregion
		#region Aeronik
				new Product {
							BrandId             = (int)Ids.Brand.Aeronik,
							Series              = "Legend",
							Model               = "ASI-09IL1/ASO-09IL1",
							NoiseMin            = 40,
							ConsumPowerCold     = 780,
							ConsumPowerHeat     = 780,
							ProducePowerCold    = 2500,
							ProducePowerHeat    = 2800,
							WindFlowMax         = 480,
							OutUnitSize         = "776x540x320",
							InUnitSize          = "790x275x200",
							Price               = 25000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m25,
							CompressorId        = (int)Ids.Inverter.Yes,
							TermalCapabilityId  = (int)Ids.BTU.BTU9,
							MakerRef            = "http://www.aeronik.ru/catalogitems/konditsionery/?iid=9B2790529E3843DD874F6E140247D6D2",

							},
				new Product {
							BrandId             = (int)Ids.Brand.Aeronik,
							Model               = "ASI-07IL1/ASO-07IL1",
							Series              = "Legend",
							NoiseMin            = 40,
							ConsumPowerCold     = 780,
							ConsumPowerHeat     = 780,
							ProducePowerCold    = 2200,
							ProducePowerHeat    = 2300,
							WindFlowMax         = 500,
							OutUnitSize         = "720x428x310",
							InUnitSize          = "713x270x195",
							Price               = 24000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m20,
							CompressorId        = (int)Ids.Inverter.Yes,
							TermalCapabilityId  = (int)Ids.BTU.BTU7,
							MakerRef			= "http://www.aeronik.ru/catalogitems/konditsionery/?iid=AD9AF9760EF849B3B5AF227847A56E3B",
							},
			#endregion
		#region Haier
			new Product {
							BrandId             = (int)Ids.Brand.Haier,
							Series              = "Home",
							Model               = "HSU-07HEK303/R2",
							NoiseMin            = 30,
							ConsumPowerCold     = 680,
							ConsumPowerHeat     = 680,
							ProducePowerCold    = 2200,
							ProducePowerHeat    = 2250,
							WindFlowMax         = 450,
							OutUnitSize         = "695/245/430",
							InUnitSize          = "795/187/265",
							Price               = 15000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m20,
							CompressorId        = (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU7,
							MakerRef			= "https://haierproff.ru/material/cond/tech/products/condicionery_SuperMatch/neinvertornie_kondicionery_home/kondicioner-HSU-07HEK303R2_HSU-07HUN103-R2",
							},
				new Product {
							BrandId             = (int)Ids.Brand.Haier,
							Series              = "Home",
							Model               = "HSU-09HEK203/R2",
							NoiseMin            = 30,
							ConsumPowerCold     = 780,
							ConsumPowerHeat     = 780,
							ProducePowerCold    = 2500,
							ProducePowerHeat    = 2670,
							WindFlowMax         = 450,
							OutUnitSize         = "660/275/540",
							InUnitSize          = "795/187/265",
							Price               = 16000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m22,
							CompressorId        = (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU9,
							MakerRef            = "https://haierproff.ru/material/cond/tech/products/condicionery_SuperMatch/neinvertornie_kondicionery_home/kondicioner-HSU-09HEK203",

							},
				new Product {
							Series              = "Home",
							BrandId             = (int)Ids.Brand.Haier,
							Model               = "HSU-12HEK203/R2",
							NoiseMin            = 32,
							ConsumPowerCold     = 1030,
							ConsumPowerHeat     = 1030,
							ProducePowerCold    = 3300,
							ProducePowerHeat    = 3570,
							WindFlowMax         = 500,
							OutUnitSize         = "660/275/540",
							InUnitSize          = "795/187/265",
							Price               = 20000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m29,
							CompressorId        = (int)Ids.Inverter.No,
							TermalCapabilityId  = (int)Ids.BTU.BTU12,
							MakerRef            = "https://haierproff.ru/material/cond/tech/products/condicionery_SuperMatch/neinvertornie_kondicionery_home/kondicioner-HSU-12HEK203",

							},
				new Product {
							BrandId             = (int)Ids.Brand.Haier,
							Series              = "Home",
							Model               = "HSU-09HEK303/R2(DB)",
							NoiseMin            = 27,
							ConsumPowerCold     = 770,
							ConsumPowerHeat     = 770,
							ProducePowerCold    = 2500,
							ProducePowerHeat    = 3000,
							WindFlowMax         = 450,
							OutUnitSize         = "780/245/540",
							InUnitSize          = "795/187/265",
							Price               = 24000,
							TypeOfConditionerId = 1,
							OperationModeId     = 1,
							ServiceAreaId       = (int)Ids.Area.m22,
							CompressorId        = (int)Ids.Inverter.Yes,
							TermalCapabilityId  = (int)Ids.BTU.BTU9,
							MakerRef            = "https://haierproff.ru/material/cond/tech/products/invertornie_kondicionery/102/kondicioner-HSU-09HEK303-R2DB",

							},
			#endregion
			 } );
			context.SaveChanges();
	 }
	}
}