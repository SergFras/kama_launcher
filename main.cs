using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using static launcher.iniFile;

namespace launcher
{
    public partial class main : Form
    {
        private string path;
        private string curver = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
        
        private void createPath()
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = $"{appdata}\\.kamalauncher\\";
        }

        public main()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
            this.Text = $"KAMACraft Launcher v{curver}";
            createPath();
            updater.checkUpdate(curver, path);
            updater.checkFiles(path);

            newPosters.Image = Image.FromFile($"{path}launcher\\images\\back5.gif");
            logo.Image = Image.FromFile($"{path}launcher\\images\\logo.png");
            
            INIManager manager = new INIManager($"{path}launcher\\opt.ini");
            tbNickname.Text = manager.GetPrivateString("main", "nickName");
            tbMemory.Text = manager.GetPrivateString("main", "memory");

            if (tbMemory.Text == string.Empty)
            {
                tbMemory.Text = "2048";
            }
            if (tbNickname.Text == string.Empty)
            {
                tbNickname.Text = "Your Nickname";
            }
        }
        public static void ReplaceFile(string FileToMoveAndDelete, string FileToReplace, string BackupOfFileToReplace)
        {
            File.Replace(FileToMoveAndDelete, FileToReplace, BackupOfFileToReplace, false);
        }

        private void minecraftStart()
        {
            cheatProtect.startAC();
            Thread.Sleep(3000);

            INIManager manager = new INIManager($"{path}launcher\\opt.ini");
            //Получить значение по ключу name из секции main
            //string name = manager.GetPrivateString("main", "name");

            //Записать значение по ключу age в секции main
            manager.WritePrivateString("main", "nickname", tbNickname.Text.ToString());
            manager.WritePrivateString("main", "memory", tbMemory.Text.ToString());

            string memory = tbMemory.Text.ToString();
            string nickname = tbNickname.Text.ToString();
            string start = $"{path}runtime\\jre-legacy\\windows\\jre-legacy\\bin\\javaw.exe -Djava.library.path=\"{path}versions\\Forge 1.12.2\\natives\" -cp {path}libraries\\net\\minecraftforge\\forge\\1.12.2-14.23.5.2860\\forge-1.12.2-14.23.5.2860.jar;{path}libraries\\org\\ow2\\asm\\asm-debug-all\\5.2\\asm-debug-all-5.2.jar;{path}libraries\\net\\minecraft\\launchwrapper\\1.12\\launchwrapper-1.12.jar;{path}libraries\\org\\jline\\jline\\3.5.1\\jline-3.5.1.jar;{path}libraries\\com\\typesafe\\akka\\akka-actor_2.11\\2.3.3\\akka-actor_2.11-2.3.3.jar;{path}libraries\\com\\typesafe\\config\\1.2.1\\config-1.2.1.jar;{path}libraries\\org\\scala-lang\\scala-actors-migration_2.11\\1.1.0\\scala-actors-migration_2.11-1.1.0.jar;{path}libraries\\org\\scala-lang\\scala-compiler\\2.11.1\\scala-compiler-2.11.1.jar;{path}libraries\\org\\scala-lang\\plugins\\scala-continuations-library_2.11\\1.0.2_mc\\scala-continuations-library_2.11-1.0.2_mc.jar;{path}libraries\\org\\scala-lang\\plugins\\scala-continuations-plugin_2.11.1\\1.0.2_mc\\scala-continuations-plugin_2.11.1-1.0.2_mc.jar;{path}libraries\\org\\scala-lang\\scala-library\\2.11.1\\scala-library-2.11.1.jar;{path}libraries\\org\\scala-lang\\scala-parser-combinators_2.11\\1.0.1\\scala-parser-combinators_2.11-1.0.1.jar;{path}libraries\\org\\scala-lang\\scala-reflect\\2.11.1\\scala-reflect-2.11.1.jar;{path}libraries\\org\\scala-lang\\scala-swing_2.11\\1.0.1\\scala-swing_2.11-1.0.1.jar;{path}libraries\\org\\scala-lang\\scala-xml_2.11\\1.0.2\\scala-xml_2.11-1.0.2.jar;{path}libraries\\lzma\\lzma\\0.0.1\\lzma-0.0.1.jar;{path}libraries\\java3d\\vecmath\\1.5.2\\vecmath-1.5.2.jar;{path}libraries\\net\\sf\\trove4j\\trove4j\\3.0.3\\trove4j-3.0.3.jar;{path}libraries\\org\\apache\\maven\\maven-artifact\\3.5.3\\maven-artifact-3.5.3.jar;{path}libraries\\net\\sf\\jopt-simple\\jopt-simple\\5.0.3\\jopt-simple-5.0.3.jar;{path}libraries\\org\\apache\\logging\\log4j\\log4j-api\\2.15.0\\log4j-api-2.15.0.jar;{path}libraries\\org\\apache\\logging\\log4j\\log4j-core\\2.15.0\\log4j-core-2.15.0.jar;{path}libraries\\org\\tlauncher\\patchy\\1.3.9\\patchy-1.3.9.jar;{path}libraries\\oshi-project\\oshi-core\\1.1\\oshi-core-1.1.jar;{path}libraries\\net\\java\\dev\\jna\\jna\\4.4.0\\jna-4.4.0.jar;{path}libraries\\net\\java\\dev\\jna\\platform\\3.4.0\\platform-3.4.0.jar;{path}libraries\\com\\ibm\\icu\\icu4j-core-mojang\\51.2\\icu4j-core-mojang-51.2.jar;{path}libraries\\net\\sf\\jopt-simple\\jopt-simple\\5.0.3\\jopt-simple-5.0.3.jar;{path}libraries\\com\\paulscode\\codecjorbis\\20101023\\codecjorbis-20101023.jar;{path}libraries\\com\\paulscode\\codecwav\\20101023\\codecwav-20101023.jar;{path}libraries\\com\\paulscode\\libraryjavasound\\20101123\\libraryjavasound-20101123.jar;{path}libraries\\com\\paulscode\\librarylwjglopenal\\20100824\\librarylwjglopenal-20100824.jar;{path}libraries\\com\\paulscode\\soundsystem\\20120107\\soundsystem-20120107.jar;{path}libraries\\io\\netty\\netty-all\\4.1.9.Final\\netty-all-4.1.9.Final.jar;{path}libraries\\com\\google\\guava\\guava\\21.0\\guava-21.0.jar;{path}libraries\\org\\apache\\commons\\commons-lang3\\3.5\\commons-lang3-3.5.jar;{path}libraries\\commons-io\\commons-io\\2.5\\commons-io-2.5.jar;{path}libraries\\commons-codec\\commons-codec\\1.10\\commons-codec-1.10.jar;{path}libraries\\net\\java\\jinput\\jinput\\2.0.5\\jinput-2.0.5.jar;{path}libraries\\net\\java\\jutils\\jutils\\1.0.0\\jutils-1.0.0.jar;{path}libraries\\com\\google\\code\\gson\\gson\\2.8.0\\gson-2.8.0.jar;{path}libraries\\org\\tlauncher\\authlib\\1.6.251\\authlib-1.6.251.jar;{path}libraries\\com\\mojang\\realms\\1.10.22\\realms-1.10.22.jar;{path}libraries\\org\\apache\\commons\\commons-compress\\1.8.1\\commons-compress-1.8.1.jar;{path}libraries\\org\\apache\\httpcomponents\\httpclient\\4.3.3\\httpclient-4.3.3.jar;{path}libraries\\commons-logging\\commons-logging\\1.1.3\\commons-logging-1.1.3.jar;{path}libraries\\org\\apache\\httpcomponents\\httpcore\\4.3.2\\httpcore-4.3.2.jar;{path}libraries\\it\\unimi\\dsi\\fastutil\\7.1.0\\fastutil-7.1.0.jar;{path}libraries\\org\\apache\\logging\\log4j\\log4j-api\\2.8.1\\log4j-api-2.8.1.jar;{path}libraries\\org\\apache\\logging\\log4j\\log4j-core\\2.8.1\\log4j-core-2.8.1.jar;{path}libraries\\org\\lwjgl\\lwjgl\\lwjgl\\2.9.4-nightly-20150209\\lwjgl-2.9.4-nightly-20150209.jar;{path}libraries\\org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.4-nightly-20150209\\lwjgl_util-2.9.4-nightly-20150209.jar;{path}libraries\\com\\mojang\\text2speech\\1.10.3\\text2speech-1.10.3.jar;\"{ path}versions\\Forge 1.12.2\\Forge 1.12.2.jar\" -Xmx{memory}M -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -Djava.net.preferIPv4Stack=true -Dminecraft.applet.TargetDirectory={path} -Dlog4j.configurationFile={path}assets\\log_configs\\client-1.12.xml net.minecraft.launchwrapper.Launch --username {nickname} --version \"Forge 1.12.2\" --gameDir {path} --assetsDir assets --assetIndex 1.12 --uuid null --accessToken null --userType legacy --tweakClass net.minecraftforge.fml.common.launcher.FMLTweaker --versionType Forge --width 925 --height 530";

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = $"/C {start}";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (tbNickname.Text.Length >= 5 && tbNickname.Text.Length <= 15)
            {
                if(int.Parse(tbMemory.Text.ToString()) > 512)
                {
                    using (WebClient wc = new WebClient())
                    {
                        if (checkInternet.connection())
                        {
                            if (cheatProtect.checkModsRes())
                            {
                                minecraftStart();
                                checkData.Start();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Возникли проблемы с лаунчером (Код ошибки 01)\nСвязаться - vk.com/kamacraft_ru");
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Нет доступа в сеть");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Возникли проблемы с лаунчером (Код ошибки 03)\nСвязаться - vk.com/kamacraft_ru");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Ник должен быть больше 5 символов и меньше 15!\nСвязаться - vk.com/kamacraft_ru");
                this.Close();
            }
        }

        private void tbNickname_Click(object sender, EventArgs e)
        {
            tbNickname.Text = "";
        }

        int checkTimer = 0;

        private void checkData_Tick(object sender, EventArgs e)
        {
            checkTimer++;
            if (!cheatProtect.checkModsRes())
            {
                proсClose();

                MessageBox.Show("Возникли проблемы с игровым клиентом (Код ошибки 02)\nСвязаться - vk.com/kamacraft_ru");
                this.Close();
            }
            else
            {
                if (checkTimer >= 240)
                    this.Close();
            }
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            proсClose();
        }

        private void proсClose()
        {
            if(checkTimer < 240)
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/C taskkill /IM javaw.exe /F";
                p.StartInfo.CreateNoWindow = true;
                p.Start();
            }
        }
    }
}
