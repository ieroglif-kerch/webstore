using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebStore.Domain.Entities;

namespace WebStore.DAL.Context
{
	public class WebDBContext
	:DbContext
	{
		public WebDBContext()
			:base("Products")
		{
			Database.SetInitializer( new DbInitializer() );
		}
		public virtual DbSet<Product>			Product			 { get; set; }
		public virtual DbSet<Brand>				Brand			 { get; set; }
		public virtual DbSet<TypeOfConditioner> Type			 { get; set; }
		public virtual DbSet<Compressor>		Compressor		 { get; set; }
		public virtual DbSet<OperationMode>		OperationMode	 { get; set; }
		public virtual DbSet<ServiceArea>		ServiceArea		 { get; set; }
		public virtual DbSet<TermalCapability>  TermalCapability { get; set; }




	}
}