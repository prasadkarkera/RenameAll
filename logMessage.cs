using System;
using log4net;
using Rename;

namespace Rename
{
	/// <summary>
	/// this will be used to log the messsages using logger class
	/// Also additionally this will raise an event that will be captured by the 
	/// UI to display the log messages.
	/// </summary>
	/// 
 
	public class LogMessage
	{   
		public enum LogType
		{
			Debug = 0,
			Info = 1,
			Error = 2,
			Fatal = 3
		}
		/// <summary>
		/// use this class to log the debug messages, error messages
		/// </summary>
		private static readonly ILog logger = LogManager.GetLogger(typeof(LogMessage).Name);

		/// <summary>
		/// logs the message to an external file using log4net class.
		/// </summary>
		/// <param name="message">message to log</param>
		/// <param name="logType">message type</param>
		public static void LogMsg(string message, LogType logType)
		{
			switch(logType)
			{
				case LogType.Debug:
					logger.Debug(message);
					break;
				case LogType.Info:
					logger.Info(message);
					break;
				case LogType.Error:
					logger.Error(message);
					break;
				case LogType.Fatal:
					logger.Fatal(message);
					break;
			}
		}

	}
}
