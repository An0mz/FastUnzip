using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using Microsoft.Win32;
using System.Security.Principal; // For Admin check

namespace ZipAutoExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0].Equals("--install", StringComparison.OrdinalIgnoreCase))
            {
                if (!IsRunAsAdministrator())
                {
                    Console.WriteLine("Please run as Administrator to install FastUnzip.");
                    return;
                }

                InstallRegistryKeys();
                Console.WriteLine("FastUnzip installed successfully! Now double-click any .zip to extract it automatically.");
                return;
            }

            if (args.Length == 0)
            {
                Console.WriteLine("No file provided to extract.");
                return;
            }

            string zipPath = args[0];

            if (File.Exists(zipPath) && Path.GetExtension(zipPath).Equals(".zip", StringComparison.OrdinalIgnoreCase))
            {
                string extractPath = Path.Combine(
                    Path.GetDirectoryName(zipPath),
                    Path.GetFileNameWithoutExtension(zipPath)
                );

                try
                {
                    ZipFile.ExtractToDirectory(zipPath, extractPath, overwriteFiles: true);
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid file.");
            }
        }

        private static void InstallRegistryKeys()
        {
            string exePath = Assembly.GetExecutingAssembly().Location.Replace("/", "\\");

            Registry.SetValue(@"HKEY_CLASSES_ROOT\.zip", "", "FastUnzip.ZipFile");

            Registry.SetValue(@"HKEY_CLASSES_ROOT\FastUnzip.ZipFile", "", "Zip Archive (FastUnzip)");

            string command = $"\"{exePath}\" \"%1\"";
            Registry.SetValue(@"HKEY_CLASSES_ROOT\FastUnzip.ZipFile\shell\open\command", "", command);

            string iconPath = $"{exePath},0";
            Registry.SetValue(@"HKEY_CLASSES_ROOT\FastUnzip.ZipFile", "DefaultIcon", iconPath);
        }


        private static bool IsRunAsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}
