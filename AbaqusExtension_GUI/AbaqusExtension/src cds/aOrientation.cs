using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public class aOrientation : aIWritable
    {
        private string name;
        private aPoint _a;
        private aPoint _b;
        private aPoint _c;

        public aOrientation(string name, aPoint a, aPoint b, aPoint c)
        {
            this.name = name;
            _a = a;
            _b = b;
            _c = c;
        }

        public aPoint a
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }

        public aPoint b
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }

        public aPoint c
        {
            get
            {
                return _c;
            }
            set
            {
                _c = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public void Write(System.IO.StreamWriter Canvas)
        {
            Canvas.WriteLine("*Orientation, name=" + name);
            Canvas.WriteLine(a.X + ", " + a.Y + ", " + a.Z + ", " + b.X + ", " + b.Y + ", " + b.Z + ", " + c.X + ", " + c.Y + ", " + c.Z);
        }
    }
}
