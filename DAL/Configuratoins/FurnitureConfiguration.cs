using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DAL.Entity;
using DAL.Seeding;

namespace DAL.Configuratoins
{


    public class FurnitureConfiguration : IEntityTypeConfiguration<Furniture>
    {
        public void Configure(EntityTypeBuilder<Furniture> builder)
        {
            builder.Property(project => project.Id)
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(project => project.Item)
                   ;

            builder.Property(project => project.Year)
                   ;

            builder.Property(project => project.code)
                   ;

            builder.Property(project => project.RoomId)
                   ;



            /* builder.HasOne(project => project.Year)
                    .WithMany(team => team.Projects)
                    .HasForeignKey(project => project.Address)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Projects_TeamId");
*/
            new FurnitureSeeder().Seed(builder);
        }
    }
}



