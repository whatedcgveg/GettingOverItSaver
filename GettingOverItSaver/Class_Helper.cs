using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace GettingOverItSaver
{
    class Helper
    {
        public static void Save(string path)
        {
            byte[] save_1 = (byte[])Registry.GetValue(@"HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It", "SaveGame0_h1867918426", (object)0);
            byte[] save_2 = (byte[])Registry.GetValue(@"HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It", "SaveGame1_h1867918427", (object)0);
            int save_Num = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It", "NumSaves_h765021473", (object)0);

            string saveData = Encoding.UTF8.GetString(save_1) + "AAASplitAAA" + Encoding.UTF8.GetString(save_1) + "AAASplitAAA" + save_Num.ToString();

            try
            {
                StreamWriter sw = File.CreateText(path);
                sw.Write(saveData);
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Can't Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Read(string path)
        {
            string fileData = File.ReadAllText(path);
            string[] saveData = Regex.Split(fileData, "AAASplitAAA");
            if(saveData.Length == 3)
            {
                byte[] save_1 = Encoding.UTF8.GetBytes(saveData[0]);
                byte[] save_2 = Encoding.UTF8.GetBytes(saveData[1]);
                int save_Num = Convert.ToInt32(saveData[2]);

                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It", "SaveGame0_h1867918426", (object)save_1);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It", "SaveGame1_h1867918427", (object)save_2);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It", "NumSaves_h765021473", (object)save_Num);

            }
            else
            {
                MessageBox.Show("Can't Read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Del(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch {  }
        }
    }
}
