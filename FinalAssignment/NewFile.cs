using ICSharpCode.TextEditor.Document;
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
    public partial class NewFile : Form
    {
        public NewFile()
        {
            InitializeComponent();
        }

        private void NewFile_Load(object sender, EventArgs e)
        {

        }

        private void textEditorControl1_Load(object sender, EventArgs e)
        {
            string dric = Application.StartupPath;
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(dric))
            {
                fsmp = new FileSyntaxModeProvider(dric);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                textEditorControl1.SetHighlighting("C#");
            }

        }
    }
}
