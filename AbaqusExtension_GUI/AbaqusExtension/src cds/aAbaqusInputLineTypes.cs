using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    internal enum aAbaqusInputLineTypes
    {
        /// <summary>
        /// Abaqus input file keyword
        /// </summary>
        Keyword,
        /// <summary>
        /// Abaqus Comma or space separated numeric data line
        /// </summary>
        DataLine,
        /// <summary>
        /// Abaqus input file comment line
        /// </summary>
        Comment,
        /// <summary>
        /// Any other input file line other than the above four types
        /// </summary>
        Other
    }
}