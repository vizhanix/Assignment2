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

    /// <summary>
    /// form class that is the front page for the application
    /// </summary>
    public partial class Form1 : Form
    {

        //default constructor
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// dropdown in menu option which opens a new file to type in the code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //newfile object creation
            NewFile obj = new NewFile();
            this.Hide();
            obj.Show();
        }

        /// <summary>
        /// method that runs when open file dropdown option is clicked 
        /// a new text file is read when done that with help of a dialogbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
