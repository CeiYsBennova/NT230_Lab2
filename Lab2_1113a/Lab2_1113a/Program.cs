using System;
using System.Net;
using System.Runtime.InteropServices;

var filename ="image.jpg";

new WebClient().DownloadFile("http://www.google.com/images/srpr/logo3w.png", filename);

string path = AppDomain.CurrentDomain.BaseDirectory;
ChangeWallpaper(path + filename);

[DllImport("user32.dll", CharSet = CharSet.Auto)]
static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

const int SPI_SETDESKWALLPAPER = 20;
const int SPIF_UPDATEINIFILE = 0x01;
const int SPIF_SENDWININICHANGE = 0x02;

void ChangeWallpaper(string path)
{
    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
}