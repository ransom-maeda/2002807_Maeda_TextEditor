using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_TextEditor
{
    public partial class FileName : Form
    {
        Form1 form;

        public FileName(Form1 frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void Ok_Click_1(object sender, EventArgs e)
        {
            form.SaveFile(nameInput.Text);
            this.Close();
        }
    }
}
