﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                   webBrowser.Url = new Uri(fbd.SelectedPath);
                   Path.Text = fbd.SelectedPath;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if(webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if(webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }
    }
}
