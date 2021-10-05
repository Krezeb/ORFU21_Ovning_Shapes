using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Ovning_Shapes
{
    class Square: IShape
    {

        public int side;

        public double GetArea()
        {
            return side * side;
        }
    }
}

//•	I klassen Square skriver du en implementation för GetArea-metoden så att den returnerar Side* Side (arean av en fyrkant).