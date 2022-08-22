using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Wear
{
    public class Wear : StoreItem
    {
        public WearSize Size { get; set; }
        public string? BrandName { get; set; }
    }
}
