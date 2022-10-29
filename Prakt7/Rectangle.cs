using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt7
{
            class Rectangle : Pair
        {

            public Rectangle Sqare(Rectangle value1)
            {
                Rectangle result = new Rectangle();
                result.para1 = value1.Para1 * value1.Para2;
                return result;
            }
            public Rectangle RectP(Rectangle value1)
            {
                Rectangle result = new Rectangle();
                result.para1 = 2 * (value1.Para1 * value1.Para2);
                return result;
            }
        }
   
}
