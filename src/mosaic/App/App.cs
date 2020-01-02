using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Windows.Forms;

namespace Mosaic
{
	public sealed class App
	{
		#region Static
		private static App instance = null;
		public static void Init() { new App(); }
		public static App Instance { get { if (instance == null) throw new MosaicException("App instance is null."); return instance; } }
		public static Config Config { get { return Instance.config; } }
		public static MainForm MainForm { get { return Instance.mainForm; } set { Instance.mainForm = value; } }
		public static bool IsConfigLoaded { get { return instance != null && instance.config!=null; } }
		public static AssemblyInfo AssemblyInfo { get { return Instance.assemblyInfo; } }
		#endregion

		#region Fields
		Config config;
		MainForm mainForm;
		AssemblyInfo assemblyInfo;
		#endregion

		#region Properties
		#endregion

		#region Construction
		App()
		{
			using (WaitCursor wc = new WaitCursor())
			{
				if (App.instance != null) throw new MosaicException("App instance already created.");
				
				instance = this;
				assemblyInfo = new AssemblyInfo();

                Log.LogSystem.AddLogHandlers(new FileLog(), new MessageFormLogInformer());
                Locale.StringSet.Load();
				Log.Info("AppStart");
				config = Config.Load();
			}
		}

		#endregion

	}

	public interface IPrintable
	{
		void Print(PageSetupDialog dlgPageSetup);
	}

	public class MosaicException : Exception
	{
		public MosaicException() : base() { }
		public MosaicException(string message) : base(message) { }
		public MosaicException(string message, Exception innerException) : base(message, innerException) { }
	}
}
