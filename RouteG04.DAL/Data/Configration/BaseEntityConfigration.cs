using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteG04.DAL.Data.Configration
{
    public class BaseEntityConfigration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {   
        public void Configure(EntityTypeBuilder<T> builder)
        {

            builder.Property(D => D.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(D => D.LastModeficationOn).HasDefaultValueSql("GETDATE()");
        }
    }
}
