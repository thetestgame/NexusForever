using System.Runtime.InteropServices;

namespace NexusForever.Shared.Util
{
    /// <summary>
    /// Utility class for determining the host operating system
    /// </summary>
    public static class OperatingSystem
    {
        /// <summary>
        /// Checks if the current host is Windows
        /// </summary>
        /// <returns>Returns true if running on Windows</returns>
        public static bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        /// <summary>
        /// Checks if the current host is MacOs
        /// </summary>
        /// <returns>Returns true if running on MacOs</returns>
        public static bool IsMacOS() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        
        /// <summary>
        /// Checks if the current host is a Linux Distrubtion
        /// </summary>
        /// <returns>Returns true if running on Linux</returns>
        public static bool IsLinux() => RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
    }
}
