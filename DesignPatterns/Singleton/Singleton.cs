namespace DesignPatterns.Singleton;

// Interface do Logger
public interface ILogger
{
    void Write(string message);
}

// Implementação do Logger
public class Logger : ILogger
{
    private static ILogger? _instance;

    // Construtor privado
    private Logger() {}

    // Garante uma instância única da classe
    public static ILogger GetInstance()
    {
        if (_instance is null)
            _instance = new Logger();
        
        return _instance;
    }

    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}

public class ClientCode
{
    public void Consumer()
    {
       // var logger = new Logger(); // Error
        var logger1 = Logger.GetInstance();
        var logger2 = Logger.GetInstance(); // mesma referência que logger1
        logger1.Write("singleton");
        logger2.Write("singleton");
    }
}
