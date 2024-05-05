using System;

public interface ILogger
{
    void Log(string message);

    // Phương thức mặc định
    public void LogError(string errorMessage)
    {
        Log($"LỖI: {errorMessage}");
    }
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();

        logger.Log("Thông điệp thông tin");
        logger.LogError("Đã xảy ra lỗi");
    }
}
