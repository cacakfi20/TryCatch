
/*

// DĚLENÍ NULOU 

bool program = true;

while (program)
{
    int a = 1;
    int b = 0;

    try
    {
        double result = a/b;
        Console.WriteLine($"{a} / {b} = {result}");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine(e.Message + " (Bylo použito dělení nulou)");
    }

    break;

}
*/ 

using System.Net;
namespace TryCatch
{
    class Program
    {
        
        static void Main()
        {
            /*
            try
            {
                int i = 1;
                if (i % 2 != 0)
                {
                    throw new OddNumberException();
                }
                else
                {
                    Console.WriteLine($"{i} je sudé");
                }
            }
            catch (OddNumberException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.HelpLink);
                Console.WriteLine(ex.Source);
            }
*/
            
            // http = 80, https = 443, ftp = 21
            string URL = "github.com";
            string online = Serveronline.ServerActive(URL, 443);
            Console.WriteLine(online);
            
            //
            
            WebRequest request = WebRequest.Create(URL);
            request.Method = "HEAD";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    // Use data for success case
                }
            }
            catch (WebException ex)
            {
                HttpWebResponse errorResponse = (HttpWebResponse) ex.Response;
                HttpStatusCode status = errorResponse.StatusCode;
                // etc
            }
        }
    }
}
