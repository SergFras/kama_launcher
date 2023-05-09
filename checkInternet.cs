using System.Net;

namespace launcher
{
    class checkInternet
    {
        public static bool connection()
        {
            try
            {
                Dns.GetHostEntry("x91524p0.beget.tech");
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
