using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore
{
    public class Cursor
    {
        public int y;
        public int min;
        public int max;
        public Cursor(int y, int min, int max)
        {
            this.y = y;
            this.min = min;
            this.max = max;
        }
    }
}
