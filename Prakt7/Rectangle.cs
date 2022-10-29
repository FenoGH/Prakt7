using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt7
{
            class Rectangle : Pair
        {
        /// <summary>
        /// Операция нахождения площади прямоугольника S=a*b
        /// </summary>
        /// <param name="value1">Значение сторон прямоугольника(a,b)</param>
        /// <returns>Возвращаемое значение result результать операции нахождение площади</returns>
            public Rectangle Sqare(Rectangle value1)
            {
                Rectangle result = new Rectangle();
                result.para1 = value1.Para1 * value1.Para2;
                return result;
            }
        /// <summary>
        /// Операция нахождения периметра прямоугольника P=2(a*b)
        /// </summary>
        /// <param name="value1">Значение сторон прямоугольника(a,b)</param>
        /// <returns>Возвращаемое значение result результать операции нахождение периметра</returns>
        public Rectangle RectP(Rectangle value1)
            {
                Rectangle result = new Rectangle();
                result.para1 = 2 * (value1.Para1 * value1.Para2);
                return result;
            }
        }
   
}
