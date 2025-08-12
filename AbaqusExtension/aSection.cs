using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public class aSection : aIWritable
    {
        private aAbaqusSectionType type;
        private aOrientation ori;
        private string material;
        private aElset elset;
        private double pStrain_stressDepth;

        public aSection(aAbaqusSectionType type, aElset elset, string material, aOrientation ori)
        {
            this.type = type;
            this.elset = elset;
            this.material = material;
            this.ori = ori;
            this.pStrain_stressDepth = 1.0;
        }

        /// <summary>
        /// Gets or sets the set of elements having this section
        /// </summary>
        public aElset Elset
        {
            get
            {
                return elset;
            }
        }

        /// <summary>
        /// Gets or sets the material orientation
        /// </summary>
        public aOrientation Orientation
        {
            get
            {
                return ori;
            }

            set
            {
                ori = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the material for the section
        /// </summary>
        public string Material
        {
            get
            {
                return material;
            }

            set
            {
                material = value;
            }
        }

        /// <summary>
        /// Gets or sets the section type
        /// </summary>
        public aAbaqusSectionType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public void Write(StreamWriter Canvas)
        {
            Canvas.WriteLine("*solid section, elset=" + elset.Name + ", orientation=" + ori.Name + ", material=" + material);
            if (pStrain_stressDepth == 1.0)
                Canvas.WriteLine(",");
            else
                Canvas.WriteLine(pStrain_stressDepth.ToString() + ",");
        }
    }
}