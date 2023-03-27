using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Inmate:BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Status { get; set; }
        public bool? isPaid { get; set; }
        public int? RoomId { get; set; }
    }
}
