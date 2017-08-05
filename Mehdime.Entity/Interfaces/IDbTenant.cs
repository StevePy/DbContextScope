using System;


namespace Mehdime.Entity
{
	/// <summary>
	/// Contract interface for a class that will provide tenant information for a multi-tenant 
	/// system.
	/// </summary>
	public interface IDbTenant
	{
		string ConnectionString { get; }
		string SchemaName { get; }
	}
}
