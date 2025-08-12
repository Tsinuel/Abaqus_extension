using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public interface aI2DcurveInSpace
    {
        aPoint End { get; set; }
        aPoint Start { get; set; }
        aCurveTypes CurveType { get; }
        int ID { get; set; }

        bool IsAbove(aPoint P, aPoint origin, aPoint pointOnX);
    }
}