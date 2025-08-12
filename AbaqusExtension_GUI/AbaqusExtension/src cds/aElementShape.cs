using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public enum aElementShape
    {
        /// <summary>
        /// 3D brick shape
        /// </summary>
        Hex,
        /// <summary>
        /// 3D wedge
        /// </summary>
        Wedge,
        /// <summary>
        /// 3D tetrahedron
        /// </summary>
        Tet,
        /// <summary>
        /// 2D quadrilateral
        /// </summary>
        Quad,
        /// <summary>
        /// 2D triangular
        /// </summary>
        Tri
    }
}