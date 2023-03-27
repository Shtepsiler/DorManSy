using System;
using System.Threading.Tasks;


namespace DAL.Interfaces
{
    public interface IUnitOfWork 
    {
         IDormitoryRepository _dormitoryRepository { get;  }
         IFurnitureRepository _furnitureRepository { get;  }
         IInmateRepository _inmateRepository { get;  }
         IRoomRepository _roomRepository { get; }

        Task SaveChangesAsync();
    }
}
