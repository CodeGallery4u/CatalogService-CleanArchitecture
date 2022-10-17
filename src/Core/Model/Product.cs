using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Product : BaseEntity
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public uint Amount { get; set; }
        public int CategoryId { get; set; }
        public Category CategoryOfProduct { get; set; }
    }
}
