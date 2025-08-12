using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AbaqusExtension
{
    public interface aIWritable
    {
        void Write(StreamWriter Canvas);
    }
}
