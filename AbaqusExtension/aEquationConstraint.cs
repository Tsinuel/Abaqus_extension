using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public class aEquationConstraint : aIWritable
    {
        private List<double> coeffs = new List<double>();
        private List<aNodeSet> sets = new List<aNodeSet>();
        private List<int> dOFs = new List<int>();
        bool isTransformed;
        private int constrainedDxn;
        private aPoint origin;
        private aPoint v;
        private aPoint u;
        int numOfNodes = 0;

        public aEquationConstraint(int constrainedDxn)
        {
            isTransformed = false;
            this.constrainedDxn = constrainedDxn;
        }

        /// <param name="constrainedDxn">The direction (x=1, y=2, z=3) in which nodes matched between multiple sets</param>
        /// <param name="origin">Origin of the coordinate system</param>
        /// <param name="u">A point in x direction of the coordinate system</param>
        /// <param name="v">A point in xy plane (except x axis) of the coordinate system</param>
        public aEquationConstraint(int constrainedDxn, aPoint origin, aPoint u, aPoint v)
        {
            isTransformed = true;
            this.constrainedDxn = constrainedDxn;
            this.origin = origin;
            this.u = u;
            this.v = v;
        }

        void aIWritable.Write(StreamWriter Canvas)
        {
            
        }

        /// <summary>
        /// Adds an equation term based on coefficient, node set and degree of freedom
        /// </summary>
        public void AddTerm(double coeff, aNodeSet set, int DOF)
        {
            if (numOfNodes > 1)
            {
                if (set.Members.Count != numOfNodes)
                    throw new Exception("Number of nodes must match between multiple terms of a constraint equation.");
            }
            else if (set.Members.Count > 1)
                numOfNodes = set.Members.Count;

            if (DOF != 1 && DOF != 2 && DOF != 3)
                throw new ArgumentException("Invalid degree of freedom: " + DOF);

            coeffs.Add(coeff);
            sets.Add(set);
            dOFs.Add(DOF);
        }

        public void AddTerm(double coeff, aNode node, int DOF)
        {
            throw new NotImplementedException();

            //aNodeSet nset = new aNodeSet(node);


        }
    }
}