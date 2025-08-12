using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public class aNodeSet : aIWritable
    {
        private List<int> memberIDs = new List<int>();
        private List<aNode> members = new List<aNode>();
        private string name;
        private bool isInGenerateMode;
        private aAssembly assembly;

        /// <summary>
        /// Creates an instance of node set
        /// </summary>
        /// <param name="name">The name of the node set</param>
        /// <param name="isInGenerateMode">Tells if the set is generated automatically</param>
        /// <param name="assembly">The assembly owning the node set</param>
        public aNodeSet(string name, bool isInGenerateMode, aAssembly assembly)
        {
            this.name = name;
            this.isInGenerateMode = isInGenerateMode;
            this.assembly = assembly;
        }

        internal aNodeSet(aNode node)
        {
            name = "Set_" + node.ID;
            members.Add(node);
        }

        /// <summary>
        /// Gets the members of the node set
        /// </summary>
        public List<aNode> Members
        {
            get
            {
                return members;
            }
        }

        /// <summary>
        /// Gets or sets the name of the node set
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Gets the sourceValue if the set is accepting members by generating in ranges
        /// </summary>
        internal bool IsInGenerateMode
        {
            get
            {
                return isInGenerateMode;
            }
            set
            {
                isInGenerateMode = value;
            }
        }

        /// <summary>
        /// Gets the assembly to which the node set belongs
        /// </summary>
        internal aAssembly Assembly
        {
            get
            {
                return assembly;
            }
        }

        public void Write(System.IO.StreamWriter Canvas)
        {
            Canvas.WriteLine("*Nset, nset=" + name);

            int width = 16;
            int FullLines = members.Count / width;
            int count = 0;

            for (int i = 0; i < FullLines; i++)
            {
                for (int j = 0; j < width - 1; j++)
                    Canvas.Write(members[count++].ID + ", ");
                Canvas.WriteLine(members[count++].ID);
            }

            if (FullLines * 16 < members.Count)
            {
                for (; count < members.Count - 1;)
                    Canvas.Write(members[count++].ID + ", ");
                Canvas.WriteLine(members[count++]);
            }

        }

        /// <summary>
        /// Generates node set members by generating the nodes from n1 to n2 with i increment.
        /// </summary>
        /// <param name="n1">Start node number</param>
        /// <param name="n2">End node number</param>
        /// <param name="i">increment</param>
        public void Add(int n1, int n2, int i)
        {
            if (n1 < 1 || n2 < 1 || i < 1 || n1 > n2)
                throw new ArgumentException("Invalid node generation data in " + name + " node set");

            for (int id = n1; id <= n2; id += i)
            {
                memberIDs.Add(id);
            }
        }

        /// <summary>
        /// Adds a single node with a given ID to the set
        /// </summary>
        /// <param name="iD">ID number of the node to be added</param>
        public void Add(int iD)
        {
            if (iD > 0)
                memberIDs.Add(iD);
            else
                throw new ArgumentException("Node ID cannot be zero or negative.");
        }

        /// <summary>
        /// Generates node set members by generating the nodes from n1 to n2 with increment of one
        /// </summary>
        /// <param name="n1">Start node number</param>
        /// <param name="n2">End node number</param>
        public void Add(int n1, int n2)
        {
            Add(n1, n2, 1);
        }

        /// <summary>
        /// Adds the aNode objects to the members list based on the collected node IDs.
        /// </summary>
        internal void RelateToNodeObjects()
        {
            foreach (int id in memberIDs)
            {
                members.Add(assembly.GetNode(id));
            }
        }
    }
}
