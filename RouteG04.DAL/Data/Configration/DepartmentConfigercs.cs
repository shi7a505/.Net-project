using RouteG04.DAL.Models.DepartmentModule;

namespace RouteG04.DAL.Data.Configration
{
    public class DepartmentConfigercs:BaseEntityConfigration<Department> , IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D=>D.Id).UseIdentityColumn(10,10);
            builder.Property(D => D.Name).HasColumnType("varchar(20)");
            builder.Property(D=>D.Code).HasColumnType("varchar(20)");
            base.Configure(builder);

        }
    }
}
