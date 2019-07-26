using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_BMICalculator
{
    public static class Program
    {
        public static BMICalculator bmiCalculator;
        public static SplashScreen splashScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bmiCalculator = new BMICalculator();
            splashScreen = new SplashScreen();
            Application.Run(splashScreen);
        }
    }
}
