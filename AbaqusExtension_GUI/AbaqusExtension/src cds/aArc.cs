using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public struct aArc : aI2DcurveInSpace
    {
        private double th_i;
        private double th_f;
        private aPoint center;
        private double r;
        private aPoint end;
        private aPoint start;
        private aPoint thirdPt;
        private int id;

        public double Radius
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }

        /// <summary>
        /// Gets or sets the center of the arc in the local coordinates
        /// </summary>
        public aPoint Center
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }

        /// <summary>
        /// Gets or sets the smaller CCW angle from +ve X in radians bounding the arc.
        /// </summary>
        public double Theta_i
        {
            get
            {
                return th_i;
            }

            set
            {
                int r = (int)(Math.Abs(value) / (Math.PI * 2));
                double v = Math.Abs(value) - r * Math.PI * 2;

                if ((0 <= v && v <= Math.PI && 0 <= th_f && th_f <= Math.PI) || (Math.PI <= v && v <= Math.PI * 2 && Math.PI <= th_f && th_f <= Math.PI * 2))
                    this.th_i = v;
                else
                    throw new Exception("An arc cannot be defined in such a way that it is unique at every x value.");
            }
        }

        /// <summary>
        /// Gets or sets the larger CCW angle from +ve X in radians bounding the arc.
        /// </summary>
        public double Theta_f
        {
            get
            {
                return this.th_f;
            }

            set
            {
                int r = (int)(Math.Abs(value) / (Math.PI * 2));
                double v = Math.Abs(value) - r * Math.PI * 2;

                if ((0 <= v && v <= Math.PI && 0 <= th_i && th_i <= Math.PI) || (Math.PI <= v && v <= Math.PI * 2 && Math.PI <= th_i && th_i <= Math.PI * 2))
                    this.th_f = v;
                else
                    throw new Exception("An arc cannot be defined in such a way that it is unique at every x value.");
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

        public aCurveTypes CurveType
        {
            get
            {
                return aCurveTypes.Arc;
            }
        }

        /// <summary>
        /// Gets or sets a third point defining the arc together with the start and end.
        /// </summary>
        public aPoint ThirdPt
        {
            get
            {
                return thirdPt;
            }

            set
            {
                thirdPt = value;
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

        public bool IsAbove(aPoint P, aPoint origin, aPoint pointOnX)
        {
            aPoint C = ProjectionOf(P, origin, pointOnX);
            if (P.Y >= C.Y)
                return true;
            else
                return false;
        }

        public aPoint ProjectionOf(aPoint P, aPoint origin, aPoint pointOnX)
        {
            //aPoint p_t = aPoint.Transform(origin, pointOnX, P);

            //if (p_t.X < End || p_t.X > Start)
            //    throw new Exception("The point lies outside the range of the arc.");

            //aPoint C = new aPoint();
            //C.X = P.X;
            //double m = Math.Sqrt(r * r - Math.Pow(C.X - center.X, 2));
            //double th_1 = Math.Asin(m / r);
            //double th_2 = Math.Asin(-m / r);

            //if (th_i <= th_1 && th_1 <= th_f)
            //    C.Y = center.Y + m;
            //else
            //    C.Y = center.Y - m;

            //return C;

            throw new NotImplementedException();
        }

        internal List<aPoint> GetSegments(double segLength)
        {
            List<aPoint> seg = new List<aPoint>();
            //List<aPoint> seg2 = new List<aPoint>();
            aPoint orig = center;
            aPoint u = end;
            aPoint v = start;

            aPoint S = aPoint.Transform(orig, u, v, start);
            aPoint E = aPoint.Transform(orig, u, v, end);
            aPoint O = aPoint.Transform(orig, u, v, center);

            //S.Z = E.Z = O.Z = 0.0;  //Just to remove small numbers resulting from precision error.

            double r, theta, theta_n;
            int n;

            r = E.X;
            theta = Math.Atan(S.Y / S.X);
            n = (int)(Math.Round(r * theta / segLength, 0));
            theta_n = theta / n;

            for (int i = 0; i < n + 1; i++, theta -= theta_n)
                seg.Add(new aPoint(r * Math.Cos(theta), r * Math.Sin(theta), O.Z));

            //System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\temp\\tow" + id.ToString() + ".scr");
            //sw.WriteLine("3DPOLY");

            for (int i = 0; i < seg.Count; i++)
            {
                seg[i] = aPoint.Transform(orig, u, v, seg[i], true);

                //sw.Write(seg[i].X + ",");
                //sw.Write(seg[i].Y + ",");
                //sw.WriteLine(seg[i].Z);
            }
            //sw.WriteLine();
            //sw.Close();

            return seg;
        }
    }
}