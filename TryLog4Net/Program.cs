using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using log4net;

namespace TryLog4Net
{
	class Program
	{
		static void Main(string[] args)
		{
			ILog logger = LogManager.GetLogger(typeof(Program));

			for (int i = 0; i < 10; i++)
			{
				logger.Warn(string.Format("Log warn {0}", i));
				logger.Info(string.Format("Log info {0}", i));
				logger.Debug(string.Format("Log debug {0}", i));
				logger.Error(string.Format("Log error {0}", i));
				logger.Fatal(string.Format("Log fatal {0}", i));
				Thread.Sleep(TimeSpan.FromSeconds(1));
			}

			Console.ReadLine();
			return;
		}
	}
}
