using System.Net;
namespace TryCatch;

public class Server_diagnos
{
    public string url { get; set; }

    public string GetStatus(string url)
    {
        string ret;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "HEAD";
        request.AllowAutoRedirect = false;
        try
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            ret = url + " status: " + (int)response.StatusCode + " - " + response.StatusCode;
        }
        catch (WebException ex)
        {
            if (ex.Status == WebExceptionStatus.ProtocolError)
            {
                var response = ex.Response as HttpWebResponse;
                if (response != null)
                {
                    ret = "Error connecting to " + url + ": " + (int)response.StatusCode + " - " + ex.Status;
                }
                else
                {
                    ret = "Error connecting to " + url + ": " + ex.Status;
                }
            }
            else
            {
                ret = "Error connecting to " + url + ": " + ex.Status;
            }
            
        }

        return ret;
    }

    //loguje každých 5 sekundy
    public void repeat_log(string url)
    {
        while (true)
        {
            Console.WriteLine(GetStatus(url));
            Thread.Sleep(5000);
        }
    }
}