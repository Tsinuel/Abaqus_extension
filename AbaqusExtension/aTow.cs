using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbaqusExtension
{
    public class aTow
    {
        private double biasAngle;
        private double braidAngle;
        private aPoint endOfPath;
        private aPoint startOfPath;
        private double towThickness;
        private double towWidth;
        private List<aI2DcurveInSpace> path;
        private int startElemNo;
        private int endElemNo;
        private string material;
        private bool displayInRadians = false;
        private int id;
        private List<aElset> elsets;
        private List<aSection> sections;
        private aAssembly assembly;
        private List<aElement> elements;

        public aTow(aAssembly assem)
        {
            path = new List<aI2DcurveInSpace>();
            this.assembly = assem;

            elsets = new List<aElset>();
            sections = new List<aSection>();
            elements = new List<aElement>();
        }

        /// <summary>
        /// Gets the collection of 2D curves representing the tow path in a single plane.
        /// </summary>
        public List<aI2DcurveInSpace> Path
        {
            get
            {
                return path;
            }
        }

        public List<aElement> Elements
        {
            get
            {
                return elements;
            }
        }

        /// <summary>
        /// Gets the start point of the path
        /// </summary>
        public aPoint StartOfPath
        {
            get
            {
                return startOfPath;
            }

            set
            {
                if (startOfPath.Equals(endOfPath))
                    throw new Exception("The start and end of a tow path cannot be the same.");
                else
                    startOfPath = value;
            }
        }

        /// <summary>
        /// Gets the end point of the path
        /// </summary>
        public aPoint EndOfPath
        {
            get
            {
                return endOfPath;
            }

            set
            {
                if (endOfPath.Equals(startOfPath))
                    throw new Exception("The start and the end of a tow path cannot be the same.");
                else
                    endOfPath = value;
            }
        }

        /// <summary>
        /// Gets the width of the tow
        /// </summary>
        public double TowWidth
        {
            get
            {
                return towWidth;
            }

            set
            {
                if (value > 0.0)
                    towWidth = value;
                else
                    throw new Exception("Tow thickness cannot be zero or negative.");
            }
        }

        /// <summary>
        /// Gets the thickness of the tow.
        /// </summary>
        public double TowThickness
        {
            get
            {
                return towThickness;
            }

            set
            {
                if (value > 0.0)
                    towThickness = value;
                else
                    throw new Exception("Tow thickness cannot be zero or negative.");
            }
        }

        /// <summary>
        /// Gets or sets the braiding angle of the tow
        /// </summary>
        public double BraidAngle
        {
            get
            {
                return braidAngle;
            }

            set
            {
                if(value <= Math.PI/-2 || Math.PI/2 <= value)
                    throw new Exception("A bias angle has to be: -90 < sourceValue < 90 degrees.");

                braidAngle = value;

                if (value < 0)
                {
                    biasAngle = -(Math.PI / 2 + 2 * value);
                }
                else if (value > 0)
                {
                    biasAngle = Math.PI / 2 - 2 * value;
                }
                else if (value == 0)
                {
                    biasAngle = 0;
                }

                //double v = Math.Abs(value);
                //if (0 <= v && v < Math.PI / 2)
                //    biasAngle = value;
                //else
                //    throw new Exception("A bias angle has to be: -90 < sourceValue < 90 degrees.");
            }
        }

        /// <summary>
        /// Gets or sets the lowest element number in the tow
        /// </summary>
        public int StartElemNo
        {
            get
            {
                return startElemNo;
            }

            set
            {
                startElemNo = value;
            }
        }

        /// <summary>
        /// Gets or sets the highest element number in the tow
        /// </summary>
        public int EndElemNo
        {
            get
            {
                return endElemNo;
            }

            set
            {
                endElemNo = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the material for the tow.
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
        /// Gets the ID number of this tow in the assembly.
        /// </summary>
        public int ID
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Gets the collection of segments having their own material and orientation
        /// </summary>
        public List<aSection> Sections
        {
            get
            {
                return sections;
            }
        }

        /// <summary>
        /// Gets the collection of element sets in the tow.
        /// </summary>
        public List<aElset> Elsets
        {
            get
            {
                return elsets;
            }
        }

        /// <summary>
        /// Gets or sets the angle unit used for the display in dialoge boxes.
        /// </summary>
        public bool DisplayInRadians
        {
            get
            {
                return displayInRadians;
            }

            set
            {
                this.displayInRadians = value;
            }
        }

        /// <summary>
        /// Sets the ID number to the given number
        /// </summary>
        /// <param name="ID">The new ID number</param>
        public void SetID(int ID)
        {
            id = ID;
        }

        private void PartitionTow()
        {
            aPoint[] pts, _pts;
            aPoint A, B, C, D, centd;
            aElset elset;
            aOrientation ori;
            double prod, ang, m;

            foreach (aI2DcurveInSpace pathSeg in path)
            {
                A = pathSeg.Start;
                B = pathSeg.End;
                C = new aPoint();

                m = Math.Atan((B.Y - A.Y) / (B.X - A.X));
                if (double.IsNaN(m) || double.IsInfinity(m))
                    m = Math.PI / 2;

                C.X = A.X + (towWidth / 2) * Math.Sin(m + biasAngle);
                C.Y = A.Y - (towWidth / 2) * Math.Cos(m + biasAngle);
                C.Z = A.Z;

                pts = GetPathSubSegments(pathSeg);
                _pts = new aPoint[pts.Length];

                for (int i = 0; i < pts.Length; i++)
                    _pts[i] = aPoint.Transform(A, C, new aPoint(A.X, A.Y, A.Z - 200000), pts[i]);


                for (int i = 0; i < _pts.Length - 1; i++)
                {
                    elset = new aElset("elset_" + (assembly.Elsets.Count + 1).ToString());

                    for (int j = 0; j < elements.Count; j++)
                    {
                        centd = aPoint.Transform(A, C, new aPoint(A.X, A.Y, A.Z - 200000), elements[j].Centroid);

                        //prod = centd.Z;

                        if (_pts[i].Z <= centd.Z && centd.Z <= _pts[i + 1].Z && !elements[j].IsOriented)
                        {
                            elset.Add(elements[j]);
                            elements[j].IsOriented = true;
                        }
                    }

                    D = new aPoint();
                    ang = Math.Atan((pts[i + 1].Y - pts[i].Y) / (pts[i + 1].X - pts[i].X));
                    D.X = pts[i].X + (towWidth / 2) * Math.Sin(ang);
                    D.Y = pts[i].Y - (towWidth / 2) * Math.Cos(ang);
                    D.Z = pts[i].Z;

                    if (elset.Members.Count > 0)
                    {
                        assembly.Elsets.Add(elset);
                        ori = new aOrientation("ori_" + (assembly.Orientations.Count + 1).ToString(), pts[i + 1], D, pts[i]);
                        assembly.Orientations.Add(ori);
                        assembly.Sections.Add(new aSection(aAbaqusSectionType.Solid, elset, material, ori));

                        if (assembly.GenGENOAdata)
                        {
                            if (assembly.LaminateCount < assembly.NumbOfAxialTows + 1)
                            {
                                assembly.GENOAfile.WriteLine("###");
                                assembly.GENOAfile.WriteLine("*LAMINATE       " + ++assembly.LaminateCount + "               ZOFF=0.000000E+00 CURETEMP=2.111111E+01 MOIST=0.000000E+00 SYM=NO          #NAME Laminate_1");
                                assembly.GENOAfile.WriteLine("#  FID:SID    MID:SID       THICK (mm)    ANGLE (Degrees) VF            VV            FAIL       TEMP (C)     ");
                                assembly.GENOAfile.WriteLine((int)assembly.GENOA_data[0, 1] + "\t" + (int)assembly.GENOA_data[1, 1] + "\t" + assembly.GENOA_data[2, 1] + "\t" +
                                    assembly.GENOA_data[3, 1] + "\t" + assembly.GENOA_data[4, 1] + "\t" + assembly.GENOA_data[5, 1] + "\t" + (int)assembly.GENOA_data[6, 1] + "\t" + assembly.GENOA_data[7, 1] + "\t");
                                assembly.GENOAfile.WriteLine((int)assembly.GENOA_data[0, 1] + "\t" + (int)assembly.GENOA_data[1, 1] + "\t" + assembly.GENOA_data[2, 1] + "\t" +
                                    assembly.GENOA_data[3, 1] + "\t" + assembly.GENOA_data[4, 1] + "\t" + assembly.GENOA_data[5, 1] + "\t" + (int)assembly.GENOA_data[6, 1] + "\t" + assembly.GENOA_data[7, 1] + "\t");
                            }
                            else
                            {
                                assembly.GENOAfile.WriteLine("###");
                                assembly.GENOAfile.WriteLine("*LAMINATE       " + ++assembly.LaminateCount + "               ZOFF=0.000000E+00 CURETEMP=2.111111E+01 MOIST=0.000000E+00 SYM=NO          #NAME Laminate_1");
                                assembly.GENOAfile.WriteLine("#  FID:SID    MID:SID       THICK (mm)    ANGLE (Degrees) VF            VV            FAIL       TEMP (C)     ");
                                assembly.GENOAfile.WriteLine((int)assembly.GENOA_data[0, 2] + "\t" + (int)assembly.GENOA_data[1, 2] + "\t" + assembly.GENOA_data[2, 2] + "\t" +
                                    assembly.GENOA_data[3, 2] + "\t" + assembly.GENOA_data[4, 2] + "\t" + assembly.GENOA_data[5, 2] + "\t" + (int)assembly.GENOA_data[6, 2] + "\t" + assembly.GENOA_data[7, 2] + "\t");
                                assembly.GENOAfile.WriteLine((int)assembly.GENOA_data[0, 2] + "\t" + (int)assembly.GENOA_data[1, 2] + "\t" + assembly.GENOA_data[2, 2] + "\t" +
                                    assembly.GENOA_data[3, 2] + "\t" + assembly.GENOA_data[4, 2] + "\t" + assembly.GENOA_data[5, 2] + "\t" + (int)assembly.GENOA_data[6, 2] + "\t" + assembly.GENOA_data[7, 2] + "\t");
                            }
                        }
                    }
                }
            }
        }

        private aPoint[] GetPathSubSegments(aI2DcurveInSpace segment)
        {
            List<aPoint> pts = new List<aPoint>();
            switch(segment.CurveType)
            {
                case aCurveTypes.Arc:
                    {
                        aArc arc = (aArc)segment;

                        //aPoint orig = arc.Start;
                        //aPoint u = new aPoint(arc.End.X, arc.End.Y, orig.Z);
                        //aPoint v = new aPoint(orig.X, orig.Y, orig.Z + 200000);
                        //aPoint orig = arc.Center;
                        //aPoint u = arc.End;
                        //aPoint v = arc.Start;

                        //aPoint A = aPoint.Transform(orig, u, v, arc.Start);
                        //aPoint B = aPoint.Transform(orig, u, v, arc.End);
                        //aPoint C = aPoint.Transform(orig, u, v, arc.ThirdPt);
                        //aPoint O = aPoint.Transform(orig, u, v, arc.Center);

                        //double L = Math.Abs(B.X - A.X);
                        //double l = L / (Math.Max((int)(L / assembly.ElemGroupingLength), 1));

                        //double[,] matx = { {A.X, A.Y, 1, -(Math.Pow(A.X,2)+Math.Pow(A.Y,2)) },
                        //                   {B.X, B.Y, 1, -(Math.Pow(B.X,2)+Math.Pow(B.Y,2)) },
                        //                   {C.X, C.Y, 1, -(Math.Pow(C.X,2)+Math.Pow(C.Y,2)) }};
                        //aMath.Solve(matx);
                        //double m = matx[0, 3];
                        //double n = matx[1, 3];
                        //double s = matx[2, 3];

                        //double y1, y2;

                        //aPoint p = A;
                        //while (p.X < B.X)
                        //{
                        //    pts.Add(p);
                        //    p.X += l;

                        //y1 = (-n + Math.Sqrt(n * n - 4 * (p.X * p.X + m * p.X + s))) / (2 * (p.X * p.X + m * p.X + s));
                        //y2 = (-n - Math.Sqrt(n * n - 4 * (p.X * p.X + m * p.X + s))) / (2 * (p.X * p.X + m * p.X + s));

                        //p.Y = C.Y * y1 > 0 ? y1 : y2;

                        //}
                        //pts.Add(B);

                        pts = arc.GetSegments(assembly.ElemGroupingLength);

                        //System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\temp\\tow" + id.ToString() + segment.ID.ToString() + ".scr");
                        //sw.WriteLine("3DPOLY");

                        //for (int i = 0; i < pts.Count; i++)
                        //{
                        //    pts[i] = aPoint.Transform(orig, u, v, pts[i], true);

                        //    sw.Write(pts[i].X + ",");
                        //    sw.Write(pts[i].Y + ",");
                        //    sw.WriteLine(pts[i].Z);
                        //}
                        //sw.WriteLine();
                        //sw.Close();

                        return pts.ToArray();
                    }
                case aCurveTypes.Line:
                    {
                        pts.Add(segment.Start);
                        pts.Add(segment.End);
                        return pts.ToArray();
                    }
                default:
                    {
                        throw new NotImplementedException();
                    }
            }
        }

        internal void AssignOrientation()
        {
            FillInTowElements(startElemNo, endElemNo);
            PartitionTow();
        }

        private void FillInTowElements(int startElemNo, int endElemNo)
        {
            for (int id = startElemNo; id <= endElemNo; id++)
                elements.Add(assembly.GetElement(id));
        }

        private void FillInTowElements()
        {
            // TO DO
            // Loop through all elements of the assembly to chose those elements within the goemetric boundaries of this tow.
            // The tow should be defined in terms of complete cross-section, start and end boundaries as well as complete tow path.
        }
    }
}