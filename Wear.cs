using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3.Wear
{
    public class Wear : StoreItem
    {
        public override string Name { get; set; }
        public override string? Description { get; set; }
        public WearSize Size { get; set; }
        public string? BrandName { get; set; }
    }
}
