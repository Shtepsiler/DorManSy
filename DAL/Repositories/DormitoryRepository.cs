using DAL.Data;
using DAL.Entity;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DormitoryRepository : GenericRepository<Dormitory>, IDormitoryRepository
    {
        public DormitoryRepository(MyDbContext  context) : base(context)
        {
        }

/*        public override Task<Dormitory> GetCompleteEntityAsync(int id)
        {
            throw new NotImplementedException();
        }*/
    }
}
