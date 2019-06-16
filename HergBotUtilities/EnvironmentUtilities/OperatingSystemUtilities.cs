using System.Runtime.InteropServices;

namespace HergBot.Utilities.EnvironmentUtilities
{
    public class OperatingSystemUtilities
    {
        public static bool IsWindows()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }

        public static bool IsLinux()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        }
    }
}
