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
                Inmates = new List<Inmate> { new Inmate { Id = 1},new Inmate { Id = 2} },
                Furnitures = new List<Furniture> { new Furniture {  Id = 1 } }

            }
        };

        public void Seed(EntityTypeBuilder<Room> builder) => builder.HasData(rooms);
    }


}

