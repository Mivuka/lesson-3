using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    public interface IHasShelfLife
    {
        public DateTime ExpirationDate { get; init; }
    }
}
