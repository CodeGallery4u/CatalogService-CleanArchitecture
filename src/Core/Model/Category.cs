using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Category : BaseEntity
    {
        public Category ParentCategory { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
