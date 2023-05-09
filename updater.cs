using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace launcher
{
    static class updater
    {
        private static string exename = AppDomain.CurrentDomain.FriendlyName;
        public static void checkUpdate(string curver, string path)
        {
            using (WebClient wc = new WebClient())
            {
                if (checkInternet.connection())
                {
                    wc.Headers["User-Agent"] = "Mozilla/5.0";
                    string readver = wc.DownloadString("http://x91524p0.beget.tech/data.php?key=version");
                    if (Convert.ToDouble(curver, CultureInfo.InvariantCulture) < Convert.ToDouble(readver, CultureInfo.InvariantCulture))
                    {
                        wc.Headers["User-Agent"] = "Mozilla/5.0";
                        wc.DownloadFile("http://x91524p0.beget.tech/launcher.exe", "new.exe");
                        Cmd($"taskkill /f /im \"{exename}\" && timeout /t 1 && del \"{path}{exename}\" && ren new.exe \"{exename}\" && \"{path}{exename}\"");
                    }
                }
                else
                    MessageBox.Show("Нет доступа в сеть");
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

        public static void checkFiles(string path)
        {
            string mod = "mods\\ttfr-1.12.1-1.9.1.jar";
            string mod2 = "mods\\industrialdecor_1.12.2_v21.1120.jar";
            string mod3 = "mods\\CustomMainMenu_MC1.12.2_2.0.8.jar";
            string cfg = "config\\betterfonts.cfg";
            string cfg2= "config\\CustomMainMenu\\mainmenu.json";
            string res = "resourcepacks\\KAMA.zip";
            string image = "launcher\\images\\logo.png";
            string gif = "launcher\\images\\back5.gif";


            if (File.Exists($"{path}resourcepacks\\1.12.zip"))
            {
                Cmd($"del \"{path}resourcepacks\\1.12.zip\"");
            }
            if (File.Exists($"{path}resourcepacks\\KB_Q_Rounded_Font.zip"))
            {
                Cmd($"del \"{path}resourcepacks\\KB_Q_Rounded_Font.zip\"");
            }

            if (File.Exists($"{path}{mod}"))
            {
                Cmd($"del \"{path}{mod}\"");
            }
            if (!File.Exists($"{path}{mod2}"))
            {
                using (WebClient wc = new WebClient())
                {
                    if (checkInternet.connection())
                    {
                        wc.Headers["User-Agent"] = "Mozilla/5.0";
                        wc.DownloadFile("http://x91524p0.beget.tech/industrialdecor_1.12.2_v21.1120.jar", "industrialdecor_1.12.2_v21.1120.jar");
                        Cmd($"move {path}industrialdecor_1.12.2_v21.1120.jar {path}{mod2}");
                    }
                    else
                        MessageBox.Show("Нет доступа в сеть");
                }
            }
            if (!File.Exists($"{path}{mod3}"))
            {
                using (WebClient wc = new WebClient())
                {
                    if (checkInternet.connection())
                    {
                        wc.Headers["User-Agent"] = "Mozilla/5.0";
                        wc.DownloadFile("http://x91524p0.beget.tech/CustomMainMenu_MC1.12.2_2.0.8.jar", "CustomMainMenu_MC1.12.2_2.0.8.jar");
                        Cmd($"move {path}CustomMainMenu_MC1.12.2_2.0.8.jar {path}{mod3}");
                    }
                    else
                        MessageBox.Show("Нет доступа в сеть");
                }
            }
            if (!File.Exists($"{path}{cfg2}"))
            {
                using (WebClient wc = new WebClient())
                {
                    if (checkInternet.connection())
                    {
                        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                        string newpath = $"{appdata}\\.kamalauncher\\config\\CustomMainMenu";
                        DirectoryInfo ach = new DirectoryInfo($"{newpath}");

                        if (!ach.Exists)
                            ach.Create();

                        wc.Headers["User-Agent"] = "Mozilla/5.0";
                        wc.DownloadFile("http://x91524p0.beget.tech/mainmenu.json", "mainmenu.json");
                        Cmd($"move {path}mainmenu.json {path}{cfg2}");
                    }
                    else
                        MessageBox.Show("Нет доступа в сеть");
                }
            }
            if (File.Exists($"{path}{cfg}"))
            {
                Cmd($"del \"{path}{cfg}\"");
            }
            if (!File.Exists($"{path}{res}"))
            {
                using (WebClient wc = new WebClient())
                {
                    if (checkInternet.connection())
                    {
                        wc.Headers["User-Agent"] = "Mozilla/5.0";
                        wc.DownloadFile("http://x91524p0.beget.tech/KAMA.zip", "KAMA.zip");
                        Cmd($"move {path}KAMA.zip {path}{res}");
                    }
                    else
                        MessageBox.Show("Нет доступа в сеть");
                }
            }
            if (!File.Exists($"{path}{image}"))
            {
                using (WebClient wc = new WebClient())
                {
                    if (checkInternet.connection())
                    {
                        wc.Headers["User-Agent"] = "Mozilla/5.0";
                        wc.DownloadFile("http://x91524p0.beget.tech/logo.png", "logo.png");
                        Cmd($"move {path}logo.png {path}{image}");
                    }
                    else
                        MessageBox.Show("Нет доступа в сеть");
                }
            }
            if (!File.Exists($"{path}{gif}"))
            {
                using (WebClient wc = new WebClient())
                {
                    if (checkInternet.connection())
                    {
                        wc.Headers["User-Agent"] = "Mozilla/5.0";
                        wc.DownloadFile("http://x91524p0.beget.tech/back5.gif", "back5.gif");
                        Cmd($"move {path}back5.gif {path}{gif}");
                    }
                    else
                        MessageBox.Show("Нет доступа в сеть");
                }
            }
        }
    }
}
