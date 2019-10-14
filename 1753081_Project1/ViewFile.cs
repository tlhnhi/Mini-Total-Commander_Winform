using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _1753081_Project1
{
    public partial class ViewFile : Form
    {
        public ViewFile(string filePath)
        {
            InitializeComponent();

            FileStream theFile = File.Open(filePath, FileMode.Open, FileAccess.Read);
            StreamReader readStream = new StreamReader(theFile);
            while (!readStream.EndOfStream)
            {
                string line = readStream.ReadLine();
                FileContent.AppendText(line);
                FileContent.AppendText(Environment.NewLine);
            }
            readStream.Close();
            theFile.Close();
        }
    }
}
