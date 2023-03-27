using DAL.Data;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repositories
{

    public class UnitOfWork : IUnitOfWork
    {
        protected readonly MyDbContext databaseContext;

        public IDormitoryRepository _dormitoryRepository { get;  }
        public IFurnitureRepository _furnitureRepository { get;  }
        public IInmateRepository _inmateRepository { get;  }
        public IRoomRepository _roomRepository { get; } 



        public async Task SaveChangesAsync()
        {
            await databaseContext.SaveChangesAsync();
        }


        public UnitOfWork(
            MyDbContext databaseContext,
       IDormitoryRepository UnitOfWorkRepository ,
       IFurnitureRepository furnitureRepository,
       IInmateRepository inmateRepository,
       IRoomRepository roomRepository )
        {
            this.databaseContext = databaseContext;
            _dormitoryRepository = UnitOfWorkRepository;
            _furnitureRepository = furnitureRepository;
            _inmateRepository = inmateRepository;
            _roomRepository = roomRepository;
           
        }
    }
}
