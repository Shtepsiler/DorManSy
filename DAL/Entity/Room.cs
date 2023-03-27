using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Room : BaseEntity
    {
        public int DormintoryId { get; set; }
        public int? Numder { get; set; }
        public int? BedsNumder { get; set; }
        public double? Payment { get; set;}

        public List<Inmate>? Inmates { get; set; }

        public List<Furniture>? Furnitures { get; set; }
    }
}
