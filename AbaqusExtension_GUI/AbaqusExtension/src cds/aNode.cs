using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{

    public class aNode : aIWritable
    {
        private int id;
        private aPoint location;
        private List<aElement> elements;
        private bool isCostal;

        public aNode(int id, aPoint loc)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.location = loc;
            this.elements = new List<aElement>();
        }
        public aPoint Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public aElement[] Elements
        {
            get
            {
                return this.elements.ToArray();
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
        /// true if the node is found on the edge of the part
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

        public static implicit operator int(aNode n)
        {
            return n.ID;
        }

        public void Write(System.IO.StreamWriter Canvas)
        {
            Canvas.Write(this.id + ",\t");
            Canvas.Write("{0:e}",this.location.X.ToString());
            Canvas.Write(",\t");
            Canvas.WriteLine("{0:e}", this.location.Y.ToString());
        }

        public void JoinElement(aElement elem)
        {
            this.elements.Add(elem);
            //List<aElement> elems = new List<aElement>();

            //if (this.elements != null)
            //{
            //    elems.AddRange(elements);

            //    foreach (aElement e in elems)
            //        if (e == elem)
            //            return;

            //    elems.Add(elem);
            //}

            //this.elements = elems.ToArray();
        }
    }


}
