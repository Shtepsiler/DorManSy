using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DAL.Entity;
using DAL.Seeding;

namespace DAL.Configuratoins
{


    public class InmateConfiguration : IEntityTypeConfiguration<Inmate>
    {
        public void Configure(EntityTypeBuilder<Inmate> builder)
        {
            builder.Property(project => project.Id)
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(project => project.Name)
                   ;

            builder.Property(project => project.Surname)
                   ;

            builder.Property(project => project.Status)
                   ;

            builder.Property(project => project.isPaid)
                   ;
            builder.Property(project => project.RoomId)
                   ;




            /* builder.HasOne(project => project.Year)
                    .WithMany(team => team.Projects)
                    .HasForeignKey(project => project.Address)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Projects_TeamId");
*/
            new InmateSeeder().Seed(builder);
        }
    }
}



