using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EDDPlus
{
    public class CPPImport
    {
        [DllImport("EDDSupport.dll")]
        public static extern void EncryptAll(string Input, string Output);

        [DllImport("EDDSupport.dll")]
        public static extern void DecryptAll(string Input, string Output);

        [DllImport("EDDSupport.dll")]
        public static extern int GetProgress();

        [DllImport("EDDSupport.dll", CharSet = CharSet.Ansi)]
        private static extern IntPtr ListFilesAndFolders(string path, out int count);

        [DllImport("EDDSupport.dll")]
        private static extern void FreeStringArray(IntPtr array, int count);

        [DllImport("EDDSupport.dll")]
        private static extern IntPtr GetAllPaths(string path, out int count);

        [DllImport("EDDSupport.dll")]
        private static extern void FreePaths(IntPtr paths, int count);

        [DllImport("EDDSupport.dll")]
        public static extern void CopyAndEncryptFolder(string sourcePath, string destPath);

        [DllImport("EDDSupport.dll")]
        public static extern void CopyAndDecryptFolder(string sourcePath, string destPath);

        public static string[] GetFilesAndFolders(string path)
        {
            int count;
            IntPtr arrayPtr = ListFilesAndFolders(path, out count);

            if (arrayPtr == IntPtr.Zero || count == 0)
                return Array.Empty<string>();

            string[] results = new string[count];

            // تحويل IntPtr إلى مؤشرات
            IntPtr[] pointers = new IntPtr[count];
            Marshal.Copy(arrayPtr, pointers, 0, count);

            // تحويل كل IntPtr إلى string
            for (int i = 0; i < count; i++)
            {
                results[i] = Marshal.PtrToStringAnsi(pointers[i]);
            }

            // تحرير الذاكرة
            FreeStringArray(arrayPtr, count);

            return results;
        }
        public static List<string> DeepGetAllPathsFromFolder(string folderPath)
        {
            List<string> pathsList = new List<string>();

            try
            {
                int count;
                IntPtr pathsPtr = GetAllPaths(folderPath, out count);

                if (pathsPtr != IntPtr.Zero)
                {
                    IntPtr[] pathArray = new IntPtr[count];
                    Marshal.Copy(pathsPtr, pathArray, 0, count);

                    for (int i = 0; i < count; i++)
                    {
                        string path = Marshal.PtrToStringAnsi(pathArray[i]);
                        if (!string.IsNullOrEmpty(path))
                        {
                            pathsList.Add(path);
                        }
                    }

                    // تحرير الذاكرة
                    FreePaths(pathsPtr, count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"خطأ: {ex.Message}");
            }

            return pathsList;
        }
    }
}
