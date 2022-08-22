using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Wear
{
    public class Jackets : Wear, IHasWaterproof
    {
        public bool IsWaterproof { get; init; }
    }
}
