using Services.Abstract;

namespace Services.Concrete
{
	public class LoggerManager : ILoggerService
	{
		public void Log(string message)
		{
			Serilog.Log.Information(message);
		}

		public void LogDebug(string message)
		{
			Serilog.Log.Debug(message);
		}

		public void LogError(string message)
		{
			Serilog.Log.Error(message);
		}

		public void LogWarning(string message)
		{
			Serilog.Log.Warning(message);
		}
	}
}
