using DAL.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamworkSystem.DataAccessLayer.Interfaces;

namespace DAL.Seeding
{

    public class InmateSeeder : ISeeder<Inmate>
    {
        private static readonly List<Inmate> inmates = new()
        {
            new Inmate
            {
                Id = 1,
                Name = "Misha",
                Surname = "Hordashuk",
                isPaid = true,
                Status = "student",
                RoomId = 1
            },   
            new Inmate
            {
                Id = 2,
                Name = "Vasia",
                Surname = "Fammilia",
                isPaid = true,
                Status = "student",
                RoomId = 1
            },
        };

        public void Seed(EntityTypeBuilder<Inmate> builder) => builder.HasData(inmates);
    }


}

