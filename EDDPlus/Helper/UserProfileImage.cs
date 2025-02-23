using System;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using Microsoft.Win32;

namespace EDDPlus.Helper;
public class UserProfileImage
{
    public static string GetUserProfileImageFromRegistry()
    {
        try
        {
            string userSid = System.Security.Principal.WindowsIdentity.GetCurrent().User?.Value;
            string registryPath = $@"SOFTWARE\Microsoft\Windows\CurrentVersion\AccountPicture\Users\{userSid}";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
            {
                if (key != null)
                {
                    foreach (string valueName in key.GetValueNames())
                    {
                        string imagePath = key.GetValue(valueName)?.ToString();
                        if (File.Exists(imagePath))
                        {
                            return imagePath;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"خطأ أثناء قراءة الـ Registry: {ex.Message}");
        }

        return null;
    }
}
