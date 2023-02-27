namespace TryCatch;
    
public class OddNumberException : Exception
{
    //Message
    public override string Message
    {
        get
        {
            return "Error: Číslo je liché";
        }
    }
    //HelpLink
    public override string HelpLink
    {
        get
        {
            return "More Info: https://www.tutorialspoint.com/csharp/csharp_exception_handling.htm";
        }
    }
    
    //Source
    public override string Source
    {
        get
        {
            return $"Source: {StackTrace.Split('\r').First().Trim()}";
        }
    }
    
}    