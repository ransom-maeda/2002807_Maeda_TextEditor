using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_TextEditor
{
    public partial class Form1 : Form
    {
        string currentDir = Path.GetDirectoryName(Environment.CurrentDirectory);
        string projectDir;


        public Form1()
        {
            InitializeComponent();
            projectDir = Directory.GetParent(currentDir).Parent.FullName;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName frm2 = new FileName(this);
            frm2.ShowDialog();
        }

        private void oPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = text.Text;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = projectDir;
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    ReadWrite rw = new ReadWrite(filePath);
                    fileContent = rw.ReadFile();
                    text.Text = fileContent;
                }
            }
        }

        public void SaveFile(string FileName)
        {
            string[] filePath = { projectDir, FileName + ".txt" };
            string FullPath = Path.Combine(filePath);

            ReadWrite rw = new ReadWrite(FullPath);
            rw.WriteToFile(ConvertToArray(text.Text));
        }

        private string[] ConvertToArray(string text)
        {
            return new []{ text };
        }
    }
}
