namespace Services.Abstract
{
	public interface ILoggerService
	{
		void Log(string message);
		void LogWarning(string message);
		void LogError(string message);
		void LogDebug(string message);
	}
}
