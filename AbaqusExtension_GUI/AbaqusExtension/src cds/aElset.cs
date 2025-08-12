using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public class aElset : aIWritable
    {
        private string name;
        private List<aElement> members;

        public aElset(string name)
        {
            this.name = name;
            this.members = new List<aElement>();
        }

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
        public List<aElement> Members
        {
            get
            {
                return members;
            }
        }

        public void Write(System.IO.StreamWriter Canvas)
        {
            Canvas.WriteLine("*Elset, elset=" + name);

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

        internal void Add(aElement e)
        {
            members.Add(e);
        }
    }
}
