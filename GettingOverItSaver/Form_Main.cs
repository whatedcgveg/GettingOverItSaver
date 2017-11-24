using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GettingOverItSaver
{
    public partial class Form_Main : Form
    {
        string crtDir = Environment.CurrentDirectory + "\\";
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            FindSaveFiles();
        }

        private void FindSaveFiles()
        {
            string[] files = Directory.GetFiles(crtDir);
            Array.Sort(files);
            Array.Reverse(files);
            foreach(string file in files)
            {
                string[] temp = file.Split('\\');
                if(temp.Length>=2)
                {
                    string name = temp[temp.Length - 1];
                    if(name.EndsWith(".save"))
                    {
                        listBox_Main.Items.Add(name);
                    }
                }
            }

            if (listBox_Main.Items.Count > 0)
            {
                listBox_Main.SelectedIndex = 0;
            }
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            if (listBox_Main.SelectedIndex != -1)
            {
                Helper.Read(listBox_Main.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("You must select one item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string name = dt.ToString("yyyy MM dd HH mm ss") + ".save";

            Helper.Save(crtDir + name);
            listBox_Main.Items.Insert(0,name);
            listBox_Main.SelectedIndex = 0;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Main.SelectedIndex != -1)
            {
                Helper.Del(listBox_Main.SelectedItem.ToString());
                listBox_Main.Items.RemoveAt(listBox_Main.SelectedIndex);
            }
            else
            {
                MessageBox.Show("You must select one item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel_Website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.rainng.com/");
        }

        private void linkLabel_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/Azure99");
        }
    }
}
