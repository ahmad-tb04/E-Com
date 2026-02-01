using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com.Core.Entities.Product
{
    public class Category : BaseEntity<int>
    {
        public string? Description { get; set; }
    }
}
