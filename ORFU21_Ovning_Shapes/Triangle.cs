using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Ovning_Shapes
{
    class Triangle: IShape
    {

        public int height;
        public int width;

        public double GetArea()
        {
            double svar = (height * width) / 2.0;
            return svar;
        }
    }
}
