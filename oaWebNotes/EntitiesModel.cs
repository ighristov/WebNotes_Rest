﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using oaWebNotes;


namespace oaWebNotes	
{
	public partial class emWebNotes : OpenAccessContext, IemWebNotesUnitOfWork
	{
		private static string connectionStringName = @"WebNoteConnection";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
		
			
		private static MetadataSource metadataSource = AttributesMetadataSource.FromContext(typeof(emWebNotes));
	
		public emWebNotes()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public emWebNotes(string connection)
			:base(connection, backend, metadataSource)
		{ }
	
		public emWebNotes(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public emWebNotes(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public emWebNotes(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<Note> Notes 
		{
	    	get
	    	{
	        	return this.GetAll<Note>();
	    	}
		}
		
		public IQueryable<Category> Categories 
		{
	    	get
	    	{
	        	return this.GetAll<Category>();
	    	}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MsSql";
			backend.ProviderName = "System.Data.SqlClient";
			return backend;
		}
	}

	public interface IemWebNotesUnitOfWork : IUnitOfWork
	{
		IQueryable<Note> Notes 
		{ 
			get;
		}

		IQueryable<Category> Categories 
		{ 
			get;
		}

	}
}
#pragma warning restore 1591

