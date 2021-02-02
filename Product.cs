using System;

namespace NHibernate.Test
{
	class Product
	{
		public virtual Guid Id { get; set; }
		public virtual string Name { get; set; }
		public virtual dynamic Properties { get; set; }
	}
}
