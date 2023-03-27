using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DAL.Entity;
using DAL.Seeding;

namespace DAL.Configuratoins
{ 


        public class DormintoryConfiguration : IEntityTypeConfiguration<Dormitory>
        {
            public void Configure(EntityTypeBuilder<Dormitory> builder)
            {
                builder.Property(project => project.Id)
                       .UseIdentityColumn()
                       .IsRequired();

                builder.Property(project => project.Number)
                       ;

                builder.Property(project => project.Manager)
                       ;

                builder.Property(project => project.FloorsNumber)
                       ;

                builder.Property(project => project.RoomsNumber)
                       ;

                builder.Property(project => project.Year)
                       ;

                builder.Property(project => project.Address)
                       ;



            /* builder.HasOne(project => project.Year)
                    .WithMany(team => team.Projects)
                    .HasForeignKey(project => project.Address)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Projects_TeamId");
*/
            new DormintorySeeder().Seed(builder);
            }
        }
    }



