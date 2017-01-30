using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton
{
    class SteamController
    {
        const string installDir = @"C:\Program Files (x86)\Steam\Steam.exe";

        public static bool IsSteamRunning()
        {
            return Process.GetProcessesByName("steam").Length != 0;
        }

        public static void KillSteam()
        {
            Process.GetProcessesByName("steam")[0].Kill();
        }

        public static bool StartSteamAccount(SteamAccount a)
        {
            bool finished = false;

            if (IsSteamRunning())
            {
                KillSteam();
            }

            while (!finished)
            {
                if (!IsSteamRunning())
                {
                    Process p = new Process();
                    if (File.Exists(installDir))
                    {
                        p.StartInfo = new ProcessStartInfo(installDir, a.getStartParameters());
                        p.Start();
                        finished = true;
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
