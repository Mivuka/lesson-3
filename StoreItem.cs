using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    public abstract class StoreItem
    {
        public Guid Id { get; }
        public abstract string Name { get; set; }
        public abstract string? Description { get; set; }
        
    }
}
