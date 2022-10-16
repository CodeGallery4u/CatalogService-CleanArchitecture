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
        public Category CategoryOfProduct { get; set; }
    }
}
