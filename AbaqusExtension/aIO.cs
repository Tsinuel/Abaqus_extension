using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AbaqusExtension
{
    public class aIO
    {
        private string inputFile;
        private string orientationFilePath;
        private string refinedMeshFilePath;
        private string directory;
        private aAssembly assembly;
        private string gENOAfile;

        /// <param name="inputFile">The Abaqus input file for the mesh to be read.</param>
        /// <param name="outputFilePath">The file path to which to write the output to.</param>
        /// <param name="assembly">The assembly for which the file is being managed</param>
        public aIO(string inputFile, string outputFilePath, aAssembly assembly)
        {
            this.inputFile = inputFile;
            this.orientationFilePath = outputFilePath + "_Ori.inp";
            this.assembly = assembly;
        }

        /// <param name="inputFile">The Abaqus input file for the mesh to be read.</param>
        /// <param name="assembly">The assembly for which the file is being managed</param>
        public aIO(string inputFile, aAssembly assembly, string directory)
        {
            this.inputFile = inputFile;
            this.assembly = assembly;
            this.directory = directory;

            gENOAfile = directory + "\\" + assembly.ModelName + "_Laminate_GENOA.dat";
        }

        /// <summary>
        /// Gets or sets directory to write the output file to.
        /// </summary>
        public string Directory
        {
            get
            {
                return this.directory;
            }

            set
            {
                this.directory = value;
            }
        }

        /// <summary>
        /// Gets or sets abaqus input file holding the mesh.
        /// </summary>
        public string InputFile
        {
            get
            {
                return this.inputFile;
            }

            set
            {
                this.inputFile = value;
            }
        }

        /// <summary>
        /// Abaqus input file holding the original mesh together with the added info with this program.
        /// </summary>
        public string OrientationFile
        {
            get
            {
                return this.orientationFilePath;
            }

            set
            {
                this.orientationFilePath = value;
            }
        }

        /// <summary>
        /// Gets the full assembly for which the data is written or read.
        /// </summary>
        public aAssembly Assembly
        {
            get
            {
                return this.assembly;
            }
        }

        /// <summary>
        /// Gets or sets the file path for refined mesh data
        /// </summary>
        public string RefinedMeshFile
        {
            get
            {
                return (directory + "\\refinedMesh.inp");
            }
        }

        /// <summary>
        /// Gets or sets the file path for GENOA laminate definition file
        /// </summary>
        public string GENOAfile
        {
            get
            {
                return gENOAfile;
            }
            set
            {
                gENOAfile = value;
            }
        }

        public List<aNode> GetNodes()
        {
            throw new System.NotImplementedException();
        }

        public List<aElement> GetElements()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Reads the input file
        /// </summary>
        public void ReadFile()
        {
            assembly.Initialize();

            StreamReader mainFile = new StreamReader(this.inputFile);
            string inputLine = "";
            object remainingPart;
            aAbaqusInputLineTypes lineType;
            aAbaqusKeywords activeKeyword = aAbaqusKeywords.None;
            aElemTypes currentElementType = aElemTypes.Default;
            bool dataLineEnded;
            bool isNewDataLine = true;
            int elemID = 0;
            int lineCount = 0;
            List<int> nodes = new List<int>();

            aNodeSet tempNSet = new aNodeSet("", false, assembly);

            //string[] allLines = File.ReadAllLines(inputFile);
            //FileStream fs = File.Open(inputFile, FileMode.Open);
            //BufferedStream bs = new BufferedStream(fs);
            //StreamReader mainFile = new StreamReader(bs);

            TOP:
            inputLine = mainFile.ReadLine();
            lineType = InvestigateInputLine(inputLine, out remainingPart, out dataLineEnded);

            switch (lineType)
            {
                case aAbaqusInputLineTypes.Keyword:
                    {
                        activeKeyword = (aAbaqusKeywords)((object[])remainingPart)[0];

                        switch (activeKeyword)
                        {
                            case aAbaqusKeywords.Node:
                                {
                                    break;
                                }
                            case aAbaqusKeywords.Element:
                                {
                                    string rem = (string)(((object[])remainingPart)[1]);
                                    string[] elemType = rem.Split('=');

                                    if (!Enum.TryParse<aElemTypes>(elemType[1], out currentElementType))
                                        throw new Exception("Element type:\"" + elemType[1] + "\" not recognised.");
                                    else if (currentElementType == aElemTypes.Default)
                                        throw new Exception("Element type:\"" + elemType[1] + "\" not recognised.");

                                    break;
                                }
                            case aAbaqusKeywords.End:
                                {
                                    activeKeyword = aAbaqusKeywords.None;
                                    break;
                                }
                            case aAbaqusKeywords.Material:
                                {
                                    string rem = (string)(((object[])remainingPart)[1]);
                                    string[] mats = rem.Split('=');
                                    assembly.Materials.Add(mats[1]);
                                    break;
                                }
                            case aAbaqusKeywords.Nset:
                                {
                                    tempNSet = new aNodeSet("", false, assembly);
                                    string rem = (string)(((object[])remainingPart)[1]);
                                    string[] nSetParams = rem.Split(',');
                                    string[] paramPrts;
                                    foreach(string par in nSetParams)
                                    {
                                        if ((par.Trim()).Equals("generate", StringComparison.OrdinalIgnoreCase))
                                        {
                                            tempNSet.IsInGenerateMode = true;
                                            continue;
                                        }
                                        else
                                        {
                                            paramPrts = par.Split('=');
                                            if (paramPrts[0].Trim().Equals("nset", StringComparison.OrdinalIgnoreCase))
                                                tempNSet.Name = paramPrts[1].Trim();
                                        }
                                    }
                                    assembly.Nsets.Add(tempNSet);
                                    break;
                                }
                            default:
                                {
                                    activeKeyword = aAbaqusKeywords.None;
                                    break;
                                }
                        }

                        break;
                    }
                case aAbaqusInputLineTypes.DataLine:
                    {
                        if (activeKeyword == aAbaqusKeywords.Node)
                        {
                            object[] data = (object[])remainingPart;
                            aPoint loc = new aPoint();

                            int id = int.Parse(data[0].ToString());
                            double x = double.Parse(data[1].ToString());
                            double y = double.Parse(data[2].ToString());
                            double z = 0.0;
                            if (data.Length == 4)
                            {
                                z = double.Parse(data[3].ToString());
                                loc = new aPoint(x, y, z);
                            }
                            else
                                loc = new aPoint(x, y);

                            assembly.Nodes.Add(new aNode(id, loc));
                        }
                        else if (activeKeyword == aAbaqusKeywords.Element)
                        {
                            object[] data = (object[])remainingPart;

                            if (isNewDataLine)
                            {
                                isNewDataLine = false;
                                elemID = int.Parse(data[0].ToString());

                                for (int i = 1; i < data.Length; i++)
                                    nodes.Add(int.Parse(data[i].ToString()));

                                if (dataLineEnded)
                                {
                                    assembly.Elements.Add(new aElement(elemID, currentElementType, FindNodes(nodes.ToArray())));

                                    nodes.Clear();
                                    isNewDataLine = true;
                                }
                            }

                            else if (dataLineEnded)
                            {
                                for (int i = 0; i < data.Length; i++)
                                    nodes.Add(int.Parse(data[i].ToString()));

                                assembly.Elements.Add(new aElement(elemID, currentElementType, FindNodes(nodes.ToArray())));

                                nodes.Clear();
                                isNewDataLine = true;
                            }
                            else
                            {
                                for (int i = 0; i < data.Length; i++)
                                    nodes.Add(int.Parse(data[i].ToString()));
                            }
                        }
                        else if (activeKeyword == aAbaqusKeywords.Nset)
                        {
                            object[] data = (object[])remainingPart;

                            if (tempNSet.IsInGenerateMode)
                            {
                                int n1 = int.Parse(data[0].ToString());
                                int n2 = int.Parse(data[1].ToString());
                                int i = 1;
                                if (data.Length == 3)
                                    i = int.Parse(data[2].ToString());
                                tempNSet.Add(n1, n2, i);
                            }
                            else
                                foreach (object obj in data)
                                    tempNSet.Add(int.Parse(obj.ToString()));
                        }
                        break;
                    }
                default:
                    {
                        activeKeyword = aAbaqusKeywords.None;
                        break;
                    }
            }

            if (!mainFile.EndOfStream)
            {
                lineCount++;
                goto TOP;
            }

            foreach (aNodeSet nset in assembly.Nsets)
                nset.RelateToNodeObjects();

            FillCoordinateLimits();
        }

        private void FillCoordinateLimits()
        {
            double min_X = 0, min_Y = 0, min_Z = 0;
            double max_X = 0, max_Y = 0, max_Z = 0;

            foreach(var node in assembly.Nodes)
            {
                if (node.Location.X < min_X)
                    min_X = node.Location.X;
                if (node.Location.X > max_X)
                    max_X = node.Location.X;

                if (node.Location.Y < min_Y)
                    min_Y = node.Location.Y;
                if (node.Location.Y > max_Y)
                    max_Y = node.Location.Y;

                if (node.Location.Z < min_Z)
                    min_Z = node.Location.Z;
                if (node.Location.Z > max_Z)
                    max_Z = node.Location.Z;
            }

            assembly.Minimum_X = min_X;
            assembly.Minimum_Y = min_Y;
            assembly.Minimum_Z = min_Z;

            assembly.Maximum_X = max_X;
            assembly.Maximum_Y = max_Y;
            assembly.Maximum_Z = max_Z;

        }

        private aNode[] FindNodes(int[] idList)
        {
            aNode[] nodes = new aNode[idList.Length];

            for (int i = 0; i < idList.Length; i++)
                nodes[i] = FindNode(idList[i]);
            
            return nodes;
        }

        private aNode FindNode(int id)
        {
            for (int i = 0;i<assembly.Nodes.Count;i++)
                if (assembly.Nodes[i].ID == id)
                    return assembly.Nodes[i];

            return null;
        }

        private aAbaqusInputLineTypes InvestigateInputLine(string inputLine, out object remainingPart, out bool dataLineEnded)
        {
            if (inputLine == null || inputLine == "")
                throw new Exception("Error reading input file Line!");

            dataLineEnded = true;

            if (inputLine[0] == '*')
            {
                if (inputLine[1] == '*')
                {
                    remainingPart = inputLine.Remove(0, 2);
                    return aAbaqusInputLineTypes.Comment;
                }
                else
                {
                    if (inputLine.StartsWith("*Node", StringComparison.OrdinalIgnoreCase))
                    {
                        object[] keywordLine = new object[2];
                        keywordLine[0] = aAbaqusKeywords.Node;
                        keywordLine[1] = inputLine.Remove(0, 5);

                        remainingPart = keywordLine;
                        return aAbaqusInputLineTypes.Keyword;
                    }
                    else if (inputLine.StartsWith("*Element", StringComparison.OrdinalIgnoreCase))
                    {
                        object[] keywordLine = new object[2];
                        keywordLine[0] = aAbaqusKeywords.Element;
                        keywordLine[1] = inputLine.Remove(0, 9);

                        remainingPart = keywordLine;
                        return aAbaqusInputLineTypes.Keyword;
                    }
                    else if (inputLine.StartsWith("*End", StringComparison.OrdinalIgnoreCase))
                    {
                        object[] keywordLine = new object[2];
                        keywordLine[0] = aAbaqusKeywords.End;
                        keywordLine[1] = inputLine.Remove(0, 4);

                        remainingPart = keywordLine;
                        return aAbaqusInputLineTypes.Keyword;
                    }
                    else if (inputLine.StartsWith("*Material", StringComparison.OrdinalIgnoreCase))
                    {
                        object[] keywordLine = new object[2];
                        keywordLine[0] = aAbaqusKeywords.Material;
                        keywordLine[1] = inputLine.Remove(0, 9);

                        remainingPart = keywordLine;
                        return aAbaqusInputLineTypes.Keyword;
                    }
                    else if (inputLine.StartsWith("*Nset", StringComparison.OrdinalIgnoreCase))
                    {
                        object[] keywordLine = new object[2];
                        keywordLine[0] = aAbaqusKeywords.Nset;
                        keywordLine[1] = inputLine.Remove(0, 5);

                        remainingPart = keywordLine;
                        return aAbaqusInputLineTypes.Keyword;
                    }
                    else
                    {
                        remainingPart = inputLine;
                        return aAbaqusInputLineTypes.Other;
                    }
                }
            }
            else
            {
                string trimmedLine = inputLine.Trim();
                if (trimmedLine[trimmedLine.Length - 1] == ',')
                    dataLineEnded = false;

                char[] separators = { ',', ' ' };
                remainingPart = inputLine.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                return aAbaqusInputLineTypes.DataLine;
            }

            throw new Exception("Unknown input file line read!");
        }
    }
}