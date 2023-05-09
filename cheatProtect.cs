using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace launcher
{
    class cheatProtect
    {
        private static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string path;

        private static void uploadFiles(string path, string key)
        {
            if (key == "forge")
            {
                using (WebClient wc = new WebClient())
                {
                    if (checkInternet.connection())
                    {
                        wc.Headers["User-Agent"] = "Mozilla/5.0";
                        wc.DownloadFile("http://x91524p0.beget.tech/Forge1.12.2.jar", "Forge 1.12.2.jar");
                        Cmd($"move \"{appdata}\\.kamalauncher\\Forge 1.12.2.jar\" \"{path}\\Forge 1.12.2.jar\"");
                    }
                    else
                        MessageBox.Show("Нет доступа в сеть");
                }
            }
        }

        private static void Cmd(string line)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c {line}",
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }

        public static void startAC()
        {
            uploadFiles(path, "forge");
            Cmd($"del \"{appdata}\\.kamalauncher\\versions\\Forge 1.12.2\\Forge 1.12.2.jar\" && timeout /t 1 && move \"{appdata}\\.kamalauncher\\Forge 1.12.2.jar\" \"{appdata}\\.kamalauncher\\versions\\Forge 1.12.2\\Forge 1.12.2.jar\"");
        }

        private static string getCountMods()
        {
            return new DirectoryInfo($"{appdata}\\.kamalauncher\\mods").GetFiles().Length.ToString();
        }
        private static string getCountRes()
        {
            return new DirectoryInfo($"{appdata}\\.kamalauncher\\resourcepacks").GetFiles().Length.ToString();
        }

        public static bool checkModsRes()
        {
            if (getCountMods() == "15" && getCountRes() == "1")
                return true;
            else
                return false;
        }
    }
}
