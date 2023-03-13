using System.Net;
namespace TryCatch
{
    class Program
    {
        
        static void Main()
        {
            Server_diagnos srv = new Server_diagnos();
            srv.repeat_log("https://http.cat/201");
        }
    }
}
