using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AbaqusExtension
{
    public class aAssembly
    {
        private double precision = 1E-5;
        private List<aNode> nodes = new List<aNode>();
        private List<aElement> elements = new List<aElement>();
        private aIO iOmanager;
        private bool is2D;
        private List<string> materials = new List<string>();
        private List<aTow> tows = new List<aTow>();
        private List<aSection> sections = new List<aSection>();
        private List<aOrientation> orientations = new List<aOrientation>();
        private List<aElset> elsets = new List<aElset>();
        private double elemGroupingLength;

        public aAssembly(string inpFile, bool is2D)
        {
            this.iOmanager = new aIO(inpFile, this);
            this.is2D = is2D;


        }

        public double Precision
        {
            get
            {
                return this.precision;
            }
            set
            {
                this.precision = value;
            }
        }

        public List<aElement> Elements
        {
            get
            {
                return this.elements;
            }
        }

        public List<aNode> Nodes
        {
            get
            {
                return this.nodes;
            }
        }

        public List<aSection> Sections
        {
            get
            {
                return sections;
            }
        }

        public List<aOrientation> Orientations
        {
            get
            {
                return orientations;
            }
        }

        public List<aElset> Elsets
        {
            get
            {
                return elsets;
            }
        }

        /// <summary>
        /// Gets the file reader and writer of the current assembly.
        /// </summary>
        public aIO IOmanager
        {
            get
            {
                return this.iOmanager;
            }
        }

        /// <summary>
        /// Gets whether the model is 2D or 3D.
        /// </summary>
        public bool Is2D
        {
            get
            {
                return is2D;
            }
        }

        /// <summary>
        /// Gets the collection of the material names.
        /// </summary>
        public List<string> Materials
        {
            get
            {
                return materials;
            }
        }

        /// <summary>
        /// Gets the list of tows defined in the assembly
        /// </summary>
        public List<aTow> Tows
        {
            get
            {
                return tows;
            }
        }

        /// <summary>
        /// Gets or sets the length along tow paths over which all elements are given the same orientation.
        /// </summary>
        public double ElemGroupingLength
        {
            get
            {
                return elemGroupingLength;
            }

            set
            {
                elemGroupingLength = value;
            }
        }

        private void FillCentroid()
        {
            foreach (aElement el in elements)
            {
                el.RefreshCentroid();
            }
        }

        private void Interrelate()
        {
            foreach (aElement e in elements)
            {
                foreach (aNode n in e.Nodes)
                {
                    n.JoinElement(e);
                    e.JoinNode(n);
                }
            }
        }

        private aNode GetNode(int id)
        {
            foreach (aNode n in nodes)
            {
                if (n.ID == id)
                    return n;
            }

            throw new Exception("The node cannot be found! The requested id was:" + id.ToString());
        }

        internal void Initialize()
        {
            nodes = new List<aNode>();
            elements = new List<aElement>();
            materials = new List<string>();
        }

        private void ReadNode(List<string> bulk)
        {
            int lineNo = 0;
        A:
            for (; lineNo < bulk.Count; lineNo++)
            {
                if (bulk[lineNo].StartsWith("*Node", true, null))
                {
                    lineNo++;
                    break;
                }
            }

            for (; lineNo < bulk.Count; lineNo++)
            {
                if (bulk[lineNo][0] == '*' && bulk[lineNo][1] == '*')
                    continue;
                if (bulk[lineNo][0] == '*')
                    break;

                string[] nodeLine = bulk[lineNo].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                nodes.Add(new aNode(int.Parse(nodeLine[0]), new aPoint(double.Parse(nodeLine[1]), double.Parse(nodeLine[2]))));
            }

            for (; lineNo < bulk.Count; lineNo++)
                if (bulk[lineNo].StartsWith("*Node", true, null))
                    goto A;
        }

        internal void AssignOrientation()
        {
            foreach (aTow tow in tows)
            {
                tow.AssignOrientation();
            }
        }

        public static bool IsCommand(string parameter)
        {
            if (parameter == null)
                return false;
            if (parameter == "")
                return false;
            if (parameter[0] == '*' && parameter[1] != '*')
                return true;

            return false;
        }

        internal void RemoveTow(int id)
        {
            for (int i = 0; i < tows.Count; i++)
            {
                if (i == id - 1)
                {
                    tows.RemoveAt(i);
                    break;
                }
            }

            RefreshTowID();
        }

        public void Write(string outputFile)
        {
            //foreach (aNode n in nodes)
            //    n.Write(Canvas);

            //foreach (aElement e in elements)
            //    e.Write(Canvas);

            StreamWriter Canvas = new StreamWriter(outputFile);

            foreach (var elset in elsets)
                elset.Write(Canvas);

            foreach (var sect in sections)
                sect.Write(Canvas);

            foreach (var ori in orientations)
                ori.Write(Canvas);

            Canvas.Close();
        }

        public void RefreshTowID()
        {
            for(int i = 0;i<tows.Count;i++)
                tows[i].SetID(i + 1);
        }

        internal aElement GetElement(int id)
        {
            for (int i = 0; i < elements.Count; i++)
                if (elements[i].ID == id)
                    return elements[i];

            throw new Exception("Element number " + id + " could not be found.");
        }
    }
}
