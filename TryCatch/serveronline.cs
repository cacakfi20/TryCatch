using System.Net.Sockets;

namespace TryCatch;

public class ServerFailException : Exception
{
    //Message
    public override string Message
    {
        get
        {
            return "Server není k dispozici (error)";
        }
    }
    public override string HelpLink
    {
        get
        {
            return "https://www.hostinger.com/tutorials/website/how-to-check-if-website-is-working-worldwide/";
        }
    }
}    

public class Serveronline
{
    public static string ServerActive(string adress, int port)
    {
        string serviceOnline;
        TcpClient tcpClient = new TcpClient();
        try
        {
            tcpClient.Connect(adress, port);
            serviceOnline = "Server je online";
        }
        catch (ServerFailException e)
        {
            serviceOnline = e.Message;
        }

        return serviceOnline;
    }
}