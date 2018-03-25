using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace searching
{
    public partial class Form1 : Form
    {
        List<string> directories = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }
        private void LoadDrives()
        {
            string[] drv = Directory.GetLogicalDrives();
            for (int i = 0; i < drv.Length; i++)
            {
                try
                {
                    Directory.GetDirectories(drv[i]);
                    cmbDrivers.Items.Add(drv[i].ToString());
                }
                catch { }
                
            }
            cmbDrivers.SelectedItem = cmbDrivers.Items[1];
            SearchDirectory(@cmbDrivers.SelectedItem.ToString());
        }
        public void SearchDirectory(string drive)
        {//@cmbDrivers.SelectedItem.ToString()
            string[] dirs = Directory.GetDirectories(drive);
            directories.AddRange(dirs);
            int count = 0;
            int max = 0;
            int lastCount = 0;
            
            
            while (true)
            {
                List<string> listDirs = new List<string>();
                max = directories.Count;
                for (int i = lastCount; i < max; i++)
                {
                    string[] subDirs = new string[0];
                    try
                    {
                        subDirs = Directory.GetDirectories(directories[i]);
                        if (subDirs.Length != 0)
                        {
                            listDirs.AddRange(subDirs);
                        }
                        else
                            count++;
                    }
                    catch (Exception ex)
                    {
                        count++;
                    }
                }
                if (count == (max - lastCount))
                    break;
                else
                {
                    count = 0;
                    directories.AddRange(listDirs);
                }
                lastCount = max;

               
            }
            SetToBox();
        }
        public void SetToBox()
        {
            for (int i = 0; i < directories.Count; i++)
            {
                string[] dir = new string[0];
                try
                {
                    dir = Directory.GetFiles(directories[i], "*.txt");
                    if (dir.Length != 0)
                    {
                        foreach (string s in dir)
                        {
                            lbxFiles.Items.Add(s);
                        }
                    }
                }
                catch(Exception ex)
                {
                    
                }
            }
        }

        private void cmbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxFiles.Items.Clear();
            directories.Clear();
            SearchDirectory(cmbDrivers.SelectedItem.ToString());
        }
    }
}
