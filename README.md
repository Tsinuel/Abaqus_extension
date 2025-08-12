# Abaqus_extension

Abaqus_extension is a C# project designed to extend the functionality of the Abaqus finite element analysis (FEA) software suite. The repository includes libraries and tools to facilitate the manipulation, enhancement, and automation of Abaqus input files, particularly for mesh and assembly operations.

## Features

- **Mesh and Assembly Management:** Classes like `aAssembly`, `aElement`, `aNode`, and `aTow` provide programmatic access and processing for nodes, elements, materials, sections, orientations, and more, enabling sophisticated manipulation of Abaqus models.
- **Input/Output Automation:** The `aIO` class manages reading and writing of Abaqus input files, allowing automated modification and generation of files with additional information required for advanced simulations.
- **Periodic Boundary Conditions (PBC):** Support for applying periodic boundary conditions programmatically via the `ApplyPBCs` method.
- **Extensible Data Structures:** The library provides extensible data structures for finite element nodes, elements, element sets, node sets, and composite tows, aiding in the construction and modification of complex assemblies.
- **Integration with Math Libraries:** Dependencies include MathNet.Numerics and FSharp.Core, facilitating numerical computation and mathematical operations within the extension.

## Graphical User Interface (GUI)

Main interface (Orientation):

![Main GUI Window_tab1](./images/Main_window_tab1.png)

Main interface (Periodic-boundary-condition (PBC)):

![Main GUI Window_tab2](./images/Main_window_tab2.png)

View mesh data:

![View_mesh_data](./images/Mesh_data_window.png)

Define tow properties:

![Define_tow_properties](./images/Tow_properties_windows.png)

## Pre-compiled Installer

A pre-compiled installable `.exe` is available in the [`./publish`](./publish) directory.  
**To install and run the Abaqus_extension GUI or tools without building from source:**
1. Download the latest `.exe` from the [`publish`](./publish) folder.
2. Double-click the executable to launch the application.

## Directory Structure

- `AbaqusExtension/` — Core library with classes for assembly, elements, mesh, and IO operations.
- `AbaqusExtension_GUI/` — (Optional) GUI layer for interactive use, including resources and form logic.
- `publish/` — Pre-built, installable `.exe` and related files for direct use.
- `LICENSE` — MIT License.

## Getting Started

1. **Option 1: Use Pre-compiled Installer**
   - See [Pre-compiled Installer](#pre-compiled-installer) above.

2. **Option 2: Build from Source**
   - Clone the repository:
     ```bash
     git clone https://github.com/Tsinuel/Abaqus_extension.git
     ```
   - Open the solution in Visual Studio (2012 or 2015 recommended).
   - Restore NuGet packages (MathNet.Numerics, FSharp.Core).
   - Build the solution.
   - Use the compiled libraries or the GUI (if present) to interact with Abaqus input files.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contributing

Contributions, bug reports, and feature requests are welcome! Please open issues or submit pull requests.

## Disclaimer

This project is not affiliated with or endorsed by Dassault Systèmes or the Abaqus software team.
