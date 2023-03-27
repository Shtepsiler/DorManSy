using DAL.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamworkSystem.DataAccessLayer.Interfaces;

namespace DAL.Seeding { 

        public class DormintorySeeder : ISeeder<Dormitory>
        {
            private static readonly List<Dormitory> dormitories = new()
        {
            new Dormitory
            {
                Id = 1,
                Number = 3,
                Manager ="Valera",
                FloorsNumber = 5,
                RoomsNumber = 50,
                Year = new DateTime(1981,1,1),
                Address = "Chernivtsi, Nebesnoyi Sotni 4B"
            }
        };

            public void Seed(EntityTypeBuilder<Dormitory> builder) => builder.HasData(dormitories);
        }
    

}

