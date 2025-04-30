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
            string exePath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName.Replace("/", "\\");

            try
            {
                using (RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64))
                {
                    root.CreateSubKey(@".zip")?.SetValue("", "FastUnzip.ZipFile");

                    var typeKey = root.CreateSubKey(@"FastUnzip.ZipFile");
                    typeKey?.SetValue("", "Zip Archive (FastUnzip)");
                    typeKey?.SetValue("DefaultIcon", $"{exePath},0");

                    root.CreateSubKey(@"FastUnzip.ZipFile\shell\open\command")
                        ?.SetValue("", $"\"{exePath}\" \"%1\"");
                }

                Console.WriteLine("Registry keys written successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing registry: " + ex.Message);
            }
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
