using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AbaqusExtension
{
    public class aElement : aIWritable
    {
        private aNode[] nodes;
        private aElemTypes type;
        private int id;
        private bool isCostal;
        private aPoint centroid;
        private bool isOriented;

        /// <summary>
        /// Creates an instance of an element with aNode objects
        /// </summary>
        public aElement(int ID, aElemTypes type, aNode[] nodes)
        {
            this.type = type;
            this.id = ID;
            this.nodes = nodes;

            isOriented = false;

            GetCentroid();

            //for (int i = 0; i < nodes.Length; i++)
            //{
            //    nodes[i].JoinElement(this);
            //}
                  
        }

        /// <summary>
        /// Creates an instance of an element from node numbers
        /// </summary>
        public aElement(int ID, aElemTypes type, int[] nodes)
        {
            isOriented = false;
            throw new System.NotImplementedException();
        }

        public aPoint Centroid
        {
            get
            {
                return this.centroid;
            }
        }

        public aElemTypes Type
        {
            get
            {
                return this.type;
            }
        }

        public aNode[] Nodes
        {
            get
            {
                return this.nodes;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// True if the element has no neighbour at least at one edge
        /// </summary>
        public bool IsCostal
        {
            get
            {
                return this.isCostal;
            }
            set
            {
                this.isCostal = value;
            }
        }

        /// <summary>
        /// True if orientation and section has been assigned.
        /// </summary>
        public bool IsOriented
        {
            get
            {
                return isOriented; 
            }

            set
            {
                isOriented = value;
            }
        }

        public static implicit operator int(aElement e)
        {
            return e.ID;
        }

        public aPoint GetCentroid()
        {
            int n;
            //double[] X;
            //double[] Y;
            //double[] Z;
            double C_x = 0.0, C_y = 0.0, C_z = 0.0;

            if (100 <= (int)type && (int)type < 200)  // 2D elements have been given enum values between 100 and 199
            {
                if (100 < (int)type && (int)type < 140)  // 2D quadrilateral elements (first four nodes to be used)
                    n = 4;
                else if (140 <= (int)type && (int)type < 180) // Triangular
                    n = 3;
                else
                    throw new Exception("Centroid cannot be calculated for this element type.\n" + this.ToString());

                for (int i = 0; i < n; i++)
                {
                    C_x += nodes[i].Location.X;
                    C_y += nodes[i].Location.Y;
                }

                C_x /= n;
                C_y /= n;

                //X = Y = Z = new double[n];

                //for (int i = 0; i < n-1; i++)
                //{
                //    X[i] = nodes[i].Location.X;
                //    Y[i] = nodes[i].Location.Y;
                //    Z[i] = nodes[i].Location.Z;
                //}
                //X[n - 1] = nodes[0].Location.X;
                //Y[n - 1] = nodes[0].Location.Y;
                //Z[n - 1] = nodes[0].Location.Z;


                //for (int i = 0; i < n - 1; i++)
                //    A += (X[i] * Y[i + 1] - X[i + 1] * Y[i]);
                //A /= 2;

                //for (int i = 0; i < n - 1; i++)
                //{
                //    C_x += (X[i] + X[i + 1]) * (X[i] * Y[i + 1] - X[i + 1] * Y[i]);
                //    C_y += (Y[i] + Y[i + 1]) * (X[i] * Y[i + 1] - X[i + 1] * Y[i]);
                //}
                //C_x /= 6 * A;
                //C_y /= 6 * A;
            }
            else if (200 <= (int)type && (int)type < 300)  // 3D elements have been given enum values between 200 and 299
            {
                if (200 < (int)type && (int)type < 220)  // Hexahedron
                    n = 8;
                else if (220 <= (int)type && (int)type < 240)  // Wedge
                    n = 6;
                else if (240 <= (int)type && (int)type < 260)  // Tetrahedron
                    n = 4;
                else
                    throw new Exception("Centroid cannot be calculated for this element type.\n" + this.ToString());

                //X = Y = Z = new double[n];
                for (int i = 0; i < n; i++)
                {
                    C_x += nodes[i].Location.X;
                    C_y += nodes[i].Location.Y;
                    C_z += nodes[i].Location.Z;
                }

                C_x /= n;
                C_y /= n;
                C_z /= n;
            }

            centroid = new aPoint(C_x, C_y, C_z);
            return centroid;
        }

        public void Write(System.IO.StreamWriter Canvas)
        {
            Canvas.Write(this.ID + ",\t");

            for (int i = 0; i < nodes.Length; i++)
            {
                if (i == nodes.Length - 1)
                    Canvas.WriteLine(nodes[i].ID);
                else
                    Canvas.Write(nodes[i].ID + ",\t");
            }
        }

        internal void JoinNode(aNode node)
        {
            List<aNode> nds = new List<aNode>();

            if (this.nodes != null)
            {
                nds.AddRange(this.nodes);

                foreach (aNode n in nds)
                    if (n == node)
                        return;
            }
            nds.Add(node);

            this.nodes = nds.ToArray();
        }

        internal void RefreshCentroid()
        {
            double[] x = new double[nodes.Length];
            double[] y = new double[nodes.Length];
            double A = 0;
            double cx = 0, cy = 0;

            for (int i = 0; i < nodes.Length; i++)
            {
                x[i] = nodes[i].Location.X;
                y[i] = nodes[i].Location.Y;
            }

            for (int i = 0; i < x.Length - 1; i++)
            {
                A += x[i] * y[i + 1] - x[i + 1] * y[i];
                cx += (x[i] + x[i + 1]) * (x[i] * y[i + 1] - x[i + 1] * y[i]);
                cy += (y[i] + y[i + 1]) * (x[i] * y[i + 1] - x[i + 1] * y[i]);
            }

            A += x[x.Length - 1] * y[0] - x[0] * y[y.Length - 1];
            cx += (x[x.Length - 1] + x[0]) * (x[x.Length - 1] * y[0] - x[0] * y[x.Length - 1]);
            cy += (y[y.Length - 1] + y[0]) * (x[y.Length - 1] * y[0] - x[0] * y[y.Length - 1]);

            A *= 0.5;
            cx /= 6 * A;
            cy /= 6 * A;

            this.centroid = new aPoint(cx, cy);
        }

        internal bool IsWithIn(double xMin, double xMax, double yMin, double yMax, double precision)
        {
            foreach (aNode n in this.nodes)
            {
                if (xMax + precision - n.Location.X < 0.0)
                    return false;
                if (yMax + precision - n.Location.Y < 0.0)
                    return false;
                if (xMin - precision - n.Location.X > 0.0)
                    return false;
                if (yMin - precision - n.Location.Y > 0.0)
                    return false;
            }

            return true;
        }

        internal bool IsWithIn(aPoint origin, aPoint rotation, double xMin, double xMax, double yMin, double yMax, double p)
        {
            foreach (aNode n in this.nodes)
            {
                
            }

            return true;
        }

        public override string ToString()
        {
            return ("ID: " + this.id.ToString() + ",\tType: " + type.ToString());
        }
    }
}
