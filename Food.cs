using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    internal class Food : StoreItem
    {
        public override string Name { get; set; }
        public override string? Description { get; set; }
    }
}
