using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Dormitory : BaseEntity
    {
        public int? Number { get; set; }
        public string? Manager { get; set; }
        public int? FloorsNumber { get; set; }
        public int? RoomsNumber { get; set; }
        public DateTime? Year { get; set; }
        public string? Address { get; set; }

        public List<Room>? Rooms { get; set; }
    }
}
