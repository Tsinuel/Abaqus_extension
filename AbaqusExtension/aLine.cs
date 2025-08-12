using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public struct aLine : aI2DcurveInSpace
    {
        private aPoint end;
        private int id;
        private aPoint start;

        public aCurveTypes CurveType
        {
            get
            {
                return aCurveTypes.Line;
            }
        }

        public aPoint End
        {
            get
            {
                return end;
            }
            set
            {
                end = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public aPoint Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
            }
        }

        public bool IsAbove(aPoint P, aPoint origin, aPoint pointOnX)
        {
            throw new NotImplementedException();
        }
    }
}