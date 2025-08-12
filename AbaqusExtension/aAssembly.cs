using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AbaqusExtension
{
    public class aAssembly
    {
        private double precision = 1E-5;
        private List<aNode> nodes = new List<aNode>();
        private List<aElement> elements = new List<aElement>();
        private aIO iOmanager;
        private bool is2D;
        private List<string> materials = new List<string>();
        private List<aTow> tows = new List<aTow>();
        private List<aSection> sections = new List<aSection>();
        private List<aOrientation> orientations = new List<aOrientation>();
        private List<aElset> elsets = new List<aElset>();
        private double elemGroupingLength;
        private List<aNodeSet> nSets = new List<aNodeSet>();
        private StreamWriter PBC_File;
        private StreamWriter logFile;
        private StreamWriter gENOAfile;
        private string modelName;
        private double[,] gENOA_data;
        private int numOfAxialTows;
        private bool genGENOAdata;
        private int laminateCount = 0;
        private int[] manualMasterNode_X;
        private int[] manualMasterNode_Y;
        private int[] manualMasterNode_Z;
        private bool manualMasterNodes;
        private double min_X;
        private double min_Y;
        private double min_Z;
        private double max_X;
        private double max_Y;
        private double max_Z;
        private double[] tolerances;
        private double[,] coordLimits;
        private double[] vectors;

        public aAssembly(string inpFile, string directory, string modelName)
        {
            //try
            //{
            //    //string[] name = inpFile.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            //    //string temp = name[name.Length - 1];
            //    //modelName = temp.Remove(temp.Length - 4);
            //}
            //catch
            //{
            //    modelName = "modelName";
            //}
            this.modelName = modelName;
            this.iOmanager = new aIO(inpFile, this, directory);
        }

        public double Precision
        {
            get
            {
                return this.precision;
            }
            set
            {
                this.precision = value;
            }
        }

        public List<aElement> Elements
        {
            get
            {
                return this.elements;
            }
        }

        public List<aNode> Nodes
        {
            get
            {
                return this.nodes;
            }
        }

        public List<aSection> Sections
        {
            get
            {
                return sections;
            }
        }

        public List<aOrientation> Orientations
        {
            get
            {
                return orientations;
            }
        }

        public List<aElset> Elsets
        {
            get
            {
                return elsets;
            }
        }

        internal int LaminateCount
        {
            get
            {
                return laminateCount;
            }
            set
            {
                laminateCount = value;
            }
        }

        /// <summary>
        /// Gets the file reader and writer of the current assembly.
        /// </summary>
        public aIO IOmanager
        {
            get
            {
                return this.iOmanager;
            }
        }

        /// <summary>
        /// Gets whether the model is 2D or 3D.
        /// </summary>
        public bool Is2D
        {
            get
            {
                return is2D;
            }
        }

        /// <summary>
        /// Gets the collection of the material names.
        /// </summary>
        public List<string> Materials
        {
            get
            {
                return materials;
            }
        }

        /// <summary>
        /// Gets the list of tows defined in the assembly
        /// </summary>
        public List<aTow> Tows
        {
            get
            {
                return tows;
            }
        }

        /// <summary>
        /// Gets or sets the length along tow paths over which all elements are given the same orientation.
        /// </summary>
        public double ElemGroupingLength
        {
            get
            {
                return elemGroupingLength;
            }

            set
            {
                elemGroupingLength = value;
            }
        }

        /// <summary>
        /// Gets the list of node sets in the assembly
        /// </summary>
        public List<aNodeSet> Nsets
        {
            get
            {
                return nSets;
            }
        }

        /// <summary>
        /// Gets or sets the name of the model
        /// </summary>
        public string ModelName
        {
            get
            {
                return this.modelName;
            }
            set
            {
                this.modelName = value;
            }
        }

        /// <summary>
        /// Gets or sets the array containing GENOA laminate definition
        /// </summary>
        public double[,] GENOA_data
        {
            get
            {
                return gENOA_data;
            }
            set
            {
                gENOA_data = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of axial tow sections defined
        /// </summary>
        public int NumbOfAxialTows
        {
            get
            {
                return numOfAxialTows;
            }
            set
            {
                numOfAxialTows = value;
            }
        }

        /// <summary>
        /// Tells if GENOA laminate definition file needs to be generated
        /// </summary>
        public bool GenGENOAdata
        {
            get
            {
                return genGENOAdata;
            }
            set
            {
                genGENOAdata = value;
            }
        }

        internal StreamWriter GENOAfile
        {
            get
            {
                return gENOAfile;
            }
        }

        public int[] ManualMasterNode_X
        {
            get
            {
                return manualMasterNode_X;
            }
            set
            {
                manualMasterNode_X = value;
            }
        }

        public int[] ManualMasterNode_Y
        {
            get
            {
                return manualMasterNode_Y;
            }
            set
            {
                manualMasterNode_Y = value;
            }
        }

        public int[] ManualMasterNode_Z
        {
            get
            {
                return manualMasterNode_Z;
            }
            set
            {
                manualMasterNode_Z = value;
            }
        }

        public bool ManualMasterNodes
        {
            get
            {
                return manualMasterNodes;
            }
            set
            {
                manualMasterNodes = value;
            }
        }

        /// <summary>
        /// Gets or sets the minimum x coordinate in the whole model
        /// </summary>
        public double Minimum_X
        {
            get
            {
                return min_X;
            }
            set
            {
                min_X = value;
            }
        }

        /// <summary>
        /// Gets or sets the minimum y coordinate in the whole model
        /// </summary>
        public double Minimum_Y
        {
            get
            {
                return min_Y;
            }
            set
            {
                min_Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the minimum z coordinate in the whole model
        /// </summary>
        public double Minimum_Z
        {
            get
            {
                return min_Z;
            }
            set
            {
                min_Z = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum x coordinate in the whole model
        /// </summary>
        public double Maximum_X
        {
            get
            {
                return max_X;
            }
            set
            {
                max_X = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum y coordinate in the whole model
        /// </summary>
        public double Maximum_Y
        {
            get
            {
                return max_Y;
            }
            set
            {
                max_Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum z coordinate in the whole model
        /// </summary>
        public double Maximum_Z
        {
            get
            {
                return max_Z;
            }
            set
            {
                max_Z = value;
            }
        }

        /// <summary>
        /// Gets the matrix holding the minimum and maximum of X,Y and Z coordinates
        /// </summary>
        public double[,] CoordLimits
        {
            get
            {
                return coordLimits;
            }
            set
            {
                coordLimits = value;
            }
        }

        /// <summary>
        /// Gets or sets the tolerance values for PBC generation in X, Y and Z directions
        /// </summary>
        public double[] Tolerances
        {
            get
            {
                return tolerances;
            }

            set
            {
                tolerances = value;
            }
        }

        /// <summary>
        /// Gets or sets the vectors for PBC generation in X, Y and Z directions
        /// </summary>
        public double[] Vectors
        {
            get
            {
                return vectors;
            }

            set
            {
                vectors = value;
            }
        }

        private void FillCentroid()
        {
            foreach (aElement el in elements)
            {
                el.RefreshCentroid();
            }
        }

        private void Interrelate()
        {
            foreach (aElement e in elements)
            {
                foreach (aNode n in e.Nodes)
                {
                    n.JoinElement(e);
                    e.JoinNode(n);
                }
            }
        }

        internal aNode GetNode(int id)
        {
            foreach (aNode n in nodes)
            {
                if (n.ID == id)
                    return n;
            }

            throw new Exception("The node cannot be found! The requested id was:" + id.ToString());
        }

        public void Initialize()
        {
            nodes = new List<aNode>();
            elements = new List<aElement>();
            materials = new List<string>();
        }

        private void ReadNode(List<string> bulk)
        {
            int lineNo = 0;
        A:
            for (; lineNo < bulk.Count; lineNo++)
            {
                if (bulk[lineNo].StartsWith("*Node", true, null))
                {
                    lineNo++;
                    break;
                }
            }

            for (; lineNo < bulk.Count; lineNo++)
            {
                if (bulk[lineNo][0] == '*' && bulk[lineNo][1] == '*')
                    continue;
                if (bulk[lineNo][0] == '*')
                    break;

                string[] nodeLine = bulk[lineNo].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                nodes.Add(new aNode(int.Parse(nodeLine[0]), new aPoint(double.Parse(nodeLine[1]), double.Parse(nodeLine[2]))));
            }

            for (; lineNo < bulk.Count; lineNo++)
                if (bulk[lineNo].StartsWith("*Node", true, null))
                    goto A;
        }

        public void AssignOrientation()
        {
            sections.Clear();
            elsets.Clear();

            if (GenGENOAdata)
            {
                gENOAfile = new StreamWriter(iOmanager.GENOAfile);
                laminateCount = 0;

                gENOAfile.WriteLine("###");
                gENOAfile.WriteLine("*LAMINATE       " + ++laminateCount + "               ZOFF=0.000000E+00 CURETEMP=2.111111E+01 MOIST=0.000000E+00 SYM=NO          #NAME Laminate_1");
                gENOAfile.WriteLine("#  FID:SID    MID:SID       THICK (mm)    ANGLE (Degrees) VF            VV            FAIL       TEMP (C)     ");
                gENOAfile.WriteLine((int)gENOA_data[0, 0] + "\t" + (int)gENOA_data[1, 0] + "\t" + gENOA_data[2, 0] + "\t" + gENOA_data[3, 0] + "\t" + gENOA_data[4, 0] + "\t" +
                    gENOA_data[5, 0] + "\t" + (int)gENOA_data[6, 0] + "\t" + gENOA_data[7, 0] + "\t");
                gENOAfile.WriteLine((int)gENOA_data[0, 0] + "\t" + (int)gENOA_data[1, 0] + "\t" + gENOA_data[2, 0] + "\t" + gENOA_data[3, 0] + "\t" + gENOA_data[4, 0] + "\t" +
                    gENOA_data[5, 0] + "\t" + (int)gENOA_data[6, 0] + "\t" + gENOA_data[7, 0] + "\t");
            }

            foreach (aTow tow in tows)
            {
                tow.AssignOrientation();
            }

            if (genGENOAdata)
                gENOAfile.Close();
        }

        public static bool IsCommand(string parameter)
        {
            if (parameter == null)
                return false;
            if (parameter == "")
                return false;
            if (parameter[0] == '*' && parameter[1] != '*')
                return true;

            return false;
        }

        public void RemoveTow(int id)
        {
            for (int i = 0; i < tows.Count; i++)
            {
                if (i == id - 1)
                {
                    tows.RemoveAt(i);
                    break;
                }
            }

            RefreshTowID();
        }

        public void Write(string outputFile)
        {
            //foreach (aNode n in nodes)
            //    n.Write(Canvas);

            //foreach (aElement e in elements)
            //    e.Write(Canvas);

            StreamWriter Canvas = new StreamWriter(outputFile);

            foreach (var elset in elsets)
                elset.Write(Canvas);

            foreach (var sect in sections)
                sect.Write(Canvas);

            foreach (var ori in orientations)
                ori.Write(Canvas);

            Canvas.Close();
        }

        public void RefreshTowID()
        {
            for (int i = 0; i < tows.Count; i++)
                tows[i].SetID(i + 1);
        }

        public aElement GetElement(int id)
        {
            for (int i = 0; i < elements.Count; i++)
                if (elements[i].ID == id)
                    return elements[i];

            throw new Exception("Element number " + id + " could not be found.");
        }

        /// <param name="direction">The direction in which the nodes are to be copied</param>
        /// <param name="sourceValue">The sourceValue of the direction coordinate for the source face</param>
        /// <param name="vector">The vector in the direction of copy</param>
        /// <param name="tolerance">The tolerance value to include the required nodes</param>
        public void ApplyPBCs(string PBCfileName, aCoordinate direction, aEquationType[] eqnSet, aPBCtype PBCtype)
        {
            //try
            //{
            logFile = new StreamWriter(iOmanager.Directory + "\\" + modelName + "_log.log", true);
            if (eqnSet != null)
                PBC_File = new StreamWriter(iOmanager.Directory + "\\" + modelName + "_" + PBCfileName + ".inp", true);

            switch (direction)
            {
                case aCoordinate.X:
                    {
                        CopyNodesInX(eqnSet, PBCtype);
                        break;
                    }
                case aCoordinate.Y:
                    {
                        CopyNodesInY(eqnSet, PBCtype);
                        break;
                    }
                case aCoordinate.Z:
                    {
                        CopyNodesInZ(eqnSet, PBCtype);
                        break;
                    }
            }
            //}
            //catch (Exception exc)
            //{
            //    throw exc;
            //}
            //finally
            //{
            if (PBC_File != null)
                PBC_File.Close();
            if (logFile != null)
                logFile.Close();
            //}
        }
      
        /// <param name="sourceValue">The sourceValue of the direction coordinate for the source face</param>
        /// <param name="vectors">The vector in the direction of copy</param>
        /// <param name="tolerances">The tolerance value to include the required nodes</param>
        private void CopyNodesInX(aEquationType[] eqnSet, aPBCtype PBCtype)
        {
            //StreamWriter logFile = new StreamWriter(iOmanager.Directory + "\\" + modelName + "_details_X.inp");

            List<aNode> SN = new List<aNode>();     // Source nodes
            List<aNode> CN = new List<aNode>();     // Copied nodes
            List<int[]> unmatchedNodes = new List<int[]>();
            aNode S;                                // Current source node
            aNode C = null;                         // Current copied node
            aNode M_S = null;                       // Master node on the source face
            aNode M_C = null;                       // Master node on the target face
            aNode TN;                               // Temporary copied node
            double d = 10e10;                       // Least distance between source and copied nodes
            double d_temp;                          // Temporary least distance
            double coord;

            logFile.WriteLine("\n**");
            logFile.WriteLine("** X direction");
            logFile.WriteLine("**");

            for (int i = 0; i < nodes.Count; i++)
            {
                coord = nodes[i].Location.X;
                if (coordLimits[0, 0] - tolerances[0] <= coord && coord <= coordLimits[0, 0] + tolerances[0])
                    SN.Add(nodes[i]);
                else if (coordLimits[0, 1] - tolerances[0] <= coord && coord <= coordLimits[0, 1] + tolerances[0])
                    CN.Add(nodes[i]);
            }

            if (SN.Count != CN.Count)
            {
                logFile.WriteLine("** Warning:\n\tThe number of nodes in the source and target face does not match");
                logFile.WriteLine("\t\tNo of Source face nodes\t" + SN.Count);
                logFile.WriteLine("\t\tNo of Target face nodes\t" + CN.Count);
            }

            logFile.WriteLine("Source face:");
            foreach (var n in SN)
                logFile.WriteLine(n.ID);
            logFile.WriteLine("\n\nTarget face:");
            foreach (var n in CN)
                logFile.WriteLine(n.ID);
            logFile.WriteLine("\n\nNode pairs (source, target, change):");

            for (int i = 0; i < SN.Count; i++)
            {
                S = SN[i];

                int j = 0;

                for (; j < CN.Count; j++)
                {
                    if (!CN[j].Flagged)
                    {
                        C = CN[j++];
                        d = Math.Sqrt(Math.Pow(S.Location.Y - C.Location.Y, 2) + Math.Pow(S.Location.Z - C.Location.Z, 2));
                        break;
                    }
                }
                if (j == CN.Count)
                    break;
                //d_temp = d;

                for (; j < CN.Count; j++)
                {
                    if (!CN[j].Flagged)
                    {
                        TN = CN[j];
                        d_temp = Math.Sqrt(Math.Pow(S.Location.Y - TN.Location.Y, 2) + Math.Pow(S.Location.Z - TN.Location.Z, 2));

                        if (d_temp < d)
                        {
                            C = TN;
                            d = d_temp;
                        }
                    }
                }

                S.Flagged = true;
                if (ThisCisBestMatch(aCoordinate.X, C, d, SN))
                {
                    aPoint temp = new aPoint(C.Location.X, S.Location.Y, S.Location.Z);
                    C.Location = temp;
                    C.Flagged = true;
                    if (M_S == null)
                    {
                        if (manualMasterNodes)
                        {
                            try
                            {
                                M_S = GetNode(manualMasterNode_X[0]);
                                M_C = GetNode(manualMasterNode_X[1]);
                            }
                            catch
                            {
                                M_S = S;
                                M_C = C;
                            }
                        }
                        else
                        {
                            M_S = S;
                            M_C = C;
                        }
                    }
                    
                    if (M_S != S)
                        writeEquation(aCoordinate.X, M_S, M_C, S, C, eqnSet, PBCtype);

                    logFile.WriteLine(S.ID + ",\t" + C.ID + ",\t" + d);
                }
                else
                    unmatchedNodes.Add(new int[] { S.ID, C.ID });
            }

            foreach (aNode n in CN)
                n.Flagged = false;
            foreach (aNode n in SN)
                n.Flagged = false;

            // tempWriter.WriteLine("**Master nodes:\t" + M_S.ID + ",\t" + M_C.ID);
            PBC_File.WriteLine("*Nset, nset=Master_X1");
            PBC_File.WriteLine(M_S.ID);
            PBC_File.WriteLine("*Nset, nset=Master_X2");
            PBC_File.WriteLine(M_C.ID);

            if (unmatchedNodes.Count > 0)
            {
                logFile.WriteLine("**Unamtched nodes in their closest pair (source, copy)");
                foreach (var n in unmatchedNodes)
                {
                    logFile.WriteLine(n[0] + ",\t" + n[1]);
                    PBC_File.WriteLine("*Nset, nset=ErrUnmatch_" + n[0] + "_" + n[1]);
                    PBC_File.WriteLine(n[0] + ",\t" + n[1]);
                }
            }
        }
        
        /// <param name="sourceValue">The sourceValue of the direction coordinate for the source face</param>
        /// <param name="vectors">The vector in the direction of copy</param>
        /// <param name="tolerances">The tolerance value to include the required nodes</param>
        private void CopyNodesInY(aEquationType[] eqnSet, aPBCtype PBCtype)
        {
            //StreamWriter logFile = new StreamWriter(iOmanager.Directory + "\\__details_Y.inp");

            List<aNode> SN = new List<aNode>();     // Source nodes
            List<aNode> CN = new List<aNode>();     // Copied nodes
            List<int[]> unmatchedNodes = new List<int[]>();
            aNode S;                                // Current source node
            aNode C = null;                         // Current copied node
            aNode M_S = null;                       // Master node on the source face
            aNode M_C = null;                       // Master node on the target face
            aNode TN;                               // Temporary copied node
            double d = 10e10;                       // Least distance between source and copied nodes
            double d_temp;                          // Temporary least distance
            double coord;

            logFile.WriteLine("\n**");
            logFile.WriteLine("** Y direction");
            logFile.WriteLine("**");

            for (int i = 0; i < nodes.Count; i++)
            {
                coord = nodes[i].Location.Y;
                if (coordLimits[1, 0] - tolerances[1] <= coord && coord <= coordLimits[1, 0] + tolerances[1])
                {
                    if (IsWithinLimits(aCoordinate.Y, nodes[i]))
                        SN.Add(nodes[i]);
                }
                else if (coordLimits[1, 1] - tolerances[1] <= coord && coord <= coordLimits[1, 1] + tolerances[1])
                {
                    if (IsWithinLimits(aCoordinate.Y, nodes[i]))
                        CN.Add(nodes[i]);
                }
            }

            if (SN.Count != CN.Count)
            {
                logFile.WriteLine("** Warning:\n\tThe number of nodes in the source and target face does not match");
                logFile.WriteLine("\t\tNo of Source face nodes\t" + SN.Count);
                logFile.WriteLine("\t\tNo of Target face nodes\t" + CN.Count);
            }

            logFile.WriteLine("Source face:");
            foreach (var n in SN)
                logFile.WriteLine(n.ID);
            logFile.WriteLine("\n\nCopied face:");
            foreach (var n in CN)
                logFile.WriteLine(n.ID);
            logFile.WriteLine("\n\nNode pairs (source, target, change):");

            for (int i = 0; i < SN.Count; i++)
            {
                S = SN[i];

                int j = 0;

                for (; j < CN.Count; j++)
                {
                    if (!CN[j].Flagged)
                    {
                        C = CN[j++];
                        d = Math.Sqrt(Math.Pow(S.Location.X - C.Location.X, 2) + Math.Pow(S.Location.Z - C.Location.Z, 2));
                        break;
                    }
                }
                if (j == CN.Count)
                    break;

                for (; j < CN.Count; j++)
                {
                    if (!CN[j].Flagged)
                    {
                        TN = CN[j];
                        d_temp = Math.Sqrt(Math.Pow(S.Location.X - TN.Location.X, 2) + Math.Pow(S.Location.Z - TN.Location.Z, 2));

                        if (d_temp < d)
                        {
                            C = TN;
                            d = d_temp;
                        }
                    }
                }

                S.Flagged = true;
                if (ThisCisBestMatch(aCoordinate.Y, C, d, SN))
                {
                    aPoint temp = new aPoint(S.Location.X, C.Location.Y, S.Location.Z);
                    C.Location = temp;
                    C.Flagged = true;
                    if (M_S == null)
                    {
                        if (manualMasterNodes)
                        {
                            try
                            {
                                M_S = GetNode(manualMasterNode_Y[0]);
                                M_C = GetNode(manualMasterNode_Y[1]);
                            }
                            catch
                            {
                                M_S = S;
                                M_C = C;
                            }
                        }
                        else
                        {
                            M_S = S;
                            M_C = C;
                        }
                    }

                    if (M_S != S)
                        writeEquation(aCoordinate.Y, M_S, M_C, S, C, eqnSet, PBCtype);
                    
                    logFile.WriteLine(S.ID + ",\t" + C.ID + ",\t" + d);
                }
                else
                    unmatchedNodes.Add(new int[] { S.ID, C.ID });
            }

            foreach (aNode n in CN)
                n.Flagged = false;
            foreach (aNode n in SN)
                n.Flagged = false;

            // tempWriter.WriteLine("**Master nodes:\t" + M_S.ID + ",\t" + M_C.ID);
            PBC_File.WriteLine("*Nset, nset=Master_Y1");
            PBC_File.WriteLine(M_S.ID);
            PBC_File.WriteLine("*Nset, nset=Master_Y2");
            PBC_File.WriteLine(M_C.ID);

            if (unmatchedNodes.Count > 0)
            {
                logFile.WriteLine("**Unamtched nodes in their closest pair (source, copy)");
                foreach (var n in unmatchedNodes)
                {
                    logFile.WriteLine(n[0] + ",\t" + n[1]);
                    PBC_File.WriteLine("*Nset, nset=ErrUnmatch_" + n[0] + "_" + n[1]);
                    PBC_File.WriteLine(n[0] + ",\t" + n[1]);
                }
            }
        }

        /// <param name="sourceValue">The sourceValue of the direction coordinate for the source face</param>
        /// <param name="vectors">The vector in the direction of copy</param>
        /// <param name="tolerances">The tolerance value to include the required nodes</param>
        private void CopyNodesInZ(aEquationType[] eqnSet, aPBCtype PBCtype)
        {
            //StreamWriter logFile = new StreamWriter(iOmanager.Directory + "\\__details_Z.inp");

            List<aNode> SN = new List<aNode>();     // Source nodes
            List<aNode> CN = new List<aNode>();     // Copied nodes
            List<int[]> unmatchedNodes = new List<int[]>();
            aNode S;                                // Current source node
            aNode C = null;                         // Current copied node
            aNode M_S = null;                       // Master node on the source face
            aNode M_C = null;                       // Master node on the target face
            aNode TN;                               // Temporary copied node
            double d = 10e10;                       // Least distance between source and copied nodes
            double d_temp;                          // Temporary least distance
            double coord;

            aNodeSet backNodes = null, frontNodes = null;
            if (PBCtype == aPBCtype.Symm)
            {
                backNodes = new aNodeSet("M_BackNodes", false, this);
                frontNodes = new aNodeSet("M_FrontNodes", false, this);
            }

            logFile.WriteLine("\n**");
            logFile.WriteLine("** Z direction");
            logFile.WriteLine("**");

            for (int i = 0; i < nodes.Count; i++)
            {
                coord = nodes[i].Location.Z;
                if (coordLimits[2, 0] - tolerances[2] <= coord && coord <= coordLimits[2, 0] + tolerances[2])
                {
                    if (IsWithinLimits(aCoordinate.Z, nodes[i]))
                        SN.Add(nodes[i]);
                }
                else if (coordLimits[2, 1] - tolerances[2] <= coord && coord <= coordLimits[2, 1] + tolerances[2])
                {
                    if (IsWithinLimits(aCoordinate.Z, nodes[i]))
                        CN.Add(nodes[i]);
                }
            }

            if (SN.Count != CN.Count)
            {
                logFile.WriteLine("** Warning:\n\tThe number of nodes in the source and target face does not match");
                logFile.WriteLine("\t\tNo of Source face nodes\t" + SN.Count);
                logFile.WriteLine("\t\tNo of Target face nodes\t" + CN.Count);
            }

            logFile.WriteLine("Source face:");
            foreach (var n in SN)
                logFile.WriteLine(n.ID);
            logFile.WriteLine("\n\nCopied face:");
            foreach (var n in CN)
                logFile.WriteLine(n.ID);
            logFile.WriteLine("\n\nNode pairs (source, target, change):");

            for (int i = 0; i < SN.Count; i++)
            {
                S = SN[i];

                int j = 0;

                for (; j < CN.Count; j++)
                {
                    if (!CN[j].Flagged)
                    {
                        C = CN[j++];
                        d = Math.Sqrt(Math.Pow(S.Location.X - C.Location.X, 2) + Math.Pow(S.Location.Y - C.Location.Y, 2));
                        break;
                    }
                }
                if (j == CN.Count)
                    break;

                for (; j < CN.Count; j++)
                {
                    if (!CN[j].Flagged)
                    {
                        TN = CN[j];
                        d_temp = Math.Sqrt(Math.Pow(S.Location.X - TN.Location.X, 2) + Math.Pow(S.Location.Y - TN.Location.Y, 2));

                        if (d_temp < d)
                        {
                            C = TN;
                            d = d_temp;
                        }
                    }
                }

                S.Flagged = true;
                if (ThisCisBestMatch(aCoordinate.Z, C, d, SN))
                {
                    aPoint temp = new aPoint(S.Location.X, S.Location.Y, C.Location.Z);
                    C.Location = temp;
                    C.Flagged = true;
                    if (M_S == null)
                    {
                        if (manualMasterNodes)
                        {
                            try
                            {
                                M_S = GetNode(manualMasterNode_Z[0]);
                                M_C = GetNode(manualMasterNode_Z[1]);
                            }
                            catch
                            {
                                M_S = S;
                                M_C = C;
                            }
                        }
                        else
                        {
                            M_S = S;
                            M_C = C;
                        }
                    }

                    if (M_S != S)
                    {
                        writeEquation(aCoordinate.Z, M_S, M_C, S, C, eqnSet, PBCtype);
                    }
                    
                    logFile.WriteLine(S.ID + ",\t" + C.ID + ",\t" + d);
                }
                else
                    unmatchedNodes.Add(new int[] { S.ID, C.ID });
            }

            foreach (aNode n in CN)
            {
                n.Flagged = false;
                if (PBCtype == aPBCtype.Symm && n != M_C)
                    frontNodes.Add(n.ID);
            }
            foreach (aNode n in SN)
            {
                n.Flagged = false;
                if (PBCtype == aPBCtype.Symm && n != M_S)
                    backNodes.Add(n.ID);
            }

            //tempWriter.WriteLine("**Master nodes:\t" + M_S.ID + ",\t" + M_C.ID);
            if (PBCtype == aPBCtype.Symm)
            {
                backNodes.RelateToNodeObjects();
                backNodes.Write(PBC_File);

                PBC_File.WriteLine("*Equation");
                PBC_File.WriteLine("2");
                PBC_File.WriteLine("M_BackNodes" + ", 3, 1.,");
                PBC_File.WriteLine("Master_Z1" + ", 3, -1.,");

                frontNodes.RelateToNodeObjects();
                frontNodes.Write(PBC_File);

                PBC_File.WriteLine("*Equation");
                PBC_File.WriteLine("2");
                PBC_File.WriteLine("M_FrontNodes" + ", 3, 1.,");
                PBC_File.WriteLine("Master_Z2" + ", 3, -1.,");
            }

            PBC_File.WriteLine("*Nset, nset=Master_Z1");
            PBC_File.WriteLine(M_S.ID);
            PBC_File.WriteLine("*Nset, nset=Master_Z2");
            PBC_File.WriteLine(M_C.ID);

            if (unmatchedNodes.Count > 0)
            {
                logFile.WriteLine("**Unamtched nodes in their closest pair (source, copy)");
                foreach (var n in unmatchedNodes)
                {
                    logFile.WriteLine(n[0] + ",\t" + n[1]);
                    PBC_File.WriteLine("*Nset, nset=ErrUnmatch_" + n[0] + "_" + n[1]);
                    PBC_File.WriteLine(n[0] + ",\t" + n[1]);
                }
            }
        } 
        
        /*
        /// <param name="sourceValue">The sourceValue of the direction coordinate for the source face</param>
        /// <param name="vector">The vector in the direction of copy</param>
        /// <param name="tolerance">The tolerance value to include the required nodes</param>
        private void CopyNodesInX(double v, double t, double e, aEquationType[] eqnSet)
        {
            List<aNode> SN = new List<aNode>();     // Source nodes
            List<aNode> TN = new List<aNode>();     // Target nodes
            List<int[]> pairIndxs = new List<int[]>();
            List<double> dists = new List<double>();
            aNode M_S = null;                       // Master node on the source face
            aNode M_T = null;                       // Master node on the target face
            double d = 10e10;                       // Least distance between source and copied nodes
            double d_temp;                          // Temporary least distance
            int[] max_d_IDs = new int[2];
            double max_d = 0;
            double coord;

            logFile.WriteLine("\n**");
            logFile.WriteLine("** X direction");
            logFile.WriteLine("**");

            for (int i = 0; i < nodes.Count; i++)
            {
                coord = nodes[i].Location.X;
                if (v - e <= coord && coord <= v + e)
                    SN.Add(nodes[i]);
                else if (v + t - e <= coord && coord <= v + t + e)
                    TN.Add(nodes[i]);
            }

            if (SN.Count <= TN.Count)
            {
                for (int i = 0; i < SN.Count; i++)
                {
                    pairIndxs.Add(new int[2]);
                    pairIndxs[i][0] = i;
                    SN[i].Flagged = true;

                    for (int j = 0; j < TN.Count; j++)
                    {
                        d_temp = Math.Sqrt(Math.Pow(SN[i].Location.Y - TN[j].Location.Y, 2) + Math.Pow(SN[i].Location.Z - TN[j].Location.Z, 2));
                        if (d_temp < d)
                        {
                            d = d_temp;
                            pairIndxs[i][1] = j;
                        }
                    }
                    TN[pairIndxs[i][1]].Flagged = true;
                    dists.Add(d);
                    if (max_d <= d)
                    {
                        max_d = d;
                        max_d_IDs[0] = SN[i].ID;
                        max_d_IDs[1] = TN[pairIndxs[i][1]].ID;
                    }
                    d = 10e10;
                }
            }
            else
            {
                for (int j = 0; j < TN.Count; j++)
                {
                    pairIndxs.Add(new int[2]);
                    pairIndxs[j][1] = j;
                    TN[j].Flagged = true;

                    for (int i = 0; i < SN.Count; i++)
                    {
                        d_temp = Math.Sqrt(Math.Pow(SN[i].Location.Y - TN[j].Location.Y, 2) + Math.Pow(SN[i].Location.Z - TN[j].Location.Z, 2));
                        if (d_temp < d)
                        {
                            d = d_temp;
                            pairIndxs[j][0] = i;
                        }
                    }
                    SN[pairIndxs[j][0]].Flagged = true;
                    dists.Add(d);
                    if (max_d <= d)
                    {
                        max_d = d;
                        max_d_IDs[0] = SN[pairIndxs[j][0]].ID;
                        max_d_IDs[1] = TN[j].ID;
                    }
                    d = 10e10;
                }
            }

            if (pairIndxs.Count > 0)
            {
                M_S = SN[pairIndxs[0][0]];
                M_T = TN[pairIndxs[0][1]];

                logFile.WriteLine("\n\nNode pairs (source, target, change):");
                aPoint temp;
                for (int i = 0; i < pairIndxs.Count; i++)
                {
                    temp = new aPoint(TN[pairIndxs[i][1]].Location.X, SN[pairIndxs[i][0]].Location.Y, SN[pairIndxs[i][0]].Location.Z);
                    TN[pairIndxs[i][1]].Location = temp;

                    writeEquation(aCoordinate.X, M_S, M_T, SN[pairIndxs[i][0]], TN[pairIndxs[i][1]], eqnSet);

                    equationFile.WriteLine("*Nset, nset=Pair_X" + SN[pairIndxs[i][0]].ID + "_" + TN[pairIndxs[i][1]].ID);
                    equationFile.WriteLine(SN[pairIndxs[i][0]].ID + ", " + TN[pairIndxs[i][1]].ID);

                    logFile.WriteLine(SN[pairIndxs[i][0]].ID + ",\t" + TN[pairIndxs[i][1]].ID + ",\t" + dists[i]);
                }

                equationFile.WriteLine("*Nset, nset=Master_X1");
                equationFile.WriteLine(M_S.ID);
                equationFile.WriteLine("*Nset, nset=Master_X2");
                equationFile.WriteLine(M_T.ID);
            }

            if (SN.Count != TN.Count)
            {
                logFile.WriteLine("** Warning:\n\tThe number of nodes in the source and target face does not match");
                logFile.WriteLine("\t\tNo of Source face nodes\t" + SN.Count);
                logFile.WriteLine("\t\tNo of Target face nodes\t" + TN.Count);

                foreach (aNode n in SN)
                    if (!n.Flagged)
                    {
                        equationFile.WriteLine("*Nset, nset=UnMatch_X_Src_" + n.ID);
                        equationFile.WriteLine(n.ID);
                    }
                foreach (aNode n in TN)
                    if (!n.Flagged)
                    {
                        equationFile.WriteLine("*Nset, nset=UnMatch_X_Tgt_" + n.ID);
                        equationFile.WriteLine(n.ID);
                    }
            }

            logFile.WriteLine("**");
            logFile.WriteLine("** Maximum change made in X direction = " + max_d);
            logFile.WriteLine("\t\tSource Node:\t" + max_d_IDs[0]);
            logFile.WriteLine("\t\tTarget Node:\t" + max_d_IDs[1]);
            logFile.WriteLine("**");
            equationFile.WriteLine("*Nset, nset=MaxChange_X_" + max_d_IDs[0] + "_" + max_d_IDs[1]);
            equationFile.WriteLine(max_d_IDs[0] + ", " + max_d_IDs[1]);

            foreach (aNode n in TN)
                n.Flagged = false;
            foreach (aNode n in SN)
                n.Flagged = false;

        }

        /// <param name="sourceValue">The sourceValue of the direction coordinate for the source face</param>
        /// <param name="vector">The vector in the direction of copy</param>
        /// <param name="tolerance">The tolerance value to include the required nodes</param>
        private void CopyNodesInY(double v, double t, double e, aEquationType[] eqnSet, double[,] limits)
        {
            List<aNode> SN = new List<aNode>();     // Source nodes
            List<aNode> TN = new List<aNode>();     // Target nodes
            List<int[]> pairIndxs = new List<int[]>();
            List<double> dists = new List<double>();
            aNode M_S = null;                       // Master node on the source face
            aNode M_T = null;                       // Master node on the target face
            double d = 10e10;                       // Least distance between source and copied nodes
            int[] max_d_IDs = new int[2];
            double d_temp;                          // Temporary least distance
            double max_d = 0;
            double coord;

            logFile.WriteLine("\n**");
            logFile.WriteLine("** Y direction");
            logFile.WriteLine("**");

            for (int i = 0; i < nodes.Count; i++)
            {
                coord = nodes[i].Location.Y;
                if (v - e <= coord && coord <= v + e)
                {
                    if (IsWithinLimits(aCoordinate.Y, limits, nodes[i]))
                        SN.Add(nodes[i]);
                }
                else if (v + t - e <= coord && coord <= v + t + e)
                {
                    if (IsWithinLimits(aCoordinate.Y, limits, nodes[i]))
                        TN.Add(nodes[i]);
                }
            }

            if (SN.Count <= TN.Count)
            {
                for (int i = 0; i < SN.Count; i++)
                {
                    pairIndxs.Add(new int[2]);
                    pairIndxs[i][0] = i;
                    SN[i].Flagged = true;

                    for (int j = 0; j < TN.Count; j++)
                    {
                        d_temp = Math.Sqrt(Math.Pow(SN[i].Location.X - TN[j].Location.X, 2) + Math.Pow(SN[i].Location.Z - TN[j].Location.Z, 2));
                        if (d_temp < d)
                        {
                            d = d_temp;
                            pairIndxs[i][1] = j;
                        }
                    }
                    TN[pairIndxs[i][1]].Flagged = true;
                    dists.Add(d);
                    if (max_d <= d)
                    {
                        max_d = d;
                        max_d_IDs[0] = SN[i].ID;
                        max_d_IDs[1] = TN[pairIndxs[i][1]].ID;
                    }
                    d = 10e10;
                }
            }
            else
            {
                for (int j = 0; j < TN.Count; j++)
                {
                    pairIndxs.Add(new int[2]);
                    pairIndxs[j][1] = j;
                    TN[j].Flagged = true;

                    for (int i = 0; i < SN.Count; i++)
                    {
                        d_temp = Math.Sqrt(Math.Pow(SN[i].Location.X - TN[j].Location.X, 2) + Math.Pow(SN[i].Location.Z - TN[j].Location.Z, 2));
                        if (d_temp < d)
                        {
                            d = d_temp;
                            pairIndxs[j][0] = i;
                        }
                    }
                    SN[pairIndxs[j][0]].Flagged = true;
                    dists.Add(d);
                    if (max_d <= d)
                    {
                        max_d = d;
                        max_d_IDs[0] = SN[pairIndxs[j][0]].ID;
                        max_d_IDs[1] = TN[j].ID;
                    }
                    d = 10e10;
                }
            }

            if (pairIndxs.Count > 0)
            {
                M_S = SN[pairIndxs[0][0]];
                M_T = TN[pairIndxs[0][1]];

                logFile.WriteLine("\n\nNode pairs (source, target, change):");
                aPoint temp;
                for (int i = 0; i < pairIndxs.Count; i++)
                {
                    temp = new aPoint(SN[pairIndxs[i][0]].Location.X, TN[pairIndxs[i][1]].Location.Y, SN[pairIndxs[i][0]].Location.Z);
                    TN[pairIndxs[i][1]].Location = temp;

                    writeEquation(aCoordinate.Y, M_S, M_T, SN[pairIndxs[i][0]], TN[pairIndxs[i][1]], eqnSet);

                    logFile.WriteLine(SN[pairIndxs[i][0]].ID + ",\t" + TN[pairIndxs[i][1]].ID + ",\t" + dists[i]);
                }

                equationFile.WriteLine("*Nset, nset=Master_Y1");
                equationFile.WriteLine(M_S.ID);
                equationFile.WriteLine("*Nset, nset=Master_Y2");
                equationFile.WriteLine(M_T.ID);
            }

            if (SN.Count != TN.Count)
            {
                logFile.WriteLine("** Warning:\n\tThe number of nodes in the source and target face does not match");
                logFile.WriteLine("\t\tNo of Source face nodes\t" + SN.Count);
                logFile.WriteLine("\t\tNo of Target face nodes\t" + TN.Count);

                foreach (aNode n in SN)
                    if (!n.Flagged)
                    {
                        equationFile.WriteLine("*Nset, nset=UnMatch_Y_Src_" + n.ID);
                        equationFile.WriteLine(n.ID);
                    }
                foreach (aNode n in TN)
                    if (!n.Flagged)
                    {
                        equationFile.WriteLine("*Nset, nset=UnMatch_Y_Tgt_" + n.ID);
                        equationFile.WriteLine(n.ID);
                    }
            }

            logFile.WriteLine("**");
            logFile.WriteLine("** Maximum change made in Y direction = " + max_d);
            logFile.WriteLine("\t\tSource Node:\t" + max_d_IDs[0]);
            logFile.WriteLine("\t\tTarget Node:\t" + max_d_IDs[1]);
            logFile.WriteLine("**");
            equationFile.WriteLine("*Nset, nset=MaxChange_Y_" + max_d_IDs[0] + "_" + max_d_IDs[1]);
            equationFile.WriteLine(max_d_IDs[0] + ", " + max_d_IDs[1]);

            foreach (aNode n in TN)
                n.Flagged = false;
            foreach (aNode n in SN)
                n.Flagged = false;
        
        }

        /// <param name="sourceValue">The sourceValue of the direction coordinate for the source face</param>
        /// <param name="vector">The vector in the direction of copy</param>
        /// <param name="tolerance">The tolerance value to include the required nodes</param>
        private void CopyNodesInZ(double v, double t, double e, aEquationType[] eqnSet, double[,] limits)
        {
            List<aNode> SN = new List<aNode>();     // Source nodes
            List<aNode> TN = new List<aNode>();     // Target nodes
            List<int[]> pairIndxs = new List<int[]>();
            List<double> dists = new List<double>();
            aNode M_S = null;                       // Master node on the source face
            aNode M_T = null;                       // Master node on the target face
            double d = 10e10;                       // Least distance between source and copied nodes
            int[] max_d_IDs = new int[2];
            double d_temp;                          // Temporary least distance
            double max_d = 0;
            double coord;

            logFile.WriteLine("\n**");
            logFile.WriteLine("** Z direction");
            logFile.WriteLine("**");

            for (int i = 0; i < nodes.Count; i++)
            {
                coord = nodes[i].Location.Z;
                if (v - e <= coord && coord <= v + e)
                {
                    if (IsWithinLimits(aCoordinate.Z, limits, nodes[i]))
                        SN.Add(nodes[i]);
                }
                else if (v + t - e <= coord && coord <= v + t + e)
                {
                    if (IsWithinLimits(aCoordinate.Z, limits, nodes[i]))
                        TN.Add(nodes[i]);
                }
            }

            if (SN.Count <= TN.Count)
            {
                for (int i = 0; i < SN.Count; i++)
                {
                    pairIndxs.Add(new int[2]);
                    pairIndxs[i][0] = i;
                    SN[i].Flagged = true;

                    for (int j = 0; j < TN.Count; j++)
                    {
                        d_temp = Math.Sqrt(Math.Pow(SN[i].Location.X - TN[j].Location.X, 2) + Math.Pow(SN[i].Location.Y - TN[j].Location.Y, 2));
                        if (d_temp < d)
                        {
                            d = d_temp;
                            pairIndxs[i][1] = j;
                        }
                    }
                    TN[pairIndxs[i][1]].Flagged = true;
                    dists.Add(d);
                    if (max_d <= d)
                    {
                        max_d = d;
                        max_d_IDs[0] = SN[i].ID;
                        max_d_IDs[1] = TN[pairIndxs[i][1]].ID;
                    }
                    d = 10e10;
                }
            }
            else
            {
                for (int j = 0; j < TN.Count; j++)
                {
                    pairIndxs.Add(new int[2]);
                    pairIndxs[j][1] = j;
                    TN[j].Flagged = true;

                    for (int i = 0; i < SN.Count; i++)
                    {
                        d_temp = Math.Sqrt(Math.Pow(SN[i].Location.X - TN[j].Location.X, 2) + Math.Pow(SN[i].Location.Y - TN[j].Location.Y, 2));
                        if (d_temp < d)
                        {
                            d = d_temp;
                            pairIndxs[j][0] = i;
                        }
                    }
                    SN[pairIndxs[j][0]].Flagged = true;
                    dists.Add(d);
                    if (max_d <= d)
                    {
                        max_d = d;
                        max_d_IDs[0] = SN[pairIndxs[j][0]].ID;
                        max_d_IDs[1] = TN[j].ID;
                    }
                    d = 10e10;
                }
            }

            if (pairIndxs.Count > 0)
            {
                M_S = SN[pairIndxs[0][0]];
                M_T = TN[pairIndxs[0][1]];

                logFile.WriteLine("\n\nNode pairs (source, target, change):");
                aPoint temp;
                for (int i = 0; i < pairIndxs.Count; i++)
                {
                    temp = new aPoint(SN[pairIndxs[i][0]].Location.X, SN[pairIndxs[i][0]].Location.Y, TN[pairIndxs[i][1]].Location.Z);
                    TN[pairIndxs[i][1]].Location = temp;

                    writeEquation(aCoordinate.Z, M_S, M_T, SN[pairIndxs[i][0]], TN[pairIndxs[i][1]], eqnSet);

                    logFile.WriteLine(SN[pairIndxs[i][0]].ID + ",\t" + TN[pairIndxs[i][1]].ID + ",\t" + dists[i]);
                }

                equationFile.WriteLine("*Nset, nset=Master_Z1");
                equationFile.WriteLine(M_S.ID);
                equationFile.WriteLine("*Nset, nset=Master_Z2");
                equationFile.WriteLine(M_T.ID);
            }

            if (SN.Count != TN.Count)
            {
                logFile.WriteLine("** Warning:\n\tThe number of nodes in the source and target face does not match");
                logFile.WriteLine("\t\tNo of Source face nodes\t" + SN.Count);
                logFile.WriteLine("\t\tNo of Target face nodes\t" + TN.Count);

                foreach (aNode n in SN)
                    if (!n.Flagged)
                    {
                        equationFile.WriteLine("*Nset, nset=UnMatch_Z_Src_" + n.ID);
                        equationFile.WriteLine(n.ID);
                    }
                foreach (aNode n in TN)
                    if (!n.Flagged)
                    {
                        equationFile.WriteLine("*Nset, nset=UnMatch_Z_Tgt_" + n.ID);
                        equationFile.WriteLine(n.ID);
                    }
            }

            logFile.WriteLine("**");
            logFile.WriteLine("** Maximum change made in Z direction = " + max_d);
            logFile.WriteLine("\t\tSource Node:\t" + max_d_IDs[0]);
            logFile.WriteLine("\t\tTarget Node:\t" + max_d_IDs[1]);
            logFile.WriteLine("**");
            equationFile.WriteLine("*Nset, nset=MaxChange_Z_" + max_d_IDs[0] + "_" + max_d_IDs[1]);
            equationFile.WriteLine(max_d_IDs[0] + ", " + max_d_IDs[1]);

            foreach (aNode n in TN)
                n.Flagged = false;
            foreach (aNode n in SN)
                n.Flagged = false;
        

        }
        */
        private bool ThisCisBestMatch(aCoordinate dxn, aNode C, double d_temp, List<aNode> SN)
        {
            double temp_d = d_temp;

            switch (dxn)
            {
                case aCoordinate.X:
                    {
                        for (int i = 0; i < SN.Count; i++)
                        {
                            if (!SN[i].Flagged)
                            {
                                temp_d = Math.Sqrt(Math.Pow(C.Location.Y - SN[i].Location.Y, 2) + Math.Pow(C.Location.Z - SN[i].Location.Z, 2));
                                if (temp_d < d_temp)
                                    return false;
                            }
                        }
                        break;
                    }
                case aCoordinate.Y:
                    {
                        for (int i = 0; i < SN.Count; i++)
                        {
                            if (!SN[i].Flagged)
                            {
                                temp_d = Math.Sqrt(Math.Pow(C.Location.X - SN[i].Location.X, 2) + Math.Pow(C.Location.Z - SN[i].Location.Z, 2));
                                if (temp_d < d_temp)
                                    return false;
                            }
                        }
                        break;
                    }
                case aCoordinate.Z:
                    {
                        for (int i = 0; i < SN.Count; i++)
                        {
                            if (!SN[i].Flagged)
                            {
                                temp_d = Math.Sqrt(Math.Pow(C.Location.X - SN[i].Location.X, 2) + Math.Pow(C.Location.X - SN[i].Location.X, 2));
                                if (temp_d < d_temp)
                                    return false;
                            }
                        }
                        break;
                    }
            }

            return true;
        }

        public void WriteRefinedMeshFile()
        {

            StreamWriter meshFile = new StreamWriter(iOmanager.Directory + "\\" + modelName + "_rMesh.inp");

            meshFile.WriteLine("*Node");
            foreach (aNode node in nodes)
            {
                meshFile.WriteLine(node.ID + ",\t" + node.Location.X + ",\t" + node.Location.Y + ",\t" + node.Location.Z);
            }

            int i = 0;
            aElemTypes tempType;

        A:
            tempType = elements[i].Type;
            meshFile.WriteLine("*Element, type=" + tempType.ToString());

            for (; i < elements.Count; i++)
            {
                if (elements[i].Type == tempType)
                {
                    meshFile.Write(elements[i].ID + ",\t");
                    for (int j = 0; j < elements[i].Nodes.Length - 1; j++)
                        meshFile.Write(elements[i].Nodes[j].ID + ",\t");
                    meshFile.WriteLine(elements[i].Nodes[elements[i].Nodes.Length - 1].ID);
                }
                else
                    goto A;
            }

            meshFile.WriteLine("*Step");
            meshFile.WriteLine("*End Step");

            meshFile.Close();

        }

        private void writeEquation(aCoordinate dxn, aNode M_S, aNode M_C, aNode S, aNode C, aEquationType[] eqnSet, aPBCtype PBCtype)
        {
            //equation Set matrix definition
            // X - direction DOF 1
            // X - direction DOF 2
            // X - direction DOF 3
            // Y - direction DOF 1
            // Y - direction DOF 2
            // Y - direction DOF 3
            // Z - direction DOF 1
            // Z - direction DOF 2
            // Z - direction DOF 3

            if (eqnSet == null)
                return;

            switch (dxn)
            {
                case aCoordinate.X:
                    {
                        if (eqnSet[0] != aEquationType.None || eqnSet[1] != aEquationType.None || eqnSet[2] != aEquationType.None)
                            PBC_File.WriteLine("*Equation");

                        // X direction displacement
                        if (eqnSet[0] == aEquationType.Type1)
                        {
                            PBC_File.WriteLine("4");
                            PBC_File.WriteLine("\t" + S.ID + ", 1, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 1, -1.,");
                            PBC_File.WriteLine("\t" + M_S.ID + ", 1, -1.,");
                            PBC_File.WriteLine("\t" + M_C.ID + ", 1, 1.,");
                        }
                        else if (eqnSet[0] == aEquationType.Type2)
                        {
                            PBC_File.WriteLine("2");
                            PBC_File.WriteLine("\t" + S.ID + ", 1, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 1, -1.,");
                        }

                        // Y direction displacement
                        if (eqnSet[1] == aEquationType.Type1)
                        {
                            PBC_File.WriteLine("4");
                            PBC_File.WriteLine("\t" + S.ID + ", 2, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 2, -1.,");
                            PBC_File.WriteLine("\t" + M_S.ID + ", 2, -1.,");
                            PBC_File.WriteLine("\t" + M_C.ID + ", 2, 1.,");
                        }
                        else if (eqnSet[1] == aEquationType.Type2)
                        {
                            PBC_File.WriteLine("2");
                            PBC_File.WriteLine("\t" + S.ID + ", 2, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 2, -1.,");
                        }

                        // Z direction displacement
                        if (eqnSet[2] == aEquationType.Type1)
                        {
                            PBC_File.WriteLine("4");
                            PBC_File.WriteLine("\t" + S.ID + ", 3, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 3, -1.,");
                            PBC_File.WriteLine("\t" + M_S.ID + ", 3, -1.,");
                            PBC_File.WriteLine("\t" + M_C.ID + ", 3, 1.,");
                        }
                        else if (eqnSet[2] == aEquationType.Type2)
                        {
                            PBC_File.WriteLine("2");
                            PBC_File.WriteLine("\t" + S.ID + ", 3, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 3, -1.,");
                        }
                        break;
                    }
                case aCoordinate.Y:
                    {
                        if (eqnSet[3] != aEquationType.None || eqnSet[4] != aEquationType.None || eqnSet[5] != aEquationType.None)
                            PBC_File.WriteLine("*Equation");

                        // X direction displacement
                        if (eqnSet[3] == aEquationType.Type1)
                        {
                            PBC_File.WriteLine("4");
                            PBC_File.WriteLine("\t" + S.ID + ", 1, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 1, -1.,");
                            PBC_File.WriteLine("\t" + M_S.ID + ", 1, -1.,");
                            PBC_File.WriteLine("\t" + M_C.ID + ", 1, 1.,");
                        }
                        else if (eqnSet[3] == aEquationType.Type2)
                        {
                            PBC_File.WriteLine("2");
                            PBC_File.WriteLine("\t" + S.ID + ", 1, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 1, -1.,");
                        }

                        // Y direction displacement
                        if (eqnSet[4] == aEquationType.Type1)
                        {
                            PBC_File.WriteLine("4");
                            PBC_File.WriteLine("\t" + S.ID + ", 2, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 2, -1.,");
                            PBC_File.WriteLine("\t" + M_S.ID + ", 2, -1.,");
                            PBC_File.WriteLine("\t" + M_C.ID + ", 2, 1.,");
                        }
                        else if (eqnSet[4] == aEquationType.Type2)
                        {
                            PBC_File.WriteLine("2");
                            PBC_File.WriteLine("\t" + S.ID + ", 2, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 2, -1.,");
                        }

                        // Z direction displacement
                        if (eqnSet[5] == aEquationType.Type1)
                        {
                            PBC_File.WriteLine("4");
                            PBC_File.WriteLine("\t" + S.ID + ", 3, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 3, -1.,");
                            PBC_File.WriteLine("\t" + M_S.ID + ", 3, -1.,");
                            PBC_File.WriteLine("\t" + M_C.ID + ", 3, 1.,");
                        }
                        else if (eqnSet[5] == aEquationType.Type2)
                        {
                            PBC_File.WriteLine("2");
                            PBC_File.WriteLine("\t" + S.ID + ", 3, 1.,");
                            PBC_File.WriteLine("\t" + C.ID + ", 3, -1.,");
                        }
                        break;
                    }
                case aCoordinate.Z:
                    {
                        if (eqnSet[6] != aEquationType.None || eqnSet[7] != aEquationType.None || eqnSet[8] != aEquationType.None)
                            PBC_File.WriteLine("*Equation");

                        // Individual nodes of each face are paired to the master node of their own face (Symmetric BC with unique connection of nodes)
                        if (PBCtype == aPBCtype.SymmForGENOA)
                        {
                            PBC_File.WriteLine("*Nset, nset=EqnSets-" + S.ID.ToString());
                            PBC_File.WriteLine(S.ID + ",");
                            PBC_File.WriteLine("*Nset, nset=EqnSets-" + C.ID.ToString());
                            PBC_File.WriteLine(C.ID + ",");

                            PBC_File.WriteLine("*Equation");
                            PBC_File.WriteLine("2");
                            PBC_File.WriteLine("EqnSets-" + S.ID + ", 3, 1.,");
                            PBC_File.WriteLine("Master_Z1" + ", 3, -1.,");

                            PBC_File.WriteLine("*Equation");
                            PBC_File.WriteLine("2");
                            PBC_File.WriteLine("EqnSets-" + C.ID + ", 3, 1.,");
                            PBC_File.WriteLine("Master_Z2" + ", 3, -1.,");
                            break;
                        }
                        //else if (PBCtype == aPBCtype.Symm)
                        //{

                        //}
                        else if (PBCtype == aPBCtype.Asymm)
                        {
                            // X direction displacement
                            if (eqnSet[6] == aEquationType.Type1)
                            {
                                PBC_File.WriteLine("4");
                                PBC_File.WriteLine("\t" + S.ID + ", 1, 1.,");
                                PBC_File.WriteLine("\t" + C.ID + ", 1, -1.,");
                                PBC_File.WriteLine("\t" + M_S.ID + ", 1, -1.,");
                                PBC_File.WriteLine("\t" + M_C.ID + ", 1, 1.,");
                            }
                            else if (eqnSet[6] == aEquationType.Type2)
                            {
                                PBC_File.WriteLine("2");
                                PBC_File.WriteLine("\t" + S.ID + ", 1, 1.,");
                                PBC_File.WriteLine("\t" + C.ID + ", 1, -1.,");
                            }

                            // Y direction displacement
                            if (eqnSet[7] == aEquationType.Type1)
                            {
                                PBC_File.WriteLine("4");
                                PBC_File.WriteLine("\t" + S.ID + ", 2, 1.,");
                                PBC_File.WriteLine("\t" + C.ID + ", 2, -1.,");
                                PBC_File.WriteLine("\t" + M_S.ID + ", 2, -1.,");
                                PBC_File.WriteLine("\t" + M_C.ID + ", 2, 1.,");
                            }
                            else if (eqnSet[7] == aEquationType.Type2)
                            {
                                PBC_File.WriteLine("2");
                                PBC_File.WriteLine("\t" + S.ID + ", 2, 1.,");
                                PBC_File.WriteLine("\t" + C.ID + ", 2, -1.,");
                            }

                            // Z direction displacement
                            if (eqnSet[8] == aEquationType.Type1)
                            {
                                PBC_File.WriteLine("4");
                                PBC_File.WriteLine("\t" + S.ID + ", 3, 1.,");
                                PBC_File.WriteLine("\t" + C.ID + ", 3, -1.,");
                                PBC_File.WriteLine("\t" + M_S.ID + ", 3, -1.,");
                                PBC_File.WriteLine("\t" + M_C.ID + ", 3, 1.,");
                            }
                            else if (eqnSet[8] == aEquationType.Type2)
                            {
                                PBC_File.WriteLine("2");
                                PBC_File.WriteLine("\t" + S.ID + ", 3, 1.,");
                                PBC_File.WriteLine("\t" + C.ID + ", 3, -1.,");
                            }
                        }
                        break;
                    }
            }
        }

        private bool IsWithinLimits(aCoordinate dxn, aNode N)
        {
            /*
             * limits
             * [ X_min, X_max
             *   Y_min, Y_max
             *   Z_min, Z_max ]
             */

            switch (dxn)
            {
                case aCoordinate.X:
                    {
                        throw new NotImplementedException();
                    }
                case aCoordinate.Y:
                    {
                        if (coordLimits[0, 0] + tolerances[0] < N.Location.X && N.Location.X < coordLimits[0, 1] - tolerances[0])
                            return true;
                        break;
                    }
                case aCoordinate.Z:
                    {
                        if (coordLimits[0, 0] + tolerances[0] < N.Location.X && N.Location.X < coordLimits[0, 1] - tolerances[0] &&
                            coordLimits[1, 0] + tolerances[1] < N.Location.Y && N.Location.Y < coordLimits[1, 1] - tolerances[1])
                            return true;
                        break;
                    }
            }

            return false;
        }

        /// <param name="data">Laminate information for GENOA</param>
        public void GenerateGENOAinput(double[,] data)
        {
            /************* data matrix layout *****************
             *                  Matrix          Axial tow           Bias tow
             *  FID:SID        [#int            #int                #int
             *  MID:SID         #int            #int                #int
             *  Thickness       #double         #double             #double
             *  Angle           #double         #double             #double
             *  VF              #double         #double             #double
             *  VV              #double         #double             #double
             *  FailCrit        #int            #int                #int
             *  Temp            #double         #double             #double]
             * 
            */



            
        }
    }
}
