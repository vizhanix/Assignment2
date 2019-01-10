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

namespace FinalAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile obj = new NewFile();
            this.Hide();
            obj.Show();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog opn = new OpenFileDialog();
            if(opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = opn.OpenFile()) != null )
                {
                    string strFileName = opn.FileName;
                    string filetext = File.ReadAllText(strFileName);

                    NewFile obj = new NewFile();
                    obj.copyText(filetext);

                    this.Hide();
                    obj.Show();

                }
                
            }
        }
    }
}
