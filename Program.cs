using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCardGenerator
{
	internal static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Para Windows 10 versión 1703 y posterior
			if (Environment.OSVersion.Version.Major >= 6)
			{
				SetProcessDpiAwareness(ProcessDpiAwareness.ProcessPerMonitorDpiAware);
			}

			Application.Run(new fMain());
		}

		// Importar API de Windows
		[DllImport("shcore.dll")]
		static extern int SetProcessDpiAwareness(ProcessDpiAwareness awareness);

		enum ProcessDpiAwareness
		{
			ProcessDpiUnaware = 0,
			ProcessSystemDpiAware = 1,
			ProcessPerMonitorDpiAware = 2
		}
	}
}
