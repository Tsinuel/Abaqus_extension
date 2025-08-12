using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    internal enum aAbaqusKeywords
    {
        /// <summary>
        /// Abaqus input file *ELEMENT keyword
        /// </summary>
        Element,
        /// <summary>
        /// Abaqus input file *NODE keyword
        /// </summary>
        Node,
        /// <summary>
        /// Abaqus input file *END keyword
        /// </summary>
        End,
        /// <summary>
        /// Abaqus input file *STEP keyword
        /// </summary>
        Step,
        /// <summary>
        /// Abaqus input file *ELSET keyword
        /// </summary>
        Elset,
        /// <summary>
        /// Abaqus input file *NSET keyword
        /// </summary>
        Nset,
        /// <summary>
        /// Abaqus input file *MATERIAL keyword
        /// </summary>
        Material,
        /// <summary>
        /// Indicator state where none of the above keywords are active or a comment line is in progress
        /// </summary>
        None
    }
}