using DAL.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamworkSystem.DataAccessLayer.Interfaces;

namespace DAL.Seeding
{

    public class RoomSeeder : ISeeder<Room>
    {
        private static readonly List<Room> rooms = new()
        {
            new Room
            {
                Id = 1,
                Numder = 116,
                BedsNumder = 2,
                Payment = 2000,
                DormintoryId = 1

            }
        };

        public void Seed(EntityTypeBuilder<Room> builder) => builder.HasData(rooms);
    }


}

