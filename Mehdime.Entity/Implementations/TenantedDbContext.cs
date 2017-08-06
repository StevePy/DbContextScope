using System;
using System.Data.Common;
using System.Data.Entity;


namespace Mehdime.Entity
{
	/// <summary>
	/// This overrided version of DbContext accepts a tenant details in the constructor
	/// which will provide the information for the connection string and/or schema defined for
	/// the tenant in a multi-tenanted environment.
	/// </summary>
	public abstract class TenantedDbContext : DbContext
	{
		private readonly IDbTenant _tenant = null;
		protected IDbTenant Tenant
		{
			get { return _tenant; }
		}

		public TenantedDbContext(IDbTenant tenant)
			: base(tenant?.ConnectionString)
		{ }

		public TenantedDbContext(DbConnection connection, bool contextOwnsConnection)
			: base(connection, contextOwnsConnection )
		{ }

	}
}
