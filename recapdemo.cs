
namespace recapdemo
{
    class Program
{
 
    static void Main(string[]args)
    {

        
        customer loglama = new customer();
        loglama.loggerr = new FileLogger();
        
        loglama.Add();
        
        
        

    }
}

class customer
{
    public Ilogger loggerr {get; set;}
    public void Add()
    {
        loggerr.log();
        System.Console.WriteLine("Added!");
    }

}


class FileLogger : Ilogger
{
    public void log()
    {
        System.Console.WriteLine("File Logged by Me");
    }
}
class DataBaseLogger : Ilogger
{
    public void log(){
        System.Console.WriteLine("DataBase Logged to by me");
    }
}

interface Ilogger
{
    void log();
}

}

