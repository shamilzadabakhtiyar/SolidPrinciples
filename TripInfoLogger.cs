public class TripInfoLogger
{
    private readonly Ilogger logger;
    public TripInfoLogger(Ilogger logger)
    {
        this.logger = logger;
    }
    // public void LogGermany(string tripInfo)
    // {
    //     new GermanyLogger().Log(tripInfo);
    // }

    // public void LogToLocalStorage(string tripInfo)
    // {
    //     new LocalStorageLogger().Log(tripInfo);
    // }
    public void Log(string logInfo)
    {
        logger.Log(logInfo);
    }
}

public interface Ilogger
{
    void Log(string logInfo);
}

public class GermanyLogger: Ilogger
{
    public void Log(string logStr)
    {

    }
}

public class LocalStorageLogger: Ilogger
{
    public void Log(string logStr)
    {

    }
}