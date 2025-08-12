using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbaqusExtension.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //double[,] a = { { 5, 3, 6 }, { 9, 6, -7 }, { 1, 3, -6 } };
            //Matrix m = new Matrix(a);
            //m = m.Inverse();




            //aPoint P;
            //P = new aPoint(3.46410162, -2.00000000, -0.00028199);
            //aPoint orig = new aPoint(6.92820323, -4.00000000, -10.44109280);
            //aPoint u = new aPoint(10.39230485, -6.00000000, -0.00028199);
            //aPoint v = new aPoint(3.46473912, -2.00036806, 0.00000000);
            ////aPoint v = new aPoint(1.17057213, 2.31171313, 1.01771474);

            //aPoint _P = aPoint.Transform(orig, u, v, P);
            //aPoint _PP = aPoint.Transform(orig, u, v, _P, true);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


    }
}
