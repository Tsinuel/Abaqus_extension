using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public class aNodeSet : aIWritable
    {
        public aNode[] Members
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Count
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Write(System.IO.StreamWriter Canvas)
        {
            throw new NotImplementedException();
        }
    }
}
