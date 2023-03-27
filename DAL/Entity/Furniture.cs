using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Furniture : BaseEntity
    {
        public int? RoomId { get; set; }
        public Int64? code { get; set; }
        public string? Item { get; set; }
        public DateTime? Year { get; set; }

    }
}
