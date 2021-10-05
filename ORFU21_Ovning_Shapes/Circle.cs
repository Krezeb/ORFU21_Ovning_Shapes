using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Ovning_Shapes
{
    class Circle: IShape
    {

        public int diameter;

        public double GetArea()
        {
            //area = π · r2
            double r = diameter / 2;
            double r2 = r * r;

            return Math.PI * r2;
        }
    }
}
