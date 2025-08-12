using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public struct aPoint
    {
        private bool is2D;
        private double z;
        private double x;
        private double y;
        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
                this.is2D = false;
            }
        }

        public aPoint(string xyz)
        {
            this = new aPoint();

            string[] x_y_z = xyz.Split(',');
            x = double.Parse(x_y_z[0]);
            y = double.Parse(x_y_z[1]);
            z = double.Parse(x_y_z[2]);
        }

        public aPoint(double x, double y)
        {
            this = new aPoint();
            // TODO: Complete member initialization
            this.x = x;
            this.y = y;
        }

        public aPoint(double x, double y, double z)
        {
            this = new aPoint();
            // TODO: Complete member initialization
            this.X = x;
            this.Y = y;
            this.z = z;
            this.is2D = false;
        }

        public bool Is2D
        {
            get
            {
                return this.is2D;
            }
        }

        //public aPoint Transform(aPoint origin, double angle)
        //{
        //    if (!this.is2D)
        //        throw new NotImplementedException();

        //    aPoint newPt = new aPoint();

        //    newPt.x = (this.y - origin.y) * Math.Sin(angle) + (this.x - origin.x) * Math.Cos(angle);
        //    newPt.y = (this.y - origin.y) * Math.Cos(angle) + (this.x - origin.x) * Math.Sin(angle);

        //    return newPt;
        //}

        /// <summary>
        /// Transforms a point to a cartesian coordinate system given by parameters in the same system.
        /// </summary>
        /// <param name="origin">Origin of the new system in coordinates</param>
        /// <param name="u">A point on the x axis of the new coord. system</param>
        /// <param name="v">A point on the y axis of the new coord. system</param>
        /// <param name="P">The point to be transformed.</param>
        //public static aPoint Transform(aPoint origin, aPoint u, aPoint v, aPoint P)
        //{
        //    aPoint PP, PPP, uu, vv, ww, n_u, n_v, n_w;
        //    PP = PPP = uu = vv = ww = n_u = n_v = n_w = new aPoint();
        //    double mag_uu, mag_vv, mag_ww;

        //    uu.x = u.x - origin.x;
        //    uu.y = u.y - origin.y;
        //    uu.z = u.z - origin.z;
        //    vv.x = v.x - origin.x;
        //    vv.y = v.y - origin.y;
        //    vv.z = v.z - origin.z;
        //    ww.x = uu.y * vv.z - uu.z * vv.y;
        //    ww.y = -(uu.x * vv.z - uu.z * vv.x);
        //    ww.z = uu.x * vv.y - uu.y * vv.x;

        //    //double[,] A = { { uu.x, uu.y, uu.z},
        //    //                {vv.x, vv.y, vv.z },
        //    //                {ww.x, ww.y, ww.z } };

        //    mag_uu = Math.Sqrt(uu.x * uu.x + uu.y * uu.y + uu.z * uu.z);
        //    mag_vv = Math.Sqrt(vv.x * vv.x + vv.y * vv.y + vv.z * vv.z);
        //    mag_ww = Math.Sqrt(ww.x * ww.x + ww.y * ww.y + ww.z * ww.z);

        //    //for(int i =0;i<3;i++)
        //    //{
        //    //    A[0, i] /= mag_uu;
        //    //    A[1, i] /= mag_vv;
        //    //    A[2, i] /= mag_ww;
        //    //}

        //    n_u.x = uu.x / mag_uu;
        //    n_u.y = uu.y / mag_uu;
        //    n_u.z = uu.z / mag_uu;
        //    n_v.x = vv.x / mag_vv;
        //    n_v.y = vv.y / mag_vv;
        //    n_v.z = vv.z / mag_vv;
        //    n_w.x = ww.x / mag_ww;
        //    n_w.y = ww.y / mag_ww;
        //    n_w.z = ww.z / mag_ww;

        //    PP.x = P.x - origin.x;
        //    PP.y = P.y - origin.y;
        //    PP.z = P.z - origin.z;

        //    PPP.x = n_u.x * PP.x + n_u.y * PP.y + n_u.z * PP.z;
        //    PPP.y = n_v.x * PP.x + n_v.y * PP.y + n_v.z * PP.z;
        //    PPP.z = n_w.x * PP.x + n_w.y * PP.y + n_w.z * PP.z;

        //    return PPP;
        //}

        /// <summary>
        /// Transforms a point to a cartesian coordinate system given by parameters in the same system.
        /// </summary>
        /// <param name="origin">Origin of the new system in coordinates</param>
        /// <param name="u">A point on the x axis of the new coord. system</param>
        /// <param name="v">A point on the y axis of the new coord. system</param>
        /// <param name="P">The point to be transformed.</param>
        /// <param name="transformBack">If true, the transformation is back to global coords.</param>
        //public static aPoint Transform(aPoint origin, aPoint u, aPoint v, aPoint P, bool transformBack)
        //{
        //    aPoint uu, vv, ww, _u, _v;
        //    uu = vv = ww = _u = _v = new aPoint();

        //    uu.x = u.x - origin.x;
        //    uu.y = u.y - origin.y;
        //    uu.z = u.z - origin.z;
        //    vv.x = v.x - origin.x;
        //    vv.y = v.y - origin.y;
        //    vv.z = v.z - origin.z;
        //    ww.x = uu.y * vv.z - uu.z * vv.y;
        //    ww.y = -(uu.x * vv.z - uu.z * vv.x);
        //    ww.z = uu.x * vv.y - uu.y * vv.x;

        //    _u.x = u.x;
        //    _u.y = v.x;
        //    _u.z = ww.x + origin.x;

        //    _v.x = u.y;
        //    _v.y = v.y;
        //    _v.z = ww.y + origin.y;

        //    origin.x *= -1;
        //    origin.y *= -1;
        //    origin.z *= -1;

        //    return Transform(origin, _u, _v, P);
        //}

        //public static aPoint Transform(aPoint origin, aPoint u, aPoint v, aPoint P)
        //{
        //    double[] T = { origin.x, origin.y, origin.z };

        //}

        public static aPoint Transform(aPoint origin, aPoint u, aPoint v, aPoint P, bool transformBack = false)
        {
            aPoint PP, PPP, uu, vv, ww, n_u, n_v, n_w;
            PP = PPP = uu = vv = ww = n_u = n_v = n_w = new aPoint();
            double mag_uu, mag_vv, mag_ww;

            uu.x = u.x - origin.x;
            uu.y = u.y - origin.y;
            uu.z = u.z - origin.z;
            vv.x = v.x - origin.x;
            vv.y = v.y - origin.y;
            vv.z = v.z - origin.z;
            //ww.x = uu.y * vv.z - uu.z * vv.y;
            //ww.y = -(uu.x * vv.z - uu.z * vv.x);
            //ww.z = uu.x * vv.y - uu.y * vv.x;
            ww = CrossProduct(uu, vv);
            vv = CrossProduct(ww, uu);

            mag_uu = Math.Sqrt(uu.x * uu.x + uu.y * uu.y + uu.z * uu.z);
            mag_vv = Math.Sqrt(vv.x * vv.x + vv.y * vv.y + vv.z * vv.z);
            mag_ww = Math.Sqrt(ww.x * ww.x + ww.y * ww.y + ww.z * ww.z);


            if (transformBack)
            {

                double[,] A = { { uu.x, uu.y, uu.z},
                            {vv.x, vv.y, vv.z },
                            {ww.x, ww.y, ww.z } };

                for (int i = 0; i < 3; i++)
                {
                    A[0, i] /= mag_uu;
                    A[1, i] /= mag_vv;
                    A[2, i] /= mag_ww;
                }
                Matrix AA = new Matrix(A);
                AA = AA.Inverse();

                PP.x = AA[0, 0, true] * P.x + AA[0, 1, true] * P.y + AA[0, 2, true] * P.z;
                PP.y = AA[1, 0, true] * P.x + AA[1, 1, true] * P.y + AA[1, 2, true] * P.z;
                PP.z = AA[2, 0, true] * P.x + AA[2, 1, true] * P.y + AA[2, 2, true] * P.z;

                PPP.x = PP.x + origin.x;
                PPP.y = PP.y + origin.y;
                PPP.z = PP.z + origin.z;
            }
            else
            {
                n_u.x = uu.x / mag_uu;
                n_u.y = uu.y / mag_uu;
                n_u.z = uu.z / mag_uu;
                n_v.x = vv.x / mag_vv;
                n_v.y = vv.y / mag_vv;
                n_v.z = vv.z / mag_vv;
                n_w.x = ww.x / mag_ww;
                n_w.y = ww.y / mag_ww;
                n_w.z = ww.z / mag_ww;


                PP.x = P.x - origin.x;
                PP.y = P.y - origin.y;
                PP.z = P.z - origin.z;

                PPP.x = n_u.x * PP.x + n_u.y * PP.y + n_u.z * PP.z;
                PPP.y = n_v.x * PP.x + n_v.y * PP.y + n_v.z * PP.z;
                PPP.z = n_w.x * PP.x + n_w.y * PP.y + n_w.z * PP.z;
            }
            return PPP;
        }

        private static aPoint CrossProduct(aPoint u, aPoint v)
        {
            aPoint w = new aPoint();
            w.x = u.y * v.z - u.z * v.y;
            w.y = -(u.x * v.z - u.z * v.x);
            w.z = u.x * v.y - u.y * v.x;
            return w;
        }

        public bool Equals(aPoint p)
        {
            if (p.x == x && p.y == y && p.z == z)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return (x + ", " + y + ", " + z);
        }
    }
}
