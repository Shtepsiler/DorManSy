using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DAL.Entity;
using DAL.Seeding;

namespace DAL.Configuratoins
{


    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(project => project.Id)
                   .UseIdentityColumn()
                   .IsRequired();

/*
            builder.Property(project => project.FurnitureId)
                   ;*/

            builder.Property(project => project.BedsNumder)
                   ;

            builder.Property(project => project.Payment)
                   ;

            builder.Property(project => project.Numder)
       ;
            builder.Property(project => project.DormintoryId)
;
            /*     builder.HasOne(project => project.DormintoryId)
                         .WithMany(team => team.Furniture)
                         .HasForeignKey(project => project.Address)
                         .OnDelete(DeleteBehavior.Cascade)
                         .HasConstraintName("FK_Projects_TeamId");*/

            new RoomSeeder().Seed(builder);
        }
    }
}



