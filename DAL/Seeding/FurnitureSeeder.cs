using DAL.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamworkSystem.DataAccessLayer.Interfaces;

namespace DAL.Seeding
{

    public class FurnitureSeeder : ISeeder<Furniture>
    {
        private static readonly List<Furniture> furnitures = new()
        {
            new Furniture
            {
                Id = 1,
                code = 68234354,
                Item = "шафа",
                RoomId = 1,
                Year = new DateTime(2020,03,12)
      
            }
        };

        public void Seed(EntityTypeBuilder<Furniture> builder) => builder.HasData(furnitures);
    }


}

