using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    internal class SportsBars : Food, IHasShelfLife
    {
        public DateTime ExpirationDate { get; init; }
    }
}
